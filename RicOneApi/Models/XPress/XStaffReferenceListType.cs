/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStaffReferenceListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XStaffReferenceListType
    /// </summary>
    public class XStaffReferenceListType
    {
        public XStaffReferenceListType()
        {
            otherStaff = new List<XStaffReferenceType>();
        }
        public List<XStaffReferenceType> otherStaff { get; set; }
    }
}
