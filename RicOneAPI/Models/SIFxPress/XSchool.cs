using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XSchoolType
    /// </summary>
    public class XSchool
    {
        public XSchool()
        {
            refId = null;
            leaRefId = null;
            localId = null;
            stateProvinceId = null;
            otherIds = new OtherIds();
            schoolName = null;
            yearGroups = new YearGroups();
            address = new Address();
            phoneNumber = new PhoneNumber();
            otherPhoneNumbers = new OtherPhoneNumbers();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string leaRefId { get; set; }
        public string localId { get; set; }
        public string stateProvinceId { get; set; }
        public OtherIds otherIds { get; set; }
        public string schoolName { get; set; }
        public YearGroups yearGroups { get; set; }
        public Address address { get; set; }
        public PhoneNumber phoneNumber { get; set; }
        public OtherPhoneNumbers otherPhoneNumbers { get; set; }
    }
}
