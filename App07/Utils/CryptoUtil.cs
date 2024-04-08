using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app07.Utils
{
    public static class CryptoUtil
    {
        public static string ToHashSha512(this string plainText)
        {
            var sha512Alg = SHA512.Create();
            var bytes = Encoding.UTF8.GetBytes(plainText);
            var hash = sha512Alg.ComputeHash(bytes);

            var result = "";
            for (int i = 0; i< hash.Length; i++)
            {
                result += hash[i].ToString("X2");
            }

            var tmp = String.Concat(hash.Select(b => b.ToString("X2")).ToArray());

            return result; 
        }
    }
}
