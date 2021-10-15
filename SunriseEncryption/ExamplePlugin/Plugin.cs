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
        public static object Load(string input) { return null;  }
        public static void Initalize() 
        {
            Toasting toast = new Toasting();
            toast.AddPluginName("ExamplePlugin");
            toast.AddPluginAuthor("Monarch TSA");
            toast.AddPluginVersion("1.0.0");
            toast.AddPluginInfo("An Example Plugin");

            toast.Load();
        }
    }
}
