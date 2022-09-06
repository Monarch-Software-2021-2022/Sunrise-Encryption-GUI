using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseEncryption.EncryptionMethods
{
    public class Keys
    {
        private int Key;

        public Keys(int input)
        {
            if (input > 26)
                Key = input - 26;
            else
                Key = input;
        }

        public int CalculateShift(string encryptedMessage)
        {
            bool loop = true;
            int x = 0;
            int l = encryptedMessage.Length;
            while (loop)
            {
                if (l <= 1)
                    return x / (Key / 2);

                x += l;
                if (x % Key == 1)
                    return x;
                else
                    l--;
            }

            return 12;
        }

        public static int ReverseShift(string encryptedMessage, int Key)
        {
            bool loop = true;
            int x = 0;
            int l = encryptedMessage.Length;
            while (loop)
            {
                if (l <= 1)
                    return x / (Key / 2);

                x += l;
                if (x % Key == 1)
                    return x;
                else
                    l--;
            }

            return 12;
        }

        public List<char> GetCorrespondingList()
        {
            switch (Key)
            {
                case 0:
                case 1:
                    return new List<char> { 'y', 'q', 'g', 'n', 'w', 'e', 'z', 's', 'p', 'j', 'a', 'f', 'x', 'b', 'o', 'u', 'h', 'd', 'r', 't', 'c', 'm', 'l', 'i', 'k', 'v' };
                case 2:
                    return new List<char> { 'g', 'i', 'n', 'q', 'z', 'j', 'f', 'u', 'b', 'w', 'e', 'v', 'k', 'd', 'c', 'a', 's', 'o', 'h', 'r', 'y', 'x', 'p', 'l', 'm', 't' };
                case 3:
                    return new List<char> { 'n', 'l', 'q', 'i', 'f', 'w', 'v', 'a', 'd', 'z', 'j', 't', 'm', 'o', 'y', 'e', 'u', 'c', 's', 'h', 'g', 'k', 'b', 'p', 'x', 'r', };
                case 4:
                    return new List<char> { 'q', 'p', 'i', 'l', 'v', 'z', 't', 'e', 'o', 'f', 'w', 'r', 'x', 'c', 'g', 'j', 'a', 'y', 'u', 's', 'n', 'm', 'd', 'b', 'k', 'h', };
                case 5:
                    return new List<char> { 'i', 'b', 'l', 'p', 't', 'f', 'r', 'j', 'c', 'v', 'z', 'h', 'k', 'y', 'n', 'w', 'e', 'g', 'a', 'u', 'q', 'x', 'o', 'd', 'm', 's', };
                case 6:
                    return new List<char> { 'l', 'd', 'p', 'b', 'r', 'v', 'h', 'w', 'y', 't', 'f', 's', 'm', 'g', 'q', 'z', 'j', 'n', 'e', 'a', 'i', 'k', 'c', 'o', 'x', 'u', };
                case 7:
                    return new List<char> { 'p', 'o', 'b', 'd', 'h', 't', 's', 'z', 'g', 'r', 'v', 'u', 'x', 'n', 'i', 'f', 'w', 'q', 'j', 'e', 'l', 'm', 'y', 'c', 'k', 'a', };
                case 8:
                    return new List<char> { 'b', 'c', 'd', 'o', 's', 'r', 'u', 'f', 'n', 'h', 't', 'a', 'k', 'q', 'l', 'v', 'z', 'i', 'w', 'j', 'p', 'x', 'g', 'y', 'm', 'e', };
                case 9:
                    return new List<char> { 'h', 's', 'i', 'm', 'g', 'q', 'e', 'l', 'a', 'd', 'p', 'b', 'n', 'c', 'x', 'z', 't', 'w', 'r', 'k', 'u', 'j', 'f', 'y', 'v', 'o', };
                case 10:
                    return new List<char> { 'l', 'r', 'a', 'n', 'e', 't', 'g', 'b', 'h', 'm', 'z', 's', 'c', 'i', 'y', 'o', 'k', 'f', 'w', 'p', 'u', 'd', 'q', 'v', 'j', 'x', };
                case 11:
                    return new List<char> { 'b', 'w', 'h', 'c', 'g', 'k', 'e', 's', 'l', 'n', 'o', 'r', 'i', 'a', 'v', 'x', 'p', 'q', 'f', 'z', 'u', 'm', 't', 'j', 'd', 'y', };
                case 12:
                    return new List<char> { 'w', 't', 's', 'h', 'e', 'o', 'g', 'f', 'r', 'a', 'v', 'q', 'l', 'b', 'm', 'j', 'x', 'p', 'k', 'y', 'u', 'i', 'z', 'n', 'c', 'd', };
                case 13:
                    return new List<char> { 's', 'f', 'l', 'i', 'e', 'p', 'g', 'r', 'b', 'c', 'x', 'w', 'a', 'h', 'j', 'y', 'z', 't', 'q', 'o', 'u', 'n', 'k', 'd', 'm', 'v', };
                case 14:
                    return new List<char> { 'r', 'q', 'b', 'a', 'g', 'z', 'e', 'w', 's', 'i', 'y', 'f', 'h', 'l', 'd', 'v', 'o', 'k', 't', 'x', 'u', 'c', 'p', 'm', 'n', 'j', };
                case 15:
                    return new List<char> { 'f', 'k', 'r', 'l', 'g', 'x', 'e', 'q', 'w', 'h', 'j', 't', 'b', 's', 'n', 'd', 'y', 'z', 'p', 'v', 'u', 'a', 'o', 'c', 'i', 'm', };
                case 16:
                    return new List<char> { 'i', 'd', 'u', 'r', 'g', 'z', 'n', 'a', 'q', 'w', 'p', 'h', 'l', 'k', 'y', 'c', 'f', 'j', 'b', 't', 'v', 'e', 'm', 's', 'o', 'x', };
                case 17:
                    return new List<char> { 'q', 'r', 'v', 'j', 'n', 'x', 'k', 'i', 'f', 'm', 'c', 'a', 'h', 'p', 'o', 'u', 'z', 'w', 'd', 't', 'e', 'g', 'l', 'b', 'y', 's', };
                case 18:
                    return new List<char> { 'a', 't', 'z', 'l', 'n', 'w', 'y', 'o', 'e', 'k', 'c', 'd', 'j', 'u', 's', 'r', 'i', 'p', 'b', 'q', 'x', 'm', 'g', 'v', 'h', 'f', };
                case 19:
                    return new List<char> { 'd', 'q', 'i', 'g', 'n', 'p', 'h', 's', 'x', 'y', 'c', 'b', 'l', 'r', 'f', 't', 'o', 'u', 'v', 'a', 'w', 'k', 'm', 'z', 'j', 'e', };
                case 20:
                    return new List<char> { 'w', 'q', 'l', 'd', 'e', 'p', 'i', 'h', 'z', 'r', 'y', 'b', 'n', 'm', 'o', 't', 'x', 'g', 'a', 'f', 'j', 'k', 'c', 'v', 'u', 's', };
                case 21:
                    return new List<char> { 'j', 'r', 'e', 's', 'k', 'c', 'w', 'h', 'g', 'u', 'o', 'b', 'm', 'i', 'l', 'y', 'x', 'z', 'n', 'p', 'f', 'q', 'a', 'v', 't', 'd', };
                case 22:
                    return new List<char> { 'e', 'a', 'f', 'g', 'p', 'r', 'l', 'h', 'd', 'n', 'w', 'b', 'y', 'o', 'j', 'i', 'v', 's', 't', 'q', 'k', 'c', 'u', 'x', 'm', 'z', };
                case 23:
                    return new List<char> { 'e', 'g', 's', 'm', 'u', 'v', 'b', 'y', 'p', 'h', 'c', 'd', 'l', 'k', 'n', 'a', 'r', 'w', 'x', 'j', 'q', 'o', 'i', 'f', 'z', 't', };
                case 24:
                    return new List<char> { 'u', 'b', 'x', 'l', 'q', 'o', 'g', 'z', 'a', 'y', 's', 'm', 'd', 'c', 'k', 'e', 'w', 'i', 'f', 'h', 'r', 'n', 'p', 'v', 't', 'j', };
                case 25:
                    return new List<char> { 'q', 'g', 'f', 'd', 'r', 'n', 'b', 't', 'e', 'z', 'x', 'l', 'm', 's', 'c', 'u', 'i', 'p', 'v', 'y', 'w', 'k', 'a', 'o', 'j', 'h', };
                case 26:
                    return new List<char> { 'q', 'u', 't', 'e', 'f', 'a', 'y', 's', 'r', 'd', 'j', 'i', 'n', 'w', 'h', 'v', 'z', 'p', 'o', 'c', 'g', 'b', 'm', 'k', 'l', 'x', };
                default:
                    return new List<char> { 'q', 'i', 'h', 'b', 'c', 'n', 'f', 'x', 'y', 'k', 'g', 'v', 'm', 'j', 's', 'z', 'o', 'p', 'd', 't', 'l', 'r', 'a', 'e', 'u', 'w', };
            }

            return null;
        }
    }
}
