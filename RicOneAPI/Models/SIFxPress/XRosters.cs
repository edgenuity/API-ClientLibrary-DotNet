using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XRosterCollectionType
    /// </summary>
    public class XRosters
    {
        public XRosters()
        {
            xRoster = new List<XRoster>();
        }
        public List<XRoster> xRoster { get; set; }
    }
}
