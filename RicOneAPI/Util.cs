using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using RestSharp;

namespace RicOneAPI.Api
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

        #endregion
    }
}
