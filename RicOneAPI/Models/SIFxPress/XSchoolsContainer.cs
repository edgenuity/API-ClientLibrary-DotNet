using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{

    public class XSchoolsContainer
    {
        public XSchools xSchools { get; set; }
    }

    public class XSchools
    {
        public List<XSchool> xSchool { get; set; }
    }

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
            address = new Address();
            phoneNumber = new PhoneNumber();
            otherPhoneNumbers = new OtherPhoneNumbers();
        }
        public string refId { get; set; }
        public string leaRefId { get; set; }
        public string localId { get; set; }
        public string stateProvinceId { get; set; }
        public OtherIds otherIds { get; set; }
        public string schoolName { get; set; }
        public Address address { get; set; }
        public PhoneNumber phoneNumber { get; set; }
        public OtherPhoneNumbers otherPhoneNumbers { get; set; }
    }

    public class OtherIds
    {
        public List<OtherId> otherId { get; set; }
    }

    public class OtherId
    {
        public string type { get; set; }
        public string id { get; set; }
    }
}
