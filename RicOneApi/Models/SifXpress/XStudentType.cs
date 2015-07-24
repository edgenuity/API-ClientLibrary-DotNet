using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.SifXpress
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
            loginId = null;
            stateProvinceId = null;
            otherIds = new XOtherPersonIdListType();
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

        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public XPersonNameType name { get; set; }
        public XOtherPersonNameListType otherNames { get; set; }
        public string localId { get; set; }
        public string loginId { get; set; }
        public string stateProvinceId { get; set; }
        public XOtherPersonIdListType otherIds { get; set; }
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
    }
}
