using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Azrael_Loader.Modules
{
    internal class CisCheck
    {
        public static bool IsCIS()
        {
            var languages = InputLanguage.InstalledInputLanguages;
            var desiredCultures = new CultureInfo[]
            {
                new CultureInfo("ru-RU"),
                // Ukraine no more CIS country but if u need u can add ukraine in block list just remove <//>
                //new CultureInfo("uk-UA"),

                new CultureInfo("kk-KZ"),
                new CultureInfo("ro-MD"),
                new CultureInfo("uz-UZ"),
                new CultureInfo("be-BY"),
                new CultureInfo("az-Latn-AZ"),
                new CultureInfo("hy-AM"),
                new CultureInfo("ky-KG"),
                new CultureInfo("tg-Cyrl-TJ")
            };

            return languages.Cast<InputLanguage>().Any(language => Array.Exists(desiredCultures, culture => culture.Equals(language.Culture)));
        }
    }
}
