using IdentityDimo.Models.Extra;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDimo.Utils
{
    public class Helper
    {
        public static string Lang(String multiLanguageObject)
        {
           // MultiLanguage multiLanguageObject
           try
            {
                var lang = CultureInfo.CurrentCulture.Name;
            // var json = JsonConvert.SerializeObject(multiLanguageObject);
            var json = multiLanguageObject;
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                var val = dictionary[lang];
                val = !string.IsNullOrWhiteSpace(val)
                    ? val
                    : dictionary.FirstOrDefault(r => !string.IsNullOrWhiteSpace(r.Value)).Value;
                return val ?? "";
            }
            catch (Exception)
            {
                //ignore
            }

            return "";
        }
    }
}
