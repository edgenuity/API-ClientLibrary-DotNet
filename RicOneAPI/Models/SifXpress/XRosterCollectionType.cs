using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XRosterCollectionType
    /// </summary>
    public class XRosterCollectionType
    {
        public XRosterCollectionType()
        {
            xRosters = null;
            xRoster = new List<XRosterType>();
        }
        public XRosterCollectionType xRosters { get; set; }
        public List<XRosterType> xRoster { get; set; }
    }
}
