using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStaffType
    /// </summary>
    public class XStaff
    {
        public XStaff()
        {
            refId = null;
            name = new Name();
            localId = null;
            loginId = null;
            stateProvinceId = null;
            otherIds = new OtherIds();
            sex = null;
            email = new Email();
            primaryAssignment = new PersonAssignment();
            otherAssignments = new OtherAssignments();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public Name name { get; set; }
        public string localId { get; set; }
        public string loginId { get; set; }
        public string stateProvinceId { get; set; }
        public OtherIds otherIds { get; set; }
        public string sex { get; set; }
        public Email email { get; set; }
        public PersonAssignment primaryAssignment { get; set; }
        public OtherAssignments otherAssignments { get; set; }
    }
}
