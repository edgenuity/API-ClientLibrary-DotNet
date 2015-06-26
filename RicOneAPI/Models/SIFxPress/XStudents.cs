using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStudentCollectionType
    /// </summary>
    public class XStudents
    {
        public XStudents()
        {
            xStudent = new List<XStudent>();
        }
        public List<XStudent> xStudent { get; set; }
    }
}
