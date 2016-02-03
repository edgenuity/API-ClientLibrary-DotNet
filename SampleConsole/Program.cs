/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1.3.1
 * Since       2016-02-03
 * Filename    Program.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.SifXpress;

namespace SampleConsole
{
    class Program
    {
        #region Test Constants
        const string authUrl = "http://auth.test.ricone.org/login";
        const string username = "YOUR USERNAME";
        const string password = "YOUR PASSWORD";
        //Optional
        const string providerId = "NERIC01";
        //static int navigationPage = 1;
        static int navigationPageSize = 500;

        #endregion
        static void Main(string[] args)
        {
            Authenticator auth = new Authenticator(authUrl, username, password); //Pass username and password to authenticate to Auth server

            foreach (Endpoint e in auth.GetEndpoints(providerId)) //For the provided endpoint
            {
                RicOneApiClient ricOne = new RicOneApiClient(e); //Pass endpoint info to data API (token, href)

                foreach (XLeaType l in ricOne.sifXpress.GetXLeas()) //Iterate through each xLea
                {
                    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXRostersByXLea, l.refId); i++ ) //Get max page size for rosters by lea
                    {
                        foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXLea(l.refId, i, navigationPageSize)) //Get each roster for each lea refId w/ paging
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
