/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XEmailListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XEmailListType
    /// </summary>
    public class XEmailListType
    {
        public XEmailListType()
        {
            email = new List<XEmailType>();
        }
        public List<XEmailType> email { get; set; }
    }
}
