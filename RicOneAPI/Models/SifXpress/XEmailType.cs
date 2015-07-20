using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XEmailType
    /// </summary>
    public class XEmailType
    {
        public XEmailType()
        {
            emailType = null;
            emailAddress = null;
        }
        public string emailType { get; set; }
        public string emailAddress { get; set; }
    }
}
