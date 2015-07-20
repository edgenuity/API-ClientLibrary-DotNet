using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XMeetingTimeListType
    /// </summary>
    public class XMeetingTimeListType
    {
        public XMeetingTimeListType()
        {
            meetingTime = new List<XMeetingTimeType>();
        }
        public List<XMeetingTimeType> meetingTime { get; set; }
    }
}
