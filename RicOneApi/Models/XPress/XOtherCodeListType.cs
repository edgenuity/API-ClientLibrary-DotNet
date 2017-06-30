using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XOtherCodeListType
    /// </summary>
    public class XOtherCodeListType
    {
        public XOtherCodeListType()
        {
            code = null;
            otherCode = new List<XOtherCodeType>();
        }

        public string code { get; set; }
        public List<XOtherCodeType> otherCode { get; set; } 
    }
}
