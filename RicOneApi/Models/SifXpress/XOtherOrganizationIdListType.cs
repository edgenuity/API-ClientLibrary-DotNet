/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XOtherOrganizationIdListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherOrganizationIdListType
    /// </summary>
    public class XOtherOrganizationIdListType
    {
        public XOtherOrganizationIdListType()
        {
            otherId = new List<XOtherOrganizationIdType>();
        }
        public List<XOtherOrganizationIdType> otherId { get; set; }
    }
}
