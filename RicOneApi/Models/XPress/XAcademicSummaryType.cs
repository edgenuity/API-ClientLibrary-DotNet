/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XAcademicSummaryType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
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
