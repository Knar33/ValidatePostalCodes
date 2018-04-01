using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatePostalCodes
{
    public class PostalCode
    {
        public PostalCode(string country, string code)
        {
            Country = country;
            Code = code;
        }

        public string Country { get; set; }

        public string Code { get; set; }
    }
}
