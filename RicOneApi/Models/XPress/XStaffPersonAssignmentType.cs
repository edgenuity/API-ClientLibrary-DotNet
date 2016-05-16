/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStaffPersonAssignmentType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
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
