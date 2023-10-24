using System;

namespace RicOneApi.Models.XPress
{
    public class XManagerType
    {
        public string refId {get; set;}
        public string givenName {get; set;}
        public string familyName {get; set;}

        public XManagerType()
        {
            refId = null;
            givenName = null;
            familyName = null;
        }

        public XManagerType GetObject
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }
    }
}
