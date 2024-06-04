using System;
using System.Net;

namespace FuxForm.Algorithms
{
    internal class Generator
    {
        public static string GenerateUnlockKey()
        {
            string ClientID = CaesarCipher(AdapticID(), 15);
            return ClientID;
        }
        public static string GetIP()
        {
            try
            {
                using (var signal = new WebClient())
                {
                    string signalResultated = signal.DownloadString("http://api.ipify.org");
                    return signalResultated;
                }
            }
            catch
            {
                return "FALSE";
            }
        }

        private static string AdapticID()
        {
            return $"AZR{Environment.MachineName}XSN";
        }
        private static string CaesarCipher(string text, int shift)
        {
            shift = shift % 26;
            char[] buffer = text.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)(((letter + shift - offset) % 26) + offset);
                }

                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
