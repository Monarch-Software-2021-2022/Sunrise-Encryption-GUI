using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SunriseEncryption.Plugin
{
    public class LoadPluginData
    {
        public static string GetPluginData(string PluginName, PluginData type)
        {
            string PluginDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");
            string PluginFileJSON = File.ReadAllText(Path.Combine(PluginDirectory, PluginName + ".json"));

            PluginJSONData data = JsonSerializer.Deserialize<PluginJSONData>(PluginFileJSON);
            switch (type)
            {
                case PluginData.PluginName:
                    return data.PluginName;
                case PluginData.PluginVersion:
                    return data.PluginVersion;
                case PluginData.PluginAuthor:
                    return data.PluginAuthor;
                case PluginData.PluginInfo:
                    return data.PluginInfo;
            }

            return null;
        }
    }

    public enum PluginData
    {
        PluginName = 0,
        PluginAuthor = 1,
        PluginVersion = 2,
        PluginInfo = 3
    }

    public class PluginJSONData
    {
        public string PluginName { get; set; }
        public string PluginVersion { get; set; }
        public string PluginAuthor { get; set; }
        public string PluginInfo { get; set; }
    }
}
