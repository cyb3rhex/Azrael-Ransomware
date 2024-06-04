using Microsoft.Win32;
using System;
using System.IO;

namespace FuxForm.Algorithms
{
    internal class AuxiliaryFunctions
    {
        public static string GetStartupTime()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(config.ProgramRegKey))
                {
                    if (key != null)
                    {
                        object value = key.GetValue(config.StartupTime);
                        if (value != null)
                        {
                            return value.ToString();
                        }
                    }
                }

                string currentTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(config.ProgramRegKey))
                {
                    key.SetValue(config.StartupTime, currentTime);
                }

                return currentTime;
            }
            catch { return "none"; }
        }

        public static string ChkRegistry(string path, string keyName)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(path) ?? Registry.CurrentUser.CreateSubKey(path))
                {

                    object value = key.GetValue(keyName);
                    if (value == null)
                    {
                        return "0";
                    }

                    else
                    {
                        return "1";
                    }
                }
            } catch { return "Failed to open reg-key"; }

        }

        public static int EncFiles_Count()
        {

            try
            {
                if (File.Exists(config.EncFiles_log))
                {
                    string[] lines = File.ReadAllLines(config.EncFiles_log);
                    return lines.Length;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

    }
}
