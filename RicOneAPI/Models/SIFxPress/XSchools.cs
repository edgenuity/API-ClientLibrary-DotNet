using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XSchoolCollectionType
    /// </summary>
    public class XSchools
    {
        public XSchools()
        {
            xSchool = new List<XSchool>();
        }
        public List<XSchool> xSchool { get; set; }
    }
}
