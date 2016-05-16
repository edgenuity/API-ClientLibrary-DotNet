/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.2
 * Since       2016-05-11
 * Filename    Util.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using RestSharp;

namespace RicOneApi.Api
{
 public class Util
    {
        #region Helpers
        /// <summary>
        /// Response handler to return HTTP Status Codes if an error with a request occurs
        /// </summary>
        /// <param name="response"></param>
        public static void ResponseHandler(IRestResponse response)
        {
            HttpStatusCode httpStatusCode = response.StatusCode;

            if (httpStatusCode == HttpStatusCode.OK ||
               httpStatusCode == HttpStatusCode.Created ||
               httpStatusCode == HttpStatusCode.NoContent)
            {
                //Console.WriteLine(httpStatusCode);
                return;
            }
            else
            {
                Console.WriteLine("HttpError: " + httpStatusCode.ToString());
            }
        }

        /// <summary>
        /// Method to iterate through the response header list and concatenates a string to return header fields and values
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static string BuildHeader(IRestResponse response)
        {
            string headerOut = null;

            foreach (var header in response.Headers.ToList())
            {
                headerOut = headerOut + header.Name + "=[" + header.Value + "] ";
            }

            return headerOut;
        }

        #endregion
    }
}
