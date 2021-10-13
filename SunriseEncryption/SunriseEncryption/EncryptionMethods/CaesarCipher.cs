using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseEncryption.EncryptionMethods
{
    public class CaesarCipher
    {
        public static char Cipher(char ch, int shift)
        {
            if (!char.IsLetter(ch))
                return ch;

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + shift) - d) % 26) + d);
        }

        public static string Encrypt(string text, int shift)
        {
            string output = string.Empty;
            foreach (char ch in text)
                output += Cipher(ch, shift);

            return output;
        }
        public static string Decrypt(string text, int shift) { return Encrypt(text, 26 - shift); }

    }
}
