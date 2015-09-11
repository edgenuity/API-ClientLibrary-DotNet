/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XTelephoneListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XTelephoneListType
    /// </summary>
    public class XTelephoneListType
    {
        public XTelephoneListType()
        {
            phoneNumber = new List<XTelephoneType>();
        }
        public List<XTelephoneType> phoneNumber { get; set; }
    }
}
