using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XLeaCollectionType
    /// </summary>
    public class XLeas
    {
        public XLeas()
        {
            xLea = new List<XLea>();
        }
        public List<XLea> xLea { get; set; }
    }
}