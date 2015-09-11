/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XSessionType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XSessionType
    /// </summary>
    public class XSessionType
    {
        public XSessionType()
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
