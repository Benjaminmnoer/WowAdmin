using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace WowAdmin.Persistence.Helpers
{
    public static class CryptographyHelpers
    {
        public static byte[] Hash(string input)
        {
            return SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
        }

        public static byte[] Hash(IEnumerable<byte> input)
        {
            return SHA1.Create().ComputeHash(input.ToArray());
        }

        public static BigInteger ToSrpBigInt(this byte[] bytes, bool bigEndian = true)
        {
            return new BigInteger(bytes, true, bigEndian);
        }

        // Add padding character back to hex before parsing
        public static BigInteger ToSrpBigInt(this string hex)
        {
            return BigInteger.Parse("0" + hex, NumberStyles.HexNumber);
        }

        public static byte[] ToBytes(this string hex)
        {
            var hexAsBytes = new byte[hex.Length / 2];

            for (var i = 0; i < hex.Length; i += 2)
            {
                hexAsBytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return hexAsBytes;
        }
    }
}