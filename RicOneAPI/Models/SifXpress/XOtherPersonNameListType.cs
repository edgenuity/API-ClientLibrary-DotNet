using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherPersonNameListType
    /// </summary>
    public class XOtherPersonNameListType
    {
        public XOtherPersonNameListType()
        {
            name = new List<XPersonNameType>();
        }
        public List<XPersonNameType> name { get; set; }
    }
}
