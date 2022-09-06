using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Toaster;

namespace ExamplePlugin
{
    public class Plugin
    {
        public static object Load(string input) 
        {
            List<char> AlphabetList = new List<char> {
            'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
            };
            string x = "";
            for (int i = 0; i < input.ToString().Length; i++)
            {
                char letter = input.ToString()[i];
                if (AlphabetList.Contains(letter))
                    x += $"{AlphabetList.IndexOf(letter)} ";
                else
                    x += "0 ";

            }

            return x;
        }
        public static void Initalize() 
        {
            Toasting toast = new Toasting();
            toast.AddPluginName("String Reverse");
            toast.AddPluginAuthor("Monarch TSA");
            toast.AddPluginVersion("1.0.0");
            toast.AddPluginInfo("Reverse your Input String!");

            toast.Load();
        }
    }
}
