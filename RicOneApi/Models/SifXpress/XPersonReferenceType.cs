using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{   
    /// <summary>
    /// XPersonReferenceType
    /// </summary>
    public class XPersonReferenceType
    {
        public XPersonReferenceType()
        {
            refId = null;
            localId = null;
            givenName = null;
            familyName = null;
        }
        public string refId { get; set; }
        public string localId { get; set; }
        public string givenName { get; set; }
        public string familyName { get; set; }
    }
}
