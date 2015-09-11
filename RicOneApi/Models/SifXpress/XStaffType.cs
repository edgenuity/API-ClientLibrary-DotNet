/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStaffType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStaffType
    /// </summary>
    public class XStaffType
    {
        public XStaffType()
        {
            refId = null;
            name = new XPersonNameType();
            localId = null;
            loginId = null;
            stateProvinceId = null;
            otherIds = new XOtherPersonIdListType();
            sex = null;
            email = new XEmailType();
            primaryAssignment = new XStaffPersonAssignmentType();
            otherAssignments = new XStaffPersonAssignmentListType();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public XPersonNameType name { get; set; }
        public string localId { get; set; }
        public string loginId { get; set; }
        public string stateProvinceId { get; set; }
        public XOtherPersonIdListType otherIds { get; set; }
        public string sex { get; set; }
        public XEmailType email { get; set; }
        public XStaffPersonAssignmentType primaryAssignment { get; set; }
        public XStaffPersonAssignmentListType otherAssignments { get; set; }
    }
}
