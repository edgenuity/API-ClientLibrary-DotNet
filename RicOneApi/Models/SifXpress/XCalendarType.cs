using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XCalendarType
    /// </summary>
    public class XCalendarType
    {
        public XCalendarType()
        {
            refId = null;
            schoolRefId = null;
            schoolYear = null;
            sessions = new XSessionListType();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string schoolRefId { get; set; }
        public string schoolYear { get; set; }
        public XSessionListType sessions { get; set; }
    }
}
