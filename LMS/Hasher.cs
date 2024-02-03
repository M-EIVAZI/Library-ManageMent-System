using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Hasher
    {   public Hasher()
        {

        }
            public static (string HashedPassword, string Salt) HashPassword(string password)
            {
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]); // Generate salt

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256);
                byte[] hash = pbkdf2.GetBytes(20);

                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                string hashedPassword = Convert.ToBase64String(hashBytes);

                return (hashedPassword, Convert.ToBase64String(salt));
            }

            public static bool VerifyPassword(string enteredPassword, string storedHashedPassword, string storedSalt)
            {
                byte[] hashBytes = Convert.FromBase64String(storedHashedPassword);
                byte[] salt = Convert.FromBase64String(storedSalt);

                var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000, HashAlgorithmName.SHA256);
                byte[] hash = pbkdf2.GetBytes(20);

                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        return false; // Passwords don't match
                    }
                }
                return true; // Passwords match
            }
        }

    }


