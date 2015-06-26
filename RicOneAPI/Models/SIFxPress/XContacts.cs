using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XContactCollectionType
    /// </summary>
    public class XContacts
    {
        public XContacts()
        {
            xContact = new List<XContact>();
        }
        public List<XContact> xContact { get; set; }
    }
}
