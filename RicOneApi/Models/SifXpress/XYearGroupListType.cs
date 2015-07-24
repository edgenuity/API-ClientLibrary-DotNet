using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XYearGroupListType
    /// </summary>
    public class XYearGroupListType
    {
        public XYearGroupListType()
        {
            yearGroup = new List<String>();
        }
        public List<String> yearGroup { get; set; }
    }
}
