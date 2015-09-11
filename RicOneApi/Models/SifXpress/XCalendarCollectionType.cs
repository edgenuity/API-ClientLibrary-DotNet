/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XCalendarCollectionType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XCalendarCollectionType
    /// </summary>
    public class XCalendarCollectionType
    {
        public XCalendarCollectionType()
        {
            xCalendars = null;
            xCalendar = new List<XCalendarType>();
        }
        public XCalendarCollectionType xCalendars { get; set; }
        public List<XCalendarType> xCalendar { get; set; }
    }
}
