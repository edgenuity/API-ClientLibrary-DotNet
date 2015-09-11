/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XYearGroupListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XYearGroupListType
    /// </summary>
    public class XYearGroupListType
    {
        public XYearGroupListType()
        {
            yearGroup = new List<String>();
        }
        public List<String> yearGroup { get; set; }
    }
}
