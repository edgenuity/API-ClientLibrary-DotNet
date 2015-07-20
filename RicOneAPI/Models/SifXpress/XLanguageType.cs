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
