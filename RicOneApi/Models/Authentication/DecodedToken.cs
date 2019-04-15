using Newtonsoft.Json;
using System;
using JWT;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7.0
 * Since       2019-03-29
 * Filename    DecodedToken.cs
 */
namespace RicOneApi.Models.Authentication
{
    /// <summary>
    /// Decodes provided token and creates DecodedToken object.
    /// </summary>
    public class DecodedToken
    {
        private readonly string _token;

        /// <summary>
        /// Token to decode.
        /// </summary>
        /// <param name="token"></param>
        public DecodedToken(string token)
        {
            _token = token;
        }

        /// <summary>
        /// Returns applicaiton_id, iss, iat, and exp from decoded JWT token.
        /// </summary>
        /// <returns>Decoded token type.</returns>
        public DecodedToken GetDecodedToken()
        {
            try
            {
                string[] base64EncodedSegments = _token.Split('.');
                DecodedToken dt = JsonConvert.DeserializeObject<DecodedToken>(Base64UrlDecode(base64EncodedSegments[1]));

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal string Base64UrlDecode(String input)
        {
            var urlEncoder = new JwtBase64UrlEncoder();
            byte[] newBytes = urlEncoder.Decode(input);
            return System.Text.Encoding.UTF8.GetString(newBytes);
        }

        /// <summary>
        /// Returns the application id of a decoded token.
        /// </summary>
        public string application_id { get; set; }

        /// <summary>
        /// Returns the time the JWT token was issued at.
        /// </summary>
        public long iat { get; set; }

        /// <summary>
        /// Returns the time the JWT token expired at.
        /// </summary>
        public long exp { get; set; }
        /// <summary>
        /// Returns the issuer of the JWT token.
        /// </summary>
        public string iss { get; set; }
    }
}
