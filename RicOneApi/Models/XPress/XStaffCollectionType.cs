using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XStaffCollectionType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XStaffCollectionType
    /// </summary>
    public class XStaffCollectionType : ICollectionType<XStaffType, XStaffCollectionType>
    {
        public XStaffCollectionType()
        {
            xStaffs = null;
            xStaff = new List<XStaffType>();
        }
        public XStaffCollectionType xStaffs { get; set; }
        public List<XStaffType> xStaff { get; set; }

        public XStaffCollectionType GetObjects
        {
            get { return xStaffs; }
            set { xStaffs = value; }
        }

        public List<XStaffType> GetObject
        {
            get { return xStaff; }
            set { xStaff = value; }
        }
    }
}
