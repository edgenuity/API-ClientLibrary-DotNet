using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
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
