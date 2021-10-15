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
        public static void CheckPluginAvailability()
        {
            foreach (var files in Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "Plugins")))
            {
                if (files.Contains(".dll") && !files.Contains("Toaster"))
                {
                    // Potential Plugin
                    Assembly assembly = Assembly.LoadFrom(files);
                    Type[] AssemblyType = assembly.GetTypes();

                    int requiredMethods = 0;
                    foreach (var typeClass in AssemblyType)
                    {
                        foreach (var method in typeClass.GetMethods())
                        {
                            if (method.Name == "Initalize")
                                requiredMethods += 1;

                            if (method.Name == "Load")
                                requiredMethods += 1;
                        }
                    }

                    if (requiredMethods == 2)
                        AvailablePlugins.Add(files);
                }
            }
        }

        internal static List<string> AvailablePlugins = new List<string>();
    }
}
