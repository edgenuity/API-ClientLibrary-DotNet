using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6.1
 * Since       2018-05-31
 */
namespace RicOneApi
{
    /// <summary>
    /// Generic class used to store response information on xPress list objects.
    /// </summary>
    /// <typeparam name="T">xPress Object.</typeparam>
    public class ResponseMulti<T>
    {
        /// <summary>
        /// xObject response data.
        /// </summary>
        public List<T> Data { get; set; }
        /// <summary>
        /// JSON string response.
        /// </summary>
        public string Json { get; set; }
        /// <summary>
        /// XML string response.
        /// </summary>
        public string Xml { get; set; }
        /// <summary>
        /// Response status code.
        /// </summary>
        public int StatusCode { get; set; }
        /// <summary>
        /// Response message.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Response header.
        /// </summary>
        public string Header { get; set; }
    }
}
