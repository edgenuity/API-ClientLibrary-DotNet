using RestSharp.Deserializers;
using System;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XStaffType.cs
 */
namespace RicOneApi.Models.XPress
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
            stateProvinceId = null;
            otherIds = new XOtherPersonIdListType();
            appProvisioningInfo = new XAppProvisioningInfoType();
            sex = null;
            email = new XEmailType();
            primaryAssignment = new XStaffPersonAssignmentType();
            otherAssignments = new XStaffPersonAssignmentListType();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public XPersonNameType name { get; set; }
        public string localId { get; set; }
        public string stateProvinceId { get; set; }
        public XOtherPersonIdListType otherIds { get; set; }
        public XAppProvisioningInfoType appProvisioningInfo { get; set; }
        public string sex { get; set; }
        public XEmailType email { get; set; }
        public XStaffPersonAssignmentType primaryAssignment { get; set; }
        public XStaffPersonAssignmentListType otherAssignments { get; set; }

        public XStaffCollectionType GetObjects { get; set; }
        public XStaffType GetObject
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }

    }
}
