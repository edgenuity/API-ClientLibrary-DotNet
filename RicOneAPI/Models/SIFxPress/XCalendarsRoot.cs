using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// Root Object
    /// </summary>
    public class XCalendarsRoot
    {
        public XCalendarsRoot()
        {
            xCalendars = null;
        }
        public XCalendars xCalendars { get; set; }
    }
}
