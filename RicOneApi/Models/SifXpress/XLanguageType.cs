/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XLanguageType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XLanguageType
    /// </summary>
    public class XLanguageType
    {
        public XLanguageType()
        {
            type = null;
            code = null;
        }
        public string type { get; set; }
        public string code { get; set; }
    }
}
