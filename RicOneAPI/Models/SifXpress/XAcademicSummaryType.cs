using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XAcademicSummaryType
    /// </summary>
    public class XAcademicSummaryType
    {
        public XAcademicSummaryType()
        {
            cumulativeWeightedGpa = null;
            termWeightedGpa = null;
            classRank = null;
        }
        public Decimal? cumulativeWeightedGpa { get; set; }
        public Decimal? termWeightedGpa { get; set; }
        public int? classRank { get; set; }
    }
}
