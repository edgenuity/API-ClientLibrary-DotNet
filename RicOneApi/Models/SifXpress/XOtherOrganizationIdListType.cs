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
