using RestSharp.Deserializers;
using System;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-12-20
 * Filename    XStaffType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XStaffType
    /// </summary>
    public class XStaffType
    {
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public XPersonNameType name { get; set; }
        public string localId { get; set; }
        public string stateProvinceId { get; set; }
        public XOtherPersonIdListType otherIds { get; set; }
        public XAppProvisioningInfoType appProvisioningInfo { get; set; }
        public XPersonAddressType address { get; set; }
        public XOtherPersonAddressListType otherAddresses { get; set; }
        public XTelephoneType phoneNumber { get; set; }
        public XTelephoneListType otherPhoneNumbers { get; set; }
        public string sex { get; set; }
        public XEmailType email { get; set; }
        public XEmailListType otherEmails { get; set; }
        public XStaffPersonAssignmentType primaryAssignment { get; set; }
        public XStaffPersonAssignmentListType otherAssignments { get; set; }
        public XLanguageListType languages { get; set; }
        public XMetadata Metadata { get; set; }

        public XStaffType()
        {
            refId = null;
            name = new XPersonNameType();
            localId = null;
            stateProvinceId = null;
            otherIds = new XOtherPersonIdListType();
            appProvisioningInfo = new XAppProvisioningInfoType();
            address = new XPersonAddressType();
            otherAddresses = new XOtherPersonAddressListType();
            phoneNumber = new XTelephoneType();
            otherPhoneNumbers = new XTelephoneListType();
            sex = null;
            email = new XEmailType();
            otherEmails = new XEmailListType();
            primaryAssignment = new XStaffPersonAssignmentType();
            otherAssignments = new XStaffPersonAssignmentListType();
            languages = new XLanguageListType();
            Metadata = new XMetadata();
        }

        public XStaffCollectionType GetObjects { get; set; }
        public XStaffType GetObject
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }

    }
}
