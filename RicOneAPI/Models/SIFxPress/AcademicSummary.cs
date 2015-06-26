using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XAcademicSummaryType
    /// </summary>
    public class AcademicSummary
    {
        public AcademicSummary()
        {
            cumulativeWeightedGpa = null;
            termWeightedGpa = null;
            classRank = null;
        }
        public string cumulativeWeightedGpa { get; set; }
        public string termWeightedGpa { get; set; }
        public string classRank { get; set; }
    }
}
