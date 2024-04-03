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

        public async Task<(bool, string)> CreateUser(string accountName, string password, string? email)
        {
            var salt = new byte[32];
            RandomNumberGenerator.Create().GetBytes(salt);

            var h1 = CryptographyHelpers.Hash((accountName + ":" + password).ToUpper());
            var h2 = CryptographyHelpers.Hash(salt.Concat(h1)).ToSrpBigInt(false);

            var N = CryptographyHelpers.ToBytes(hex).ToSrpBigInt();
            var verifier = BigInteger.ModPow(G, h2, N).ToByteArray(isUnsigned: true); // (G ^ h2) % N;

            return Task.FromResult((false, "Call to context has not been implemented, account NOT created"));
        }
    }
}
