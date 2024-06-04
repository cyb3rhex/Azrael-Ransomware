using Microsoft.Win32;
using System;

namespace Azrael_Loader.Modules
{
    internal class MutexControl
    {
        public static void Initialize()
        {
            string keyName = @"SOFTWARE\" + config.MutexValue;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(keyName);
            if (registryKey != null)
            {
                registryKey.Close();
                Environment.FailFast("");
            }
            else
            {
                Registry.CurrentUser.CreateSubKey(keyName);
            }
        }
    }
}
