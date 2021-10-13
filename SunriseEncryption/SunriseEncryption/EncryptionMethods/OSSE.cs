using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseEncryption.EncryptionMethods
{
    public class OSSE
    {
        public static string Encryptor(string Sentence)
        {
            string[] Words = Sentence.ToLower().Split(' ');

            Random rng = new Random();

            List<char> AlphabetChar = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            List<char> SCPChar = new List<char> { '.', '*', '<', '>', '-' };

            List<int> WordValues = new List<int>();

            string StringBuilder = string.Empty;

            foreach (var Word in Words)
            {
                int wordValue = 0;

                List<int> avgSize = new List<int>();

                bool firstLetter = true;
                int firstLetterSize = 0;

                int lowestValue = 0;

                foreach (char Character in Word)
                {
                    int letterIndex = AlphabetChar.IndexOf(Character) + 1;
                    wordValue = wordValue + letterIndex;

                    if (letterIndex < lowestValue || lowestValue == 0)
                        lowestValue = letterIndex;

                    avgSize.Add(letterIndex);
                    bool select = true;



                    if (firstLetter)
                        firstLetterSize = letterIndex;
                    while (select)
                    {
                        if (letterIndex > 10)
                        {
                            int getRandomCharIndex = rng.Next(SCPChar.Count);
                            char getRandomChar = SCPChar[getRandomCharIndex];
                            int valueOfChar = SCPChar.IndexOf(getRandomChar) + 1;
                            letterIndex = letterIndex - valueOfChar;
                            StringBuilder += getRandomChar;
                        }
                        else
                        {
                            switch (letterIndex)
                            {
                                case 10:
                                case 9:
                                case 8:
                                case 7:
                                case 6:
                                case 5:
                                    List<char> f = new List<char> { '>', '<', '*', '.' };
                                    int fb = rng.Next(f.Count);
                                    char fc = f[fb];

                                    int fd = SCPChar.IndexOf(fc) + 1;
                                    letterIndex = letterIndex - fd;
                                    StringBuilder += fc;
                                    break;
                                case 4:
                                    List<char> g = new List<char> { '>', '<', '*', '.' };
                                    int gb = rng.Next(g.Count);
                                    char gc = g[gb];

                                    int gd = SCPChar.IndexOf(gc) + 1;
                                    letterIndex = letterIndex - gd;
                                    StringBuilder += gc;
                                    break;
                                case 3:
                                    List<char> h = new List<char> { '<', '*', '.' };
                                    int hb = rng.Next(h.Count);
                                    char hc = h[hb];

                                    int hd = SCPChar.IndexOf(hc) + 1;
                                    letterIndex = letterIndex - hd;
                                    StringBuilder += hc;
                                    break;
                                case 2:
                                    List<char> i = new List<char> { '*', '.' };
                                    int ib = rng.Next(i.Count);
                                    char ic = i[ib];

                                    int id = SCPChar.IndexOf(ic) + 1;
                                    letterIndex = letterIndex - id;
                                    StringBuilder += ic;
                                    break;
                                default:
                                    if (letterIndex == 1)
                                    {
                                        StringBuilder += '.';
                                        letterIndex = 0;
                                        break;
                                    }
                                    if (letterIndex == 0)
                                    {
                                        select = false;
                                        break;
                                    }

                                    select = false;
                                    break;
                            }
                        }

                        firstLetter = false;

                    }

                }

                int size = 0;
                foreach (int avg in avgSize)
                {
                    size = size + avg;
                }

                double averageInt = size / avgSize.Count;

                StringBuilder += $" [{wordValue}x{Math.Round(averageInt, 0)}x0{firstLetterSize}][{lowestValue}]";
            }
            return StringBuilder;
        }
    }
}
