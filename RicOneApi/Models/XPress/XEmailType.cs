/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XEmailType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XEmailType
    /// </summary>
    public class XEmailType
    {
        public XEmailType()
        {
            emailType = null;
            emailAddress = null;
        }
        public string emailType { get; set; }
        public string emailAddress { get; set; }
    }
}
