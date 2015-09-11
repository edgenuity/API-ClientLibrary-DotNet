/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XOtherPersonNameListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherPersonNameListType
    /// </summary>
    public class XOtherPersonNameListType
    {
        public XOtherPersonNameListType()
        {
            name = new List<XPersonNameType>();
        }
        public List<XPersonNameType> name { get; set; }
    }
}
