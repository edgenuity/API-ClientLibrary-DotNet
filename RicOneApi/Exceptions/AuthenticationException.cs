/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.5
 * Since       2017-01-13
 * Filename    AuthenticationException.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Exceptions
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException()
        { }

        public AuthenticationException(string message) : base(message)
        { }
        public AuthenticationException(string message, Exception inner) : base(message, inner)
        { }
    }
}
