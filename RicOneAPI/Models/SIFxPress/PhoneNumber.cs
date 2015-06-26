using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XTelephoneType
    /// </summary>
    public class PhoneNumber
    {
        public PhoneNumber()
        {
            phoneNumberType = null;
            number = null;
            primaryIndicator = null;
        }
        public string phoneNumberType { get; set; }
        public string number { get; set; }
        public string primaryIndicator { get; set; }
    }
}
