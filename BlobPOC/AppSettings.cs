using System.Collections.Generic;

namespace BlobPOC
{
    internal static class AppSettings
    {
        private static Dictionary<string, string> _data;

        static AppSettings()
        {
            _data = BlobStore.Read();
        }

        public static string Get(string key, string defaultValue = "")
        {
            return _data.TryGetValue(key, out var value) ? value : defaultValue;
        }

        public static bool GetBool(string key, bool defaultValue = false)
        {
            if (_data.TryGetValue(key, out var value) && bool.TryParse(value, out var result))
                return result;
            return defaultValue;
        }

        public static int GetInt(string key, int defaultValue = 0)
        {
            if (_data.TryGetValue(key, out var value) && int.TryParse(value, out var result))
                return result;
            return defaultValue;
        }

        public static void Set(string key, object value)
        {
            _data[key] = value.ToString();
        }

        public static void Save()
        {
            string exePath = Application.ExecutablePath;
            BlobStore.Write(exePath, _data);
        }
    }
}
