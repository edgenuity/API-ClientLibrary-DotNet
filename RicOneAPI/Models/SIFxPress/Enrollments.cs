using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XEnrollmentListType
    /// </summary>
    public class Enrollments
    {
        public Enrollments()
        {
            enrollment = new List<Enrollment>();
        }
        public List<Enrollment> enrollment { get; set; }
    }
}
