using System;
using RestSharp.Deserializers;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XLeaType.cs
 */
namespace RicOneApi.Models.XPress
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

        public XLeaCollectionType GetObjects { get; set; }
        public XLeaType GetObject
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }
    }
}
