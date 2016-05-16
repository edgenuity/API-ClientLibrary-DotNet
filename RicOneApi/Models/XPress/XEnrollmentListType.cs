/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XEnrollmentListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XEnrollmentListType
    /// </summary>
    public class XEnrollmentListType
    {
        public XEnrollmentListType()
        {
            enrollment = new List<XEnrollmentType>();
        }
        public List<XEnrollmentType> enrollment { get; set; }
    }
}
