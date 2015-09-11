/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.0
 * Since       2015-07-14
 * Filename    UserInfo.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneApi.Models.Authentication
{
    /// <summary>
    /// UserInfo type contains id, user_name, token, and list of endpoints
    /// </summary>
    public class UserInfo
    {
        public string id { get; set; }
        public string user_name { get; set; }
        public string token { get; set; }
        public List<Endpoint> endpoint { get; set; }
    }
}
