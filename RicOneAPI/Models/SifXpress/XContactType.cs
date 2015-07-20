using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XContactType
    /// </summary>
    public class XContactType
    {
        public XContactType()
        {
            refId = null;
            name = new XPersonNameType();
            otherNames = new XOtherPersonNameListType();
            localId = null;
            loginId = null;
            otherIds = new XOtherPersonIdListType();
            address = new XPersonAddressType();
            phoneNumber = new XTelephoneType();
            otherPhoneNumbers = new XTelephoneListType();
            email = new XEmailType();
            otherEmails = new XEmailListType();
            sex = null;
            employerType = null;
            relationships = new XContactStudentRelationshipListType();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public XPersonNameType name { get; set; }
        public XOtherPersonNameListType otherNames { get; set; }
        public string localId { get; set; }
        public string loginId { get; set; }
        public XOtherPersonIdListType otherIds { get; set; }
        public XPersonAddressType address { get; set; }
        public XTelephoneType phoneNumber { get; set; }
        public XTelephoneListType otherPhoneNumbers { get; set; }
        public XEmailType email { get; set; }
        public XEmailListType otherEmails { get; set; }
        public string sex { get; set; }
        public string employerType { get; set; }
        public XContactStudentRelationshipListType relationships { get; set; }
    }
}
