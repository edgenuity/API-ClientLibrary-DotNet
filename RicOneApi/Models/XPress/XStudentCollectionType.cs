using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XStudentCollectionType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XStudentCollectionType
    /// </summary>
    public class XStudentCollectionType : ICollectionType<XStudentType, XStudentCollectionType>
    {
        public XStudentCollectionType()
        {
            xStudents = null;
            xStudent = new List<XStudentType>();
        }
        public XStudentCollectionType xStudents { get; set; }
        public List<XStudentType> xStudent { get; set; }

        public XStudentCollectionType GetObjects
        {
            get { return xStudents; }
            set { xStudents = value; }
        }

        public List<XStudentType> GetObject
        {
            get { return xStudent; }
            set{ xStudent = value; }
        }
    }
}
