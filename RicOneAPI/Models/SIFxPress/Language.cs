using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XLanguageType
    /// </summary>
    public class Language
    {
        public Language()
        {
            type = null;
            code = null;
        }
        public string type { get; set; }
        public string code { get; set; }
    }
}
