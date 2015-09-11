/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XOtherPersonIdListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherPersonIdListType
    /// </summary>
    public class XOtherPersonIdListType
    {
        public XOtherPersonIdListType()
        {
            otherId = new List<XOtherPersonIdType>();
        }
        public List<XOtherPersonIdType> otherId { get; set; }
    }
}
