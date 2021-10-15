using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunriseEncryption.Plugin
{
    public class InitalizePlugin
    {
        public static void Initalize()
        {
            foreach (string Plugins in LoadPlugin.AvailablePlugins)
            {
                Assembly assembly = Assembly.LoadFrom(Plugins);
                Type[] assemblyTypes = assembly.GetTypes();
                foreach (var type in assemblyTypes) {
                    foreach (var method in type.GetMethods()) {
                        if (method.Name == "Initalize") {
                            var response = method.Invoke(null, null);
                        }
                    }
                }
            }

        }
    }
}
 