using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.Authentication
{
    public class DecodedToken
    {
        public string application_id { get; set; }
        public long iat { get; set; }
        public long exp { get; set; }
        public string iss { get; set; }
    }
}
