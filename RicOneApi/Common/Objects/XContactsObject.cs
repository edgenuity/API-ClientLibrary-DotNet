using RestSharp;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-15
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// xContacts Service Paths.
    /// </summary>
    class XContactsObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XContacts Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XContactsObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }
    }
}
