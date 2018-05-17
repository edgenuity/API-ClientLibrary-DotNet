using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XCourseCollectionType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XCourseCollectionType
    /// </summary>
    public class XCourseCollectionType : ICollectionType<XCourseType, XCourseCollectionType>
    {
        public XCourseCollectionType()
        {
            xCourses = null;
            xCourse = new List<XCourseType>();
        }
        public XCourseCollectionType xCourses { get; set; }
        public List<XCourseType> xCourse { get; set; }

        public XCourseCollectionType GetObjects
        {
            get { return xCourses; }
            set { xCourses = value; }
        }

        public List<XCourseType> GetObject
        {
            get { return xCourse; }
            set { xCourse = value; }
        }
    }
}
