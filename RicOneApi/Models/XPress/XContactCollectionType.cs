/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XContactCollectionType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XContactCollectionType
    /// </summary>
    public class XContactCollectionType
    {
        public XContactCollectionType()
        {
            xContacts = null;
            xContact = new List<XContactType>();
        }
        public XContactCollectionType xContacts { get; set; }
        public List<XContactType> xContact { get; set; }
    }
}
