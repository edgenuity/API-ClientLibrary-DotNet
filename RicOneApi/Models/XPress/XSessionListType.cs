/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XSessionListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XSessionListType
    /// </summary>
    public class XSessionListType
    {
        public XSessionListType()
        {
            sessionList = new List<XSessionType>();
        }
        public List<XSessionType> sessionList { get; set; }
    }
}
