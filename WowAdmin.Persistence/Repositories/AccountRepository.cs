using Org.BouncyCastle.Asn1.Ocsp;
using System.Numerics;
using System.Security.Cryptography;
using WowAdmin.Persistence.Context;
using WowAdmin.Persistence.Helpers;

namespace WowAdmin.Persistence.Repositories
{
    public class AccountRepository
    {
        private readonly AccountContext _accountContext;
        private const int G = 7;
        private const string hex = "894B645E89E1535BBDAD5B8B290650530801B18EBFBF5E8FAB3C82872A3E9BB7";

        public AccountRepository(AccountContext accountContext)
        {
            _accountContext = accountContext;
        }

        public async Task<(int, string)> CreateUser(string accountName, string password, string? email)
        {
            var salt = new byte[32];
            RandomNumberGenerator.Create().GetBytes(salt);

            var h1 = CryptographyHelpers.Hash((accountName + ":" + password).ToUpper());
            var h2 = CryptographyHelpers.Hash(salt.Concat(h1)).ToSrpBigInt(false);

            var N = CryptographyHelpers.ToBytes(hex).ToSrpBigInt();
            var verifier = BigInteger.ModPow(G, h2, N).ToByteArray(isUnsigned: true); // (G ^ h2) % N;

            _accountContext.Accounts.Add(new Account
            {
                Username = accountName.ToUpper(),
                S = salt.ToHexString(),
                V = verifier.ToHexString(),
                Email = email,
                Joindate = DateTime.Now,
                LastIp = "0.0.0.0",
                FailedLogins = 0,
                Locked = 0,
                LockCountry = "00",
                Online = 0,
                Expansion = 0,
                Mutetime = 0,
                Locale = 0,
                Os = "Win",
                Platform = "x86"
            });

            var result = await _accountContext.SaveChangesAsync();

            if (result != 1)
            {
                return (-1, $"Error saving database changes, number of rows changed is {result}");
            }

            return ((int)_accountContext.Accounts.First(x => x.Username == accountName).Id, "");
        }
    }
}
