/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.2
 * Since       2016-05-13
 * Filename    Program.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;

namespace SampleConsole
{
    class Program
    {
        #region Test Constants
        const string authUrl = "AUTH URL";
        const string username = "YOUR USERNAME";
        const string password = "YOUR PASSWORD";
        //Optional
        const string providerId = "sandbox";
        //static int navigationPage = 1;
        static int navigationPageSize = 500;

        #endregion
        static void Main(string[] args)
        {
            Authenticator auth = new Authenticator(authUrl, username, password); //Pass auth url, username, and password to authenticate to auth server

            foreach (Endpoint e in auth.GetEndpoints(providerId)) //For the provided endpoint
            {
                RicOneApiClient ricOne = new RicOneApiClient(e); //Pass endpoint info to data API (token, href)

                foreach (XLeaType l in ricOne.xPress.GetXLeas().Data) //Iterate through each xLea
                {
                    for (int i = 1; i <= ricOne.xPress.GetLastPage(navigationPageSize, XPress.ServicePath.GetXRostersByXLea, l.refId); i++ ) //Get max page size for rosters by lea
                    {
                        foreach (XRosterType r in ricOne.xPress.GetXRostersByXLea(l.refId, i, navigationPageSize).Data) //Get each roster for each lea refId w/ paging
                        {
                            Console.WriteLine("courseTitle: " + r.courseTitle);
                            foreach (XPersonReferenceType p in r.students.studentReference) //Students for each course
                            {
                                Console.WriteLine("refId: " + p.refId);
                                Console.WriteLine("localId: " + p.localId);
                                Console.WriteLine("givenName: " + p.givenName);
                                Console.WriteLine("familyName: " + p.familyName);
                            }
                        }
                        Console.WriteLine("######## PAGE " + i + " ########");
                    }
                    
                }
            }

            Console.Read();
        }
    }
}
