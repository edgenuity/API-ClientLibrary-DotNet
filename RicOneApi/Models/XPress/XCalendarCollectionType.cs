using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6
 * Since       2018-05-14
 * Filename    XCalendarCollectionType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XCalendarCollectionType
    /// </summary>
    public class XCalendarCollectionType : ICollectionType<XCalendarType, XCalendarCollectionType>
    {
        public XCalendarCollectionType()
        {
            xCalendars = null;
            xCalendar = new List<XCalendarType>();
        }
        public XCalendarCollectionType xCalendars { get; set; }
        public List<XCalendarType> xCalendar { get; set; }

        public XCalendarCollectionType GetObjects
        {
            get { return xCalendars; }
            set { xCalendars = value; }
        }

        public List<XCalendarType> GetObject
        {
            get { return xCalendar; }
            set { xCalendar = value; }
        }

    }
}
