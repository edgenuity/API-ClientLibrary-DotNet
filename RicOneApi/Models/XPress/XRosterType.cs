/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.4.1
 * Since       2016-12-02
 * Filename    XRosterType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XRosterType
    /// </summary>
    public class XRosterType
    {
        public XRosterType()
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
            meetingTimes = new XMeetingTimeListType();
            students = new XStudentReferenceListType();
            primaryStaff = new XStaffReferenceType();
            otherStaffs = new XStaffReferenceListType();
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
        [Obsolete("Use sessionCode in XMeetingTimeType")]
        public string sessionCode { get; set; }
        [Obsolete("Use schoolCalendarRefId in XMeetingTimeType")]
        public string schoolCalendarRefId { get; set; }
        public XMeetingTimeListType meetingTimes { get; set; }
        public XStudentReferenceListType students { get; set; }
        public XStaffReferenceType primaryStaff { get; set; }  
        public XStaffReferenceListType otherStaffs { get; set; }
    }
}
