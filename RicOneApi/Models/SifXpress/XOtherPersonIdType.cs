using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherPersonIdType
    /// </summary>
    public class XOtherPersonIdType
    {
        public XOtherPersonIdType()
        {
            type = null;
            id = null;
        }
        public string type { get; set; }
        public string id { get; set; }
    }
}
