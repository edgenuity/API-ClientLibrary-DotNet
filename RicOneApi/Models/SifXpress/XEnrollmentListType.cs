using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XEnrollmentListType
    /// </summary>
    public class XEnrollmentListType
    {
        public XEnrollmentListType()
        {
            enrollment = new List<XEnrollmentType>();
        }
        public List<XEnrollmentType> enrollment { get; set; }
    }
}
