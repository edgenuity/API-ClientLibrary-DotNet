/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.2
 * Since       2016-05-10
 * Filename    ResponseSingle.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace RicOneApi
{
    public class ResponseSingle<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Header { get; set; }
    }
}
