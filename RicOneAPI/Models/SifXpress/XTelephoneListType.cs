using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XTelephoneListType
    /// </summary>
    public class XTelephoneListType
    {
        public XTelephoneListType()
        {
            phoneNumber = new List<XTelephoneType>();
        }
        public List<XTelephoneType> phoneNumber { get; set; }
    }
}
