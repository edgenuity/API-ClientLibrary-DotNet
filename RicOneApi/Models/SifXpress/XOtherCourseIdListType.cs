using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherCourseIdListType
    /// </summary>
    public class XOtherCourseIdListType
    {
        public XOtherCourseIdListType()
        {
            otherId = new List<XOtherCourseIdType>();
        }
        public List<XOtherCourseIdType> otherId { get; set; }
    }
}
