/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.4
 * Since       2016-09-12
 * Filename    DecodedToken.cs
 */

using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.Authentication
{
    public class DecodedToken
    {
        private string _token;

        public DecodedToken()
        { }

        public DecodedToken(string token)
        {
            _token = token;
        }
        /// <summary>
        /// Payload data inside an encrypted JWT token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public DecodedToken GetDecodedToken()
        {
            try
            {
                String[] base64EncodedSegments = _token.Split('.');
                DecodedToken dt = JsonConvert.DeserializeObject<DecodedToken>(base64UrlDecode(base64EncodedSegments[1]));

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        internal String base64UrlDecode(String input)
        {
            byte[] newBytes = JWT.JsonWebToken.Base64UrlDecode(input);
            return System.Text.Encoding.UTF8.GetString(newBytes);
        }

        public string application_id { get; set; }
        public long iat { get; set; }
        public long exp { get; set; }
        public string iss { get; set; }
    }
}
