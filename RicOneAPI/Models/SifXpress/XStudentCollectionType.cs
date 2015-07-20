using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStudentCollectionType
    /// </summary>
    public class XStudentCollectionType
    {
        public XStudentCollectionType()
        {
            xStudents = null;
            xStudent = new List<XStudentType>();
        }
        public XStudentCollectionType xStudents { get; set; }
        public List<XStudentType> xStudent { get; set; }
    }
}
