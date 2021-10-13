using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SunriseEncryption.EncryptionMethods
{
    public class Hashing
    {
        public Hashing(string text)
        {
            RawText = text;
        }

        internal string RawText;

        public string MD5Hash(bool lowerCase = false)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(RawText);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    if (lowerCase)
                        sb.Append(hashBytes[i].ToString("x2"));
                    else
                        sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public string SHA1Hash(bool lowerCase = false)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(RawText));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    if (lowerCase)
                        sb.Append(b.ToString("x2"));
                    else
                        sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public string SHA256Hash(bool lowerCase = false)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(RawText));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {

                    if (lowerCase)
                        builder.Append(bytes[i].ToString("x2"));
                    else
                        builder.Append(bytes[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }

        public string SHA384Hash(bool lowerCase = false)
        {
            using (SHA384 sha384Hash = SHA384.Create())
            {
                byte[] bytes = sha384Hash.ComputeHash(Encoding.UTF8.GetBytes(RawText));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (lowerCase)
                        sb.Append(bytes[i].ToString("x2"));
                    else
                        sb.Append(bytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public string SHA512Hash(bool lowerCase = false)
        {
            using (SHA512 sha512hash = SHA512.Create())
            {
                byte[] bytes = sha512hash.ComputeHash(Encoding.UTF8.GetBytes(RawText));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (lowerCase)
                        sb.Append(bytes[i].ToString("x2"));
                    else
                        sb.Append(bytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public string RIPEMD160HASH(bool lowerCase = false)
        {
            using (RIPEMD160 ripemd = RIPEMD160.Create())
            {
                byte[] bytes = ripemd.ComputeHash(Encoding.UTF8.GetBytes(RawText));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (lowerCase)
                        sb.Append(bytes[i].ToString("x2"));
                    else
                        sb.Append(bytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
