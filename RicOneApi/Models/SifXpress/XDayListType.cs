/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XDayListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XDayListType
    /// </summary>
    public class XDayListType
    {
        public XDayListType()
        {
            bellScheduleDay = null;
        }
        public string bellScheduleDay { get; set; }
    }
}
