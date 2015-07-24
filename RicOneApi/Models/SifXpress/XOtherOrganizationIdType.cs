using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherOrganizationIdType
    /// </summary>
    public class XOtherOrganizationIdType
    {
        public XOtherOrganizationIdType()
        {
            type = null;
            id = null;
        }
        public string type { get; set; }
        public string id { get; set; }
    }
}
