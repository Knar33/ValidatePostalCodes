using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValidatePostalCodes
{
    public class PostalCodeValidator
    {
        public PostalCodeValidator()
        {
            Codes = new List<PostalCode>();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "ValidatePostalCodes.allCountries.txt";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] parts = line.Split('\t');
                    Codes.Add(new PostalCode(parts[0], parts[1]));
                }
            }
        }

        public bool Validate(string postalCode, string countryCode)
        {
            if (Codes.Count(x => x.Country == countryCode && x.Code == postalCode) == 0)
            {
                return false;
            }
            return true;
        }

        public List<PostalCode> Codes { get; set; }

        public List<PostalCodeFormat> Formats { get; set; }
    }
}
