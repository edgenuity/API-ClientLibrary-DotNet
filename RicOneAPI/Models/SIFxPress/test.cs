using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneAPI.Models.SIFxPress
{

    public class Rootobject
    {
        public XLeas xLeas { get; set; }
    }

    public class XLeas
    {
        public Xlea[] xLea { get; set; }
    }

    public class Xlea
    {
        public string refId { get; set; }
        public string localId { get; set; }
        public string stateProvinceId { get; set; }
        public string ncesId { get; set; }
        public string leaName { get; set; }
        public object address { get; set; }
        public Phonenumber phoneNumber { get; set; }
        public Otherphonenumbers otherPhoneNumbers { get; set; }
    }

    public class Phonenumber
    {
        public string phoneNumberType { get; set; }
        public string number { get; set; }
        public string primaryIndicator { get; set; }
    }

    public class Otherphonenumbers
    {
        public Phonenumber1 phoneNumber { get; set; }
    }

    public class Phonenumber1
    {
        public string phoneNumberType { get; set; }
        public string number { get; set; }
        public string primaryIndicator { get; set; }
    }

}
