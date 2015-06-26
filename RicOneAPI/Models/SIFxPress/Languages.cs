using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XLanguageListType
    /// </summary>
    public class Languages
    {
        public Languages()
        {
            language = new List<Language>();
        }
        public List<Language> language { get; set; }
    }
}
