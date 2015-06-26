using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XOtherPersonIdListType
    /// </summary>
    public class OtherIds
    {
        public OtherIds()
        {
            otherId = new List<OtherId>();
        }
        public List<OtherId> otherId { get; set; }
    }
}
