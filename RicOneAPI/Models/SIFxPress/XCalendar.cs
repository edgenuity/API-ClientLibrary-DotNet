using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XCalendarType
    /// </summary>
    public class XCalendar
    {
        public XCalendar()
        {
            refId = null;
            schoolRefId = null;
            schoolYear = null;
            sessions = new Sessions();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string schoolRefId { get; set; }
        public string schoolYear { get; set; }
        public Sessions sessions { get; set; }
    }
}
