using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XPersonNameType
    /// </summary>
    public class XPersonNameType
    {
        public XPersonNameType()
        {
            type = null;
            prefix = null;
            familyName = null;
            givenName = null;
            middleName = null;
            suffix = null;
        }
        public string type { get; set; }
        public string prefix { get; set; }
        public string familyName { get; set; }
        public string givenName { get; set; }
        public string middleName { get; set; }
        public string suffix { get; set; }
    }
}
