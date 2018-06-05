using Newtonsoft.Json;
using RestSharp;
using System;
using System.Linq;
using System.Xml;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6.1
 * Since       2018-05-31
 */
namespace RicOneApi.Api
{
    /// <summary>
    /// Utility class for various internal helper methods.
    /// </summary>
    internal class Util
    {
        /// <summary>
        /// Method to iterate through the response header list and concatenates a string to return header fields and values.
        /// </summary>
        /// <param name="response">REST response.</param>
        /// <returns>A String value.</returns>
        internal static string BuildHeader(IRestResponse response)
        {
            string headerOut = null;

            foreach (var header in response.Headers.ToList())
            {
                headerOut = headerOut + header.Name + "=[" + header.Value + "] ";
            }

            return headerOut;
        }
        
        /// <summary>
        /// Convert long UNIX/DateTime to DateTime.
        /// </summary>
        /// <param name="unixDate">Long date/time</param>
        /// <returns>A DateTime value.</returns>
        internal static DateTime ConvertUnixTime(long unixDate)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime date = dt.AddSeconds(unixDate).ToLocalTime();

            return date;
        }

        /// <summary>
        /// Converts a JSON string to an XML string.
        /// </summary>
        /// <param name="json">JSON string response.</param>
        /// <returns>A string XML value.</returns>
        internal static string ConvertJson2Xml(string json)
        {
            XmlDocument doc = JsonConvert.DeserializeXmlNode(json);
            return doc.InnerXml;
        }
    }
}
