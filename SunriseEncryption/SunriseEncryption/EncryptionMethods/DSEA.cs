using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseEncryption.EncryptionMethods
{
    public class DSEA
    {
        public DSEA(string rawText, int key)
        {
            Text = rawText;
            Key = key;
        }

        private string Text;
        private int Key;

        public string EncryptMessage()
        {
            Keys key = new Keys(Key);
            List<char> KeyList = key.GetCorrespondingList();

            string emptyMessage = "";
            foreach (char letter in Text.ToLower())
            {
                if (char.IsLetter(letter))
                {
                    int indexOfAlphabet = Alphabet.IndexOf(letter);
                    char newLetter = KeyList[indexOfAlphabet];
                    emptyMessage += newLetter;
                }
                else
                    emptyMessage += ' ';
            }

            string firstLayer = emptyMessage;
            string secondLayer = CaesarCipher.Encrypt(firstLayer, key.CalculateShift(firstLayer));
            return secondLayer;
        }
        
        public string DecryptMessage()
        {
            int reversedShift = Keys.ReverseShift(Text, Key);
            string reverseCaesar = CaesarCipher.Decrypt(Text, reversedShift);

            Keys decryptKey = new Keys(Key);
            List<char> newList = decryptKey.GetCorrespondingList();

            string newMessage = "";
            foreach (char letter in reverseCaesar.ToLower())
            {
                if (char.IsLetter(letter))
                {
                    int index = newList.IndexOf(letter);
                    char newLetter = Alphabet[index];
                    newMessage += newLetter;
                }
                else
                    newMessage += ' ';
            }
            
            return newMessage;
        }

        private List<char> Alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    }
}
