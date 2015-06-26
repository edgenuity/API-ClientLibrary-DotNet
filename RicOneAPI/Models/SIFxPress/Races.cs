using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XRaceListType
    /// </summary>
    public class Races
    {
        public Races()
        {
            race = new List<Race>();
        }
        public List<Race> race { get; set; }
    }
}
