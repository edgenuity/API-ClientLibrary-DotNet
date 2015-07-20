using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XEmailListType
    /// </summary>
    public class XEmailListType
    {
        public XEmailListType()
        {
            email = new List<XEmailType>();
        }
        public List<XEmailType> email { get; set; }
    }
}
