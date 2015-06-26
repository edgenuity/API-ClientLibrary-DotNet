using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// Root Object
    /// </summary>
    public class XContactsRoot
    {
        public XContactsRoot()
        {
            xContacts = null;
        }
        public XContacts xContacts { get; set; }
    }
}
