using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XLeaCollectionType
    /// </summary>
    public class XLeaCollectionType
    {
        public XLeaCollectionType()
        {
            xLeas = null;
            xLea = new List<XLeaType>();
        }
        public XLeaCollectionType xLeas { get; set; }
        public List<XLeaType> xLea { get; set; }
   
    }
}