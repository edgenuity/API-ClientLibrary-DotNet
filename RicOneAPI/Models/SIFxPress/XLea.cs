using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XLeaType
    /// </summary>
    public class XLea
    {
        public XLea()
        {
            refId = null;
            localId = null;
            leaRefId = null;
            stateProvinceId = null;
            ncesId = null;
            leaName = null;
            address = new Address();
            phoneNumber = new PhoneNumber();
            otherPhoneNumbers = new OtherPhoneNumbers();
        }

        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string localId { get; set; }
        public string leaRefId { get; set; }
        public string stateProvinceId { get; set; }
        public string ncesId { get; set; }
        public string leaName { get; set; }
        public Address address { get; set; }
        public PhoneNumber phoneNumber { get; set; }
        public OtherPhoneNumbers otherPhoneNumbers { get; set; }
    }
}
