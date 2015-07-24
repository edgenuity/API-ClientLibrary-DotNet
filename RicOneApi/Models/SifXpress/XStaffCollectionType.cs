using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStaffCollectionType
    /// </summary>
    public class XStaffCollectionType
    {
        public XStaffCollectionType()
        {
            xStaffs = null;
            xStaff = new List<XStaffType>();
        }
        public XStaffCollectionType xStaffs { get; set; }
        public List<XStaffType> xStaff { get; set; }
    }
}
