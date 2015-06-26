using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicOneAPI.Models.Authentication
{
    public class UserInfo
    {
        public string id { get; set; }
        public string user_name { get; set; }
        public string token { get; set; }
        public List<Endpoint> endpoint { get; set; }
    }
}
