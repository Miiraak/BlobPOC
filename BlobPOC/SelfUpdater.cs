using System.Diagnostics;
using System.Text.Json;

namespace BlobPOC
{
    internal class SelfUpdater
    {
        public static void UpdateAndRestart(Dictionary<string, string> updatedData)
        {
            string exePath = Process.GetCurrentProcess().MainModule.FileName;
            string tempPath = Path.Combine(Path.GetTempPath(), "update_" + Guid.NewGuid() + ".exe");

            File.Copy(exePath, tempPath, true);
            string payload = JsonSerializer.Serialize(updatedData);
            Process.Start(tempPath, $"--update \"{exePath}\" \"{payload.Replace("\"", "\\\"")}\"");
            Environment.Exit(0);
        }

        public static void ApplyUpdate(string targetPath, string jsonData)
        {
            while (IsLocked(targetPath))
                Thread.Sleep(100);

            var data = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonData);
            BlobStore.Write(targetPath, data);
            Process.Start(targetPath);
            Environment.Exit(0);
        }

        private static bool IsLocked(string file)
        {
            try
            {
                using (FileStream stream = File.Open(file, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    return false;
            }
            catch
            {
                return true;
            }
        }
    }
}
