using System.Collections.Generic;
using System.Management;

namespace Azrael_Loader.Modules
{
    internal class Auxiliary
    {
        public static List<string> GetGPUs()
        {
            var gpus = new List<string>();

            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
                {
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        if (mo["Name"] != null)
                        {
                            gpus.Add(mo["Name"].ToString());
                        }
                    }
                }
            }
            catch { }
            return gpus;
        }
    }
}
