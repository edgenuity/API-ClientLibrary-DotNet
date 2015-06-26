using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStaffCollectionType
    /// </summary>
    public class XStaffs
    {
        public XStaffs()
        {
            xStaff = new List<XStaff>();
        }
        public List<XStaff> xStaff { get; set; }
    }
}
