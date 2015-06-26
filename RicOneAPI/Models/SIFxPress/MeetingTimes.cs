using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XMeetingTimeListType
    /// </summary>
    public class MeetingTimes
    {
        public MeetingTimes()
        {
            meetingTime = new List<MeetingTime>();
        }
        public List<MeetingTime> meetingTime { get; set; }
    }
}
