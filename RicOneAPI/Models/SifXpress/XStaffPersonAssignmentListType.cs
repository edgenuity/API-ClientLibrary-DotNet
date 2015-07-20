using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStaffPersonAssignmentListType
    /// </summary>
    public class XStaffPersonAssignmentListType
    {
        public XStaffPersonAssignmentListType()
        {
            staffPersonAssignment = new List<XStaffPersonAssignmentType>();
        }
        public List<XStaffPersonAssignmentType> staffPersonAssignment { get; set; }
    }
}
