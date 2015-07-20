using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStaffPersonAssignmentType
    /// </summary>
    public class XStaffPersonAssignmentType
    {
        public XStaffPersonAssignmentType()
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
