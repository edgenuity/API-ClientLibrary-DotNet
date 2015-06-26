using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XMeetingTimeType
    /// </summary>
    public class MeetingTime
    {
        public MeetingTime()
        {
            timeTableDay = null;
            classMeetingDays = new ClassMeetingDays();
            timeTablePeriod = null;
            roomNumber = null;
            classBeginningTime = null;
            classEndingTime = null;

        }
        public string timeTableDay { get; set; }
        public ClassMeetingDays classMeetingDays { get; set; }
        public string timeTablePeriod { get; set; }
        public string roomNumber { get; set; }
        public string classBeginningTime { get; set; }
        public string classEndingTime { get; set; }
    }
}
