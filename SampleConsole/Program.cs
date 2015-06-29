using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RicOneAPI.Api;
using RicOneAPI.Models.Authentication;
using RicOneAPI.Models.SIFxPress;

namespace SampleConsole
{
    class Program
    {
        #region Test Constants
        //const string username = "YOUR USERNAME";
        //const string password = "YOUR PASSWORD";
        const string username = "Full_3";
        const string password = "Full_3";
        //Optional
        const string providerId = "South Central RIC - Test Data Provider 1";
        static string navigationPage = "1";
        static string navigationPageSize = "5";

        #endregion
        static void Main(string[] args)
        {
            Authenticator auth = new Authenticator(username, password); //Pass username and password to authenticate to OAuth server

            foreach (Endpoint e in auth.GetEndpoints(providerId)) //For the provided endpoint
            {
                RicOneAPIClient ricOne = new RicOneAPIClient(e); //Pass endpoint info to data API (token, href)

                foreach (XLea l in ricOne.sifXpress.GetXLeas()) //Iterate through each xLea
                {
                    foreach (XRoster r in ricOne.sifXpress.GetXRostersByXLea(l.refId, navigationPage, navigationPageSize)) //Get each roster for each lea refId w/ paging
                    {
                        Console.WriteLine("courseTitle: " + r.courseTitle);
                        foreach (PersonReference p in r.students.studentReference) //Students for each course
                        {
                            Console.WriteLine("refId: " + p.refId);
                            Console.WriteLine("localId: " + p.localId);
                            Console.WriteLine("givenName: " + p.givenName);
                            Console.WriteLine("familyName: " + p.familyName);
                        }

                    }
                }
            }

            Console.Read();
        }
    }
}
