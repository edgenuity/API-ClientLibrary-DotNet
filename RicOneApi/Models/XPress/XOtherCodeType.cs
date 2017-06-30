using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XOtherCodeType
    /// </summary>
    public class XOtherCodeType
    {
        public XOtherCodeType()
        {
            codesetName = null;
            otherCodeValue = null;
        }

        public string codesetName { get; set; }
        public string otherCodeValue { get; set; }
    }
}
