/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStaffCollectionType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XStaffCollectionType
    /// </summary>
    public class XStaffCollectionType
    {
        public XStaffCollectionType()
        {
            xStaffs = null;
            xStaff = new List<XStaffType>();
        }
        public XStaffCollectionType xStaffs { get; set; }
        public List<XStaffType> xStaff { get; set; }
    }
}
