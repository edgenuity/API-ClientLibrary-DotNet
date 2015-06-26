using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XContactType
    /// </summary>
    public class Contact
    {
        public Contact()
        {
            name = new Name();
            otherNames = new OtherPersonNames();
            localId = null;
            loginId = null;
            otherIds = new OtherIds();
            address = new Address();
            phoneNumber = new PhoneNumber();
            otherPhoneNumbers = new OtherPhoneNumbers();
            email = new Email();
            otherEmails = new OtherEmails();
            sex = null;
            employerType = null;
            relationships = new ContactStudentRelationships();
        }
        public Name name { get; set; }
        public OtherPersonNames otherNames { get; set; }
        public string localId { get; set; }
        public string loginId { get; set; }
        public OtherIds otherIds { get; set; }
        public Address address { get; set; }
        public PhoneNumber phoneNumber { get; set; }
        public OtherPhoneNumbers otherPhoneNumbers { get; set; }
        public Email email { get; set; }
        public OtherEmails otherEmails { get; set; }
        public string sex { get; set; }
        public string employerType { get; set; }
        public ContactStudentRelationships relationships { get; set; }


    }
}
