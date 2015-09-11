/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1.1
 * Since       2015-09-11
 * Filename    Endpoint.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneApi.Models.Authentication
{
    /// <summary>
    /// Endpoint type contatins enpoint name, href, and token
    /// </summary>
   public class Endpoint
    {
        public string name { get; set; }
        public string href { get; set; }
        public string provider_id { get; set; }
        public string token { get; set; }
    }
}
