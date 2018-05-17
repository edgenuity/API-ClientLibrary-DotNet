using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XSchoolCollectionType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XSchoolCollectionType
    /// </summary>
    public class XSchoolCollectionType : ICollectionType<XSchoolType, XSchoolCollectionType>
    {
        public XSchoolCollectionType()
        {
            xSchools = null;
            xSchool = new List<XSchoolType>();
        }
        public XSchoolCollectionType xSchools { get; set; }
        public List<XSchoolType> xSchool { get; set; }

        public XSchoolCollectionType GetObjects
        {
            get { return xSchools; }
            set { xSchools = value; }
        }

        public List<XSchoolType> GetObject
        {
            get { return xSchool; }
            set { xSchool = value; }
        }
    }
}
