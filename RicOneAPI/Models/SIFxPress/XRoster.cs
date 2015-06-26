using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XRosterType
    /// </summary>
    public class XRoster
    {
        public XRoster()
        {
            refId = null;
            courseRefId = null;
            courseTitle = null;
            sectionRefId = null;
            subject = null;
            schoolRefId = null;
            schoolSectionId = null;
            schoolYear = null;
            sessionCode = null;
            schoolCalendarRefId = null;
            meetingTimes = new MeetingTimes();
            students = new Students();
            primaryStaff = new Staff();
            otherStaffs = new OtherStaffs();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string courseRefId { get; set; }
        public string courseTitle { get; set; }
        public string sectionRefId { get; set; }
        public string subject { get; set; }
        public string schoolRefId { get; set; }
        public string schoolSectionId { get; set; }
        public string schoolYear { get; set; }
        public string sessionCode { get; set; }
        public string schoolCalendarRefId { get; set; }
        public MeetingTimes meetingTimes { get; set; }
        public Students students { get; set; }
        public Staff primaryStaff { get; set; }  
        public OtherStaffs otherStaffs { get; set; }
    }
}
