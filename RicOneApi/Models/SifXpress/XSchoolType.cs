/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XSchoolType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.SifXpress
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
            yearGroups = new XYearGroupListType();
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
        public XYearGroupListType yearGroups { get; set; }
        public XOrganizationAddressType address { get; set; }
        public XTelephoneType phoneNumber { get; set; }
        public XTelephoneListType otherPhoneNumbers { get; set; }
    }
}
