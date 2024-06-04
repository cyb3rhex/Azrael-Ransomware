using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FuxForm.Algorithms
{
    internal class DecryptFunctions
    {
        public static string Decryptor()
        {
            byte[] key = Encoding.UTF8.GetBytes(config.DecryptAES_Key);

            try
            {
                DecFiles(config.EncFiles_log, key);
                return "Success_Decrypt";
            }
            catch { return "FAILED"; }
        }
        private static void DecFiles(string fileListPath, byte[] key)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(fileListPath))
                {
                    while (!fileReader.EndOfStream)
                    {
                        string filePath = fileReader.ReadLine() + ".azrael";
                        string decryptedFilePath = Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath));

                        try
                        {
                            DecFileAlgo(filePath, decryptedFilePath, key);
                            File.Delete(filePath);
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private static void DecFileAlgo(string inputFile, string outputFile, byte[] key)
        {
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.Mode = CipherMode.CBC;

                    byte[] iv = new byte[aesAlg.BlockSize / 8];
                    using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
                    {
                        inputStream.Read(iv, 0, iv.Length);
                    }

                    outputFile = outputFile.Replace(".azrael", "");

                    using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
                    using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, iv))
                    using (CryptoStream cryptoStream = new CryptoStream(outputStream, decryptor, CryptoStreamMode.Write))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        using (FileStream encryptedStream = new FileStream(inputFile, FileMode.Open))
                        {
                            encryptedStream.Seek(iv.Length, SeekOrigin.Begin);
                            while ((bytesRead = encryptedStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cryptoStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }
            catch { }
        }
    }
}
