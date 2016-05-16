/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XTelephoneType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XTelephoneType
    /// </summary>
    public class XTelephoneType
    {
        public XTelephoneType()
        {
            phoneNumberType = null;
            number = null;
            primaryIndicator = null;
        }
        public string phoneNumberType { get; set; }
        public string number { get; set; }
        public string primaryIndicator { get; set; }
    }
}
