using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// Root Object
    /// </summary>
    public class XRostersRoot
    {
        public XRostersRoot()
        {
            xRosters = null;
        }
        public XRosters xRosters { get; set; }
    }
}
