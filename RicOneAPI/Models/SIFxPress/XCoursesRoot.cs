using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// Root Object
    /// </summary>
    public class XCoursesRoot
    {
        public XCoursesRoot()
        {
            xCourses = null;
        }
        public XCourses xCourses { get; set; }
    }
}
