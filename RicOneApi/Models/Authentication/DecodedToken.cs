using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.Authentication
{
    public class DecodedToken
    {
        //private DateTime _exp;

        public string application_id { get; set; }
        public long iat { get; set; }
        public long exp { get; set; }
        public string iss { get; set; }

        //public long exp
        //{
        //    get { return exp; }
        //    set
        //    {
        //        var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        //        exp = epoch.AddSeconds(value).ToLocalTime().Second;
        //    }
        //}

        //[DeserializeAs(Name = "exp")]
        //public DateTime GetExp()
        //{
        //    return _exp;
        //}
        //[DeserializeAs(Name = "exp")]
        //public void SetExp(long exp)
        //{
        //    Console.WriteLine("SET");
        //    Console.WriteLine("WTF: " + exp);
        //    var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        //    _exp = epoch.AddSeconds(exp).ToLocalTime();
        //    //DateTime dt = epoch.AddSeconds(exp);
        //    //_exp = dt;
        //    //Console.WriteLine(epoch.AddSeconds(exp));
        //}


        //public DateTime iat
        //{
        //    get { return iat; }
        //    set {
        //        ////Console.WriteLine(value);
        //        //long d = value.Ticks;
        //        //DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        //        //TimeSpan v = new TimeSpan(1464270656000);

        //        //Console.WriteLine(dt + v);
        //        //Console.WriteLine(new DateTime(1464270656000));
        //        ////Console.WriteLine(Int64.Parse(d + "000"));
        //        //    iat = new DateTime(Int64.Parse(d + "000"));
        //        //1466188558
        //        //1297380023295
        //        //long l = 14642866440000000;

        //        long l = value.Ticks;
        //        DateTime javaDate = new DateTime(1970, 1, 1, 1, 0, 0); //Last 1 is an added hour to fix the offset.
        //        TimeSpan ts = new TimeSpan(l);
        //        DateTime exp = TimeZone.CurrentTimeZone.ToLocalTime(javaDate + ts);
        //        //Console.WriteLine(ts);
        //        //Console.WriteLine(exp);

        //        }
        //}
    }
}
