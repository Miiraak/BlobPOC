// You need to ensure that the BlobPE library is referenced in your project.
using BlobPE;

namespace BlobPOC
{
    internal static class Program
    {
        [STAThread]
        // Add the argument to the Main method to allow BlobPE to process command line arguments.
        static void Main(string[] args)
        {
            // BlobPE needs to be initialized with a Dictionary of default values.
            // Important: `int` set the maximum length for related key, it's not the actual value.
            Dictionary<string, int> defaultData = new Dictionary<string, int>
            {
                { "string", 50 },
                { "int", 2 },
                { "bool", 5 }
            };
            // Then you need to check for updates and initialize the BlobPE library with the arguments and default data.
            Blob.CheckForUpdates(args, defaultData);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}