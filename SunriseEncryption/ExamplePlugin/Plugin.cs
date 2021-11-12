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
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
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
