using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XRaceListType
    /// </summary>
    public class XRaceListType
    {
        public XRaceListType()
        {
            race = new List<XRaceType>();
        }
        public List<XRaceType> race { get; set; }
    }
}
