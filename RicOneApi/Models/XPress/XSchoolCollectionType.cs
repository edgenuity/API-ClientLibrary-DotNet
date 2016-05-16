/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XSchoolCollectionType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XSchoolCollectionType
    /// </summary>
    public class XSchoolCollectionType
    {
        public XSchoolCollectionType()
        {
            xSchools = null;
            xSchool = new List<XSchoolType>();
        }
        public XSchoolCollectionType xSchools { get; set; }
        public List<XSchoolType> xSchool { get; set; }
    }
}
