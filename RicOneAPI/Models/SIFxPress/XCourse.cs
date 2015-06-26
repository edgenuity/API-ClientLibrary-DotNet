using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XCourseType
    /// </summary>
    public class XCourse
    {
        public XCourse()
        {
            refId = null;
            schoolRefId = null;
            schoolCourseId = null;
            leaCourseId = null;
            otherIds = new OtherIds();
            courseTitle = null;
            description = null;
            subject = null;
            applicableEducationLevels = new ApplicableEducationLevels();
            scedCourseCode = null;
            scedCourseLevelCode = null;
            scedCourseSubjectAreaCode = null;
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string schoolRefId { get; set; }
        public string schoolCourseId { get; set; }
        public string leaCourseId { get; set; }
        public OtherIds otherIds { get; set; }
        public string courseTitle { get; set; }
        public string description { get; set; }
        public string subject { get; set; }
        public ApplicableEducationLevels applicableEducationLevels { get; set; }
        public string scedCourseCode { get; set; }
        public string scedCourseLevelCode { get; set; }
        public string scedCourseSubjectAreaCode { get; set; }
    }
}
