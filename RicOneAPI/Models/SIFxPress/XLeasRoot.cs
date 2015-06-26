using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// Root Object
    /// </summary>
    public class XLeasRoot
    {
        public XLeasRoot()
        {
            xLeas = null;
        }
        public XLeas xLeas { get; set; }
    }
}
