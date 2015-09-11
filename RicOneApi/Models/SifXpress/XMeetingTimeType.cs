/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XMeetingTimeType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XMeetingTimeType
    /// </summary>
    public class XMeetingTimeType
    {
        public XMeetingTimeType()
        {
            timeTableDay = null;
            classMeetingDays = new XDayListType();
            timeTablePeriod = null;
            roomNumber = null;
            classBeginningTime = null;
            classEndingTime = null;

        }
        public string timeTableDay { get; set; }
        public XDayListType classMeetingDays { get; set; }
        public string timeTablePeriod { get; set; }
        public string roomNumber { get; set; }
        public string classBeginningTime { get; set; }
        public string classEndingTime { get; set; }
    }
}
