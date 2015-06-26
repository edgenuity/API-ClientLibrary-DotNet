using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XSessionType
    /// </summary>
    public class SessionList
    {
        public SessionList()
        {
            sessionType = null;
            sessionCode = null;
            description = null;
            markingTerm = null;
            schedulingTerm = null;
            linkedSessionCode = null;
            startDate = null;
            endDate = null;
        }
        public string sessionType { get; set; }
        public string sessionCode { get; set; }
        public string description { get; set; }
        public bool? markingTerm { get; set; }
        public bool? schedulingTerm { get; set; }
        public string linkedSessionCode { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }
}
