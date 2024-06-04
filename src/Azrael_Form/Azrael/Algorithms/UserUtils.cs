using FuxForm.Properties;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;

namespace FuxForm.Algorithms
{
    internal class UserUtils
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private const int MAX_PATH = 260;
        private const int SPI_GETDESKWALLPAPER = 0x73;
        private const int SPI_SETDESKWALLPAPER = 0x14;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;

        private static string originalWallpaper;

        private static string GetDesktopWallpaper()
        {
            string wallpaper = new string('\0', MAX_PATH);
            SystemParametersInfo(SPI_GETDESKWALLPAPER, (int)wallpaper.Length, wallpaper, 0);
            return wallpaper.Substring(0, wallpaper.IndexOf('\0'));
        }

        public static void SetDesktopWallpaper()
        {
            if (!IsWallpaperStatusSet())
            {
                originalWallpaper = GetDesktopWallpaper();
           
                if (!File.Exists(config.walpPath))
                {
                    File.WriteAllBytes(config.walpPath, Resources.fux_bmp);
                }
                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, config.walpPath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                SetWallpaperStatus(true);
            }
        }

        public static void RestoreOriginalWallpaper()
        {
            if (!string.IsNullOrEmpty(originalWallpaper))
            {
                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, originalWallpaper, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                originalWallpaper = null;
            }

            if (File.Exists(config.walpPath)) { File.Delete(config.walpPath); }

        }

        private static bool IsWallpaperStatusSet()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(config.ProgramRegKey))
            {
                if (key != null)
                {
                    object value = key.GetValue(config.WallpaperStatus);
                    if (value != null && value.ToString() == "1")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void SetWallpaperStatus(bool status)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(config.ProgramRegKey))
            {
                key.SetValue(config.WallpaperStatus, status ? "1" : "0", RegistryValueKind.String);
            }
        }
    }
}
