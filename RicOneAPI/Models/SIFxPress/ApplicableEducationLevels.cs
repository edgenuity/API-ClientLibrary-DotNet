using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XApplicableEducationLevelListType
    /// </summary>
    public class ApplicableEducationLevels
    {
        public ApplicableEducationLevels()
        {
            applicableEducationLevel = new List<String>();
        }
        public List<String> applicableEducationLevel { get; set; }
    }
}
