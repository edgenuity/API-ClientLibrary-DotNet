/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XCourseType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XCourseType
    /// </summary>
    public class XCourseType
    {
        public XCourseType()
        {
            refId = null;
            schoolRefId = null;
            schoolCourseId = null;
            leaCourseId = null;
            otherIds = new XOtherCourseIdListType();
            courseTitle = null;
            description = null;
            subject = null;
            applicableEducationLevels = new XApplicableEducationLevelListType();
            scedCourseCode = null;
            scedCourseLevelCode = null;
            scedCourseSubjectAreaCode = null;
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string schoolRefId { get; set; }
        public string schoolCourseId { get; set; }
        public string leaCourseId { get; set; }
        public XOtherCourseIdListType otherIds { get; set; }
        public string courseTitle { get; set; }
        public string description { get; set; }
        public string subject { get; set; }
        public XApplicableEducationLevelListType applicableEducationLevels { get; set; }
        public string scedCourseCode { get; set; }
        public string scedCourseLevelCode { get; set; }
        public string scedCourseSubjectAreaCode { get; set; }
    }
}
