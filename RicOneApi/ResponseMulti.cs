/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.2
 * Since       2016-05-10
 * Filename    ResponseMulti.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi
{
    public class ResponseMulti<T>
    {
        public List<T> Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Header { get; set; }
    }
}
