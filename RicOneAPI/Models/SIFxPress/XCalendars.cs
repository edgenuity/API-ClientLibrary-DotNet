using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XCalendarCollectionType
    /// </summary>
    public class XCalendars
    {
        public XCalendars()
        {
            xCalendar = new List<XCalendar>();
        }
        public List<XCalendar> xCalendar { get; set; }
    }
}
