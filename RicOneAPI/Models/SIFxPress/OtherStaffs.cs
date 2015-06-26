using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStaffReferenceListType
    /// </summary>
    public class OtherStaffs
    {
        public OtherStaffs()
        {
            otherStaff = new List<Staff>();
        }
        public List<Staff> otherStaff { get; set; }
    }
}
