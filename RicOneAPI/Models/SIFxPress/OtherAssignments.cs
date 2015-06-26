using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStaffPersonAssignmentListType
    /// </summary>
    public class OtherAssignments
    {
        public OtherAssignments()
        {
            staffPersonAssignment = new List<PersonAssignment>();
        }
        public List<PersonAssignment> staffPersonAssignment { get; set; }
    }
}
