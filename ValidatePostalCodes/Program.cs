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
            PostalCodeValidator postalCodeValidator = new PostalCodeValidator();
            postalCodeValidator.Validate("60187", "US");

            Console.ReadLine();
        }
    }
}
