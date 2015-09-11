/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XStudentContactListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStudentContactListType
    /// </summary>
    public class XStudentContactListType
    {
        public XStudentContactListType()
        {
            contactPersonRefId = new List<String>();
            xContact = new List<XContactType>();
        }
        public List<String> contactPersonRefId { get; set; }
        public List<XContactType> xContact { get; set; }
    }
}
