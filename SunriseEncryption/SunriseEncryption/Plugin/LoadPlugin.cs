using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SunriseEncryption.Plugin
{
    public class LoadPlugin
    {
        internal static List<EXPLORE.Plugin> Plugins = new List<EXPLORE.Plugin>();

        private static string PluginDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");
        public static void InitalizeAvaliablePlugins()
        {
            Plugins.Clear();
            string[] allFiles = Directory.GetFiles(PluginDirectory);
            for (int i = 0; i < allFiles.Length; i++)
            {
                string fileName = allFiles[i];
                if (!fileName.Contains(".dll") || fileName.Contains("EXPLORE"))
                    continue;

                EXPLORE.Plugin plugin = new EXPLORE.Plugin(fileName);
                Plugins.Add(plugin);
            }
        }
        public static object OnPluginExecute(EXPLORE.Plugin plugin, string input) => plugin.ExecutePluginEvent(input);

    }
}
