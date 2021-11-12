using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toaster;

namespace AdvancedPlugin
{
    public class Plugin
    {
        /// <summary>
        /// Your Input doesnt have to be a string exactly, it can be a directory.
        /// </summary>
        public static object LoadExample(string input)
        {
            MessageBox.Show("You can do a Message Box!");

            // You can even create your own directories!
            string AdvancedPluginDirectory = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "Plugins"), "AdvancedPlugin");
            if (!Directory.Exists(AdvancedPluginDirectory))
                Directory.CreateDirectory(AdvancedPluginDirectory);

            string OutputFile = Path.Combine(AdvancedPluginDirectory, "OutputFile.txt");
            using (StreamWriter sw = new StreamWriter(OutputFile))
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);

                sw.WriteLine(charArray);
                sw.Close();
            }

            return File.ReadAllText(OutputFile);

        }

        public static void Initalize()
        {
            Toasting toast = new Toasting();
            toast.AddPluginName("AdvancedPlugin");
            toast.AddPluginAuthor("Monarch TSA");
            toast.AddPluginVersion("1.0.0-BETA");
            toast.AddPluginInfo("Pushing the Toaster Framework to its limits, or beyond...");

            toast.Load();

        }
    }
}
