/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStaffReferenceType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XStaffReferenceType
    /// </summary>
    public class XStaffReferenceType
    {
        public XStaffReferenceType()
        {
            staffPersonReference = new XPersonReferenceType();
            teacherOfRecord = null;
            percentResponsible = null;
        }
        public XPersonReferenceType staffPersonReference { get; set; }
        public bool? teacherOfRecord { get; set; }
        public decimal? percentResponsible { get; set; }
    }
}
