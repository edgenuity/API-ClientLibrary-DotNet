using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XYearGroupListType
    /// </summary>
    public class YearGroups
    {
        public YearGroups()
        {
            yearGroup = new List<String>();
        }
        public List<String> yearGroup { get; set; }
    }
}
