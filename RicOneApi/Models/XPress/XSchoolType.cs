using System;
using RestSharp.Deserializers;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XSchoolType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XSchoolType
    /// </summary>
    public class XSchoolType
    {
        public XSchoolType()
        {
            refId = null;
            leaRefId = null;
            localId = null;
            stateProvinceId = null;
            otherIds = new XOtherOrganizationIdListType();
            schoolName = null;
            gradeLevels = new XGradeLevelListType();
            address = new XOrganizationAddressType();
            phoneNumber = new XTelephoneType();
            otherPhoneNumbers = new XTelephoneListType();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string leaRefId { get; set; }
        public string localId { get; set; }
        public string stateProvinceId { get; set; }
        public XOtherOrganizationIdListType otherIds { get; set; }
        public string schoolName { get; set; }
        public XGradeLevelListType gradeLevels { get; set; }
        public XOrganizationAddressType address { get; set; }
        public XTelephoneType phoneNumber { get; set; }
        public XTelephoneListType otherPhoneNumbers { get; set; }

        public XSchoolCollectionType GetObjects { get; set; }
        public XSchoolType GetObject
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }
    }
}
