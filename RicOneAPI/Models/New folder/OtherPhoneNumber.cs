using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneAPI.Models.SIFxPress
{
    public class OtherPhoneNumbers
    {
        public OtherPhoneNumbers()
        {
            phoneNumber = new List<PhoneNumber>();
        }
        public List<PhoneNumber> phoneNumber { get; set; }
    }
}
