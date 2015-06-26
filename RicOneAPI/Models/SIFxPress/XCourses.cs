using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XCourseCollectionType
    /// </summary>
    public class XCourses
    {
        public XCourses()
        {
            xCourse = new List<XCourse>();
        }
        public List<XCourse> xCourse { get; set; }
    }
}
