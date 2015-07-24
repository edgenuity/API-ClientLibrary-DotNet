using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XContactCollectionType
    /// </summary>
    public class XContactCollectionType
    {
        public XContactCollectionType()
        {
            xContacts = null;
            xContact = new List<XContactType>();
        }
        public XContactCollectionType xContacts { get; set; }
        public List<XContactType> xContact { get; set; }
    }
}
