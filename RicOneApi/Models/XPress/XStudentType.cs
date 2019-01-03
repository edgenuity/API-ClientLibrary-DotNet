using System;
using RestSharp.Deserializers;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-12-20
 * Filename    XStudentType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XStudentType
    /// </summary>
    public class XStudentType
    {
        public XStudentType()
        {
            refId = null;
            name = new XPersonNameType();
            otherNames = new XOtherPersonNameListType();
            localId = null;
            stateProvinceId = null;
            otherIds = new XOtherPersonIdListType();
            appProvisioningInfo = new XAppProvisioningInfoType();
            address = new XPersonAddressType();
            phoneNumber = new XTelephoneType();
            otherPhoneNumbers = new XTelephoneListType();
            email = new XEmailType();
            otherEmails = new XEmailListType();
            demographics = new XDemographicsType();
            enrollment = new XEnrollmentType();
            otherEnrollments = new XEnrollmentListType();
            academicSummary = new XAcademicSummaryType();
            studentContacts = new XStudentContactListType();
            languages = new XLanguageListType();
            Metadata = new XMetadata();

        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public XPersonNameType name { get; set; }
        public XOtherPersonNameListType otherNames { get; set; }
        public string localId { get; set; }
        public string stateProvinceId { get; set; }
        public XOtherPersonIdListType otherIds { get; set; }
        public XAppProvisioningInfoType appProvisioningInfo { get; set; }
        public XPersonAddressType address { get; set; }
        public XTelephoneType phoneNumber { get; set; }
        public XTelephoneListType otherPhoneNumbers { get; set; }
        public XEmailType email { get; set; }
        public XEmailListType otherEmails { get; set; }
        public XDemographicsType demographics { get; set; }
        public XEnrollmentType enrollment { get; set; }
        public XEnrollmentListType otherEnrollments { get; set; }
        public XAcademicSummaryType academicSummary { get; set; }
        public XStudentContactListType studentContacts { get; set; }
        public XLanguageListType languages { get; set; }
        public XMetadata Metadata { get; set; }

        public XStudentCollectionType GetObjects { get; set; }
        public XStudentType GetObject
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }
    }
}
