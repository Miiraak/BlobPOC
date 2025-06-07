using BlobPE;

namespace BlobPOC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Dictionary<string, int> defaultData = new Dictionary<string, int>
            {
                { "lang", 5 },
                { "ext", 5 },
                { "autolog", 5 }
            };
            Blob.CheckForUpdates(args, defaultData);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}