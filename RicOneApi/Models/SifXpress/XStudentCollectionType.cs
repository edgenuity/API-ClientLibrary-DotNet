/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStudentCollectionType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStudentCollectionType
    /// </summary>
    public class XStudentCollectionType
    {
        public XStudentCollectionType()
        {
            xStudents = null;
            xStudent = new List<XStudentType>();
        }
        public XStudentCollectionType xStudents { get; set; }
        public List<XStudentType> xStudent { get; set; }
    }
}
