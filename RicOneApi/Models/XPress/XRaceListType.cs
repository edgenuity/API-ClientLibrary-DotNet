/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XRaceListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
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
