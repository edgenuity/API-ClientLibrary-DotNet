using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XCourseCollectionType
    /// </summary>
    public class XCourseCollectionType
    {
        public XCourseCollectionType()
        {
            xCourses = null;
            xCourse = new List<XCourseType>();
        }
        public XCourseCollectionType xCourses { get; set; }
        public List<XCourseType> xCourse { get; set; }
    }
}
