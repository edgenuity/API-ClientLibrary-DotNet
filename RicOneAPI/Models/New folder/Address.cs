using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneAPI.Models.SIFxPress
{
    public class Address
    {
        public Address()
        {
            line1 = null;
            city = null;
            stateProvince = null;
            postalCode = null;
        }

        public string line1 { get; set; }
        public string city { get; set; }
        public string stateProvince { get; set; }
        public string postalCode { get; set; }
    }
}
