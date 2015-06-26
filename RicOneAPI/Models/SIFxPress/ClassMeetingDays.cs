using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XDayListType
    /// </summary>
    public class ClassMeetingDays
    {
        public ClassMeetingDays()
        {
            bellScheduleDay = null;
        }
        public string bellScheduleDay { get; set; }
    }
}
