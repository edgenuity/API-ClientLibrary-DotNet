using System.Collections.Generic;

namespace RicOneApi.Models.XPress
{
    public class XOtherPersonAddressListType
    {
        public List<XPersonAddressType> address { get; set; }

        public XOtherPersonAddressListType()
        {
            address = new List<XPersonAddressType>();
        }
    }
}
