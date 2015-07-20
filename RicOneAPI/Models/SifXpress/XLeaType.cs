using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XLeaType
    /// </summary>
    public class XLeaType
    {
        public XLeaType()
        {
            refId = null;
            localId = null;
            leaRefId = null;
            stateProvinceId = null;
            ncesId = null;
            leaName = null;
            address = new XOrganizationAddressType();
            phoneNumber = new XTelephoneType();
            otherPhoneNumbers = new XTelephoneListType();
        }

        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string localId { get; set; }
        public string leaRefId { get; set; }
        public string stateProvinceId { get; set; }
        public string ncesId { get; set; }
        public string leaName { get; set; }
        public XOrganizationAddressType address { get; set; }
        public XTelephoneType phoneNumber { get; set; }
        public XTelephoneListType otherPhoneNumbers { get; set; }
    }
}
