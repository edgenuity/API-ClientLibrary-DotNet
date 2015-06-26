using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStudentType
    /// </summary>
    public class XStudent
    {
        public XStudent()
        {
            refId = null;
            name = new Name();
            otherNames = new OtherPersonNames();
            localId = null;
            loginId = null;
            stateProvinceId = null;
            otherIds = new OtherIds();
            address = new Address();
            phoneNumber = new PhoneNumber();
            otherPhoneNumbers = new OtherPhoneNumbers();
            email = new Email();
            otherEmails = new OtherEmails();
            demographics = new Demographics();
            enrollment = new Enrollment();
            otherEnrollments = new Enrollments();
            academicSummary = new AcademicSummary();
            studentContacts = new StudentContacts();
            languages = new Languages();

        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public Name name { get; set; }
        public OtherPersonNames otherNames { get; set; }
        public string localId { get; set; }
        public string loginId { get; set; }
        public string stateProvinceId { get; set; }
        public OtherIds otherIds { get; set; }
        public Address address { get; set; }
        public PhoneNumber phoneNumber { get; set; }
        public OtherPhoneNumbers otherPhoneNumbers { get; set; }
        public Email email { get; set; }
        public OtherEmails otherEmails { get; set; }
        public Demographics demographics { get; set; }
        public Enrollment enrollment { get; set; }
        public Enrollments otherEnrollments { get; set; }
        public AcademicSummary academicSummary { get; set; }
        public StudentContacts studentContacts { get; set; }
        public Languages languages { get; set; }
    }
}
