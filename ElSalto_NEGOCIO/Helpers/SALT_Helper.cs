using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElSalto_NEGOCIO.Helpers
{
    public static class SALT_Helper
    {
        const int i = 10000;
    private static byte[] GetSalt() {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }

        public static string GenerateSaltyPassword(string password)
        {
            byte[] salt = GetSalt();
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, i);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }
        public static bool ValidateSaltyPassword(string password, string passHash)
        {
            byte[] hashBytes = Convert.FromBase64String(passHash);
            byte[] salt = new byte[16];

            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, i);
            byte[] hash = pbkdf2.GetBytes(20);
            int ok = 1;

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    ok = 0;
            }
            if (ok == 1)
                return true;
            else
                return false;
        }
    }

}

