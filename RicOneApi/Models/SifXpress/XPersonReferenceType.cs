/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XPersonReferenceType.cs
 */
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
