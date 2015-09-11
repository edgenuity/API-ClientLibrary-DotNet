/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XCourseCollectionType.cs
 */
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
