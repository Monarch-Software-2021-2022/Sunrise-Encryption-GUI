using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toaster;

namespace uwuTranslator
{
    public class Plugin
    {
        public static object Load(string input)
        {
            string uwu = input.ToLower().Replace('l', 'w').Replace('r', 'w');
            return uwu + " <3 uwu";
        }
        public static void Initalize()
        {
            Toasting toast = new Toasting();
            toast.AddPluginName("uwuTranslator");
            toast.AddPluginAuthor("KuebV");
            toast.AddPluginVersion("1.0.0");
            toast.AddPluginInfo("An uwu translator");

            toast.Load();
        }
    }
}
