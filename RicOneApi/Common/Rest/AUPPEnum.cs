using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Common.Rest
{
    class AUPPEnum
    {
        public static readonly AUPPEnum CREATE = new AUPPEnum("create");
        public static readonly AUPPEnum DELETE = new AUPPEnum("delete");
        public static readonly AUPPEnum GET = new AUPPEnum("get");

        private AUPPEnum(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }
    }
}
