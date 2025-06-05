using System.Collections.Generic;
using System.Diagnostics;

namespace BlobPOC
{
    internal static class AppSettings
    {
        private static Dictionary<string, string> _data;

        static AppSettings()
        {
            _data = BlobStore.Read();
        }

        public static string Get(string key)
        {
            _data.TryGetValue(key, out var value);
            return value;

        }

        public static bool GetBool(string key)
        {
            _data.TryGetValue(key, out var value);
            bool.TryParse(value, out var result);
            return result;
        }

        public static int GetInt(string key)
        {
            _data.TryGetValue(key, out var value);
            int.TryParse(value, out var result);
            return result;
        }

        public static void Set(string key, object value)
        {
            _data[key] = value.ToString();
        }

        public static void Save()
        {
            string exePath = Process.GetCurrentProcess().MainModule.FileName;
            SelfUpdater.UpdateAndRestart(_data);
        }
    }
}
