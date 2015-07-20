using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherCourseIdType
    /// </summary>
    public class XOtherCourseIdType
    {
        public XOtherCourseIdType()
        {
            type = null;
            id = null;
        }
        public string type { get; set; }
        public string id { get; set; }
    }
}
