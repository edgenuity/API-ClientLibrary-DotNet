using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneApi.Models.Authentication
{
    /// <summary>
    /// Endpoint type
    /// </summary>
   public class Endpoint
    {
        public string name { get; set; }
        public string href { get; set; }
        public string token { get; set; }
    }
}
