/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStudentReferenceListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XStudentReferenceListType
    /// </summary>
    public class XStudentReferenceListType
    {
        public XStudentReferenceListType()
        {
            studentReference = new List<XPersonReferenceType>();
        }
        public List<XPersonReferenceType> studentReference { get; set; }
    }
}
