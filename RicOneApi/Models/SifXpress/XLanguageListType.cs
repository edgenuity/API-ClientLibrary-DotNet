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
