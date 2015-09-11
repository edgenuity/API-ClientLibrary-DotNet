/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XLanguageListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XLanguageListType
    /// </summary>
    public class XLanguageListType
    {
        public XLanguageListType()
        {
            language = new List<XLanguageType>();
        }
        public List<XLanguageType> language { get; set; }
    }
}
