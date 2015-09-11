/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XRaceType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XRaceType
    /// </summary>
    public class XRaceType
    {
        public XRaceType()
        {
            race = null;
        }
        public string race { get; set; }
    }
}
