using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStaffPersonAssignmentType
    /// </summary>
    public class PersonAssignment
    {
        public PersonAssignment()
        {
            leaRefId = null;
            schoolRefId = null;
            jobFunction = null;
        }
        public string leaRefId { get; set; }
        public string schoolRefId { get; set; }
        public string jobFunction { get; set; }
    }
}
