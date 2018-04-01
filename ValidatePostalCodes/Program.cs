using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ValidatePostalCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PostalCodes> postalCodes = new List<PostalCodes>();
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
                    postalCodes.Add(new PostalCodes(parts[0], parts[1]));
                }
            }

            if (postalCodes.Where(x => x.PostalCode == "2625").Count() == 0)
            {
                Console.WriteLine("Does not contain");
            }
            Console.ReadLine();

        }
    }

    public class PostalCodes
    {
        public PostalCodes(string country, string postalCode)
        {
            Country = country;
            PostalCode = postalCode;
        }

        public string Country { get; set; }

        public string PostalCode { get; set; }
    }
}
