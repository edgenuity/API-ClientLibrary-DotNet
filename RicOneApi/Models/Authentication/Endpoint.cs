using RicOneApi.Api;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7.0
 * Since       2019-04-18
 * Filename    Endpoint.cs
 */
namespace RicOneApi.Models.Authentication
{
    /// <summary>
    /// Endpoint type contatins enpoint name, href, and token
    /// </summary>
    public class Endpoint
    {
        public string name { get; set; }
        public string href { get; set; }
        public string provider_id { get; set; }
        public string token
        {
            get
            {
                return Authenticator.Instance.GetToken();
            }
            set
            {
                name = value;
            }
        }
    }
}
