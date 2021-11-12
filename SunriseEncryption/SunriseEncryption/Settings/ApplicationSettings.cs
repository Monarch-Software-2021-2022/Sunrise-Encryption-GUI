using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace SunriseEncryption.Settings
{
    public class ApplicationSettings
    {
        private static string appSettings = Path.Combine(Directory.GetCurrentDirectory(), "appSettings.json");
        public static void LoadSettings()
        {
            if (!File.Exists(appSettings))
            {
                Config newCfg = new Config
                {
                    PluginInfoEnabled = true,
                    PluginAuthorEnabled = false,
                    PluginVersionEnabled = false,
                    DarkThemeEnabled = false
                };
                
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                using (StreamWriter sw = new StreamWriter(appSettings))
                {
                    sw.WriteLine(JsonSerializer.Serialize(newCfg, options));
                    sw.Close();
                }
            }

            Config cfg = JsonSerializer.Deserialize<Config>(File.ReadAllText(appSettings));
            PluginInfo = cfg.PluginInfoEnabled;
            PluginAuthor = cfg.PluginAuthorEnabled;
            PluginVersion = cfg.PluginVersionEnabled;

            DarkTheme = cfg.DarkThemeEnabled;


        }

        public static void ApplySettings(Config cfg)
        {
            File.Delete(appSettings);
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            using (StreamWriter sw = new StreamWriter(appSettings))
            {
                sw.WriteLine(JsonSerializer.Serialize(cfg, options));
                sw.Close();
            }

            PluginInfo = cfg.PluginInfoEnabled;
            PluginAuthor = cfg.PluginAuthorEnabled;
            PluginVersion = cfg.PluginVersionEnabled;

            DarkTheme = cfg.DarkThemeEnabled;
        }

        public static bool PluginInfo;
        public static bool PluginAuthor;
        public static bool PluginVersion;

        public static bool DarkTheme;
    }
}
