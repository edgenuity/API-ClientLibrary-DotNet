using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStaffReferenceListType
    /// </summary>
    public class XStaffReferenceListType
    {
        public XStaffReferenceListType()
        {
            otherStaff = new List<XStaffReferenceType>();
        }
        public List<XStaffReferenceType> otherStaff { get; set; }
    }
}
