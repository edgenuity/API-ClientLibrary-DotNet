using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// Root Object
    /// </summary>
    public class XSchoolsRoot
    {
        public XSchoolsRoot()
        {
            xSchools = null;
        }
        public XSchools xSchools { get; set; }
    }
}
