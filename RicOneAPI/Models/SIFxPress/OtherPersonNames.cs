using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XOtherPersonNameListType
    /// </summary>
    public class OtherPersonNames
    {
        public OtherPersonNames()
        {
            name = new List<Name>();
        }
        public List<Name> name { get; set; }
    }
}
