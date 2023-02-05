using System.Security.Cryptography;
using System.Text;

namespace MyUzum.Infrastructure.Utils
{
    public class HashGenerate
    {
        public static string Generate(string password)
        {
            const int keySize = 64;
            const int iterations = 350000;

            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                new byte[0],
                iterations,
                hashAlgorithm,
                keySize);

            return Convert.ToHexString(hash);
        }
    }
}
