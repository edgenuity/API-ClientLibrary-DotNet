using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XOtherPersonIdType
    /// xOtherOrganizationIdType
    /// xOtherCourseIdType
    /// </summary>
    public class OtherId
    {
        public OtherId()
        {
            type = null;
            id = null;
        }
        public string type { get; set; }
        public string id { get; set; }
    }
}
