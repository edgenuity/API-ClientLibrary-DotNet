/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStaffPersonAssignmentListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
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
