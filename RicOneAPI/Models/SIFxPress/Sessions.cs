using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XSessionListType
    /// </summary>
    public class Sessions
    {
        public Sessions()
        {
            sessionList = new List<SessionList>();
        }
        public List<SessionList> sessionList { get; set; }
    }
}
