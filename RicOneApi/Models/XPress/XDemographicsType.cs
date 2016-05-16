/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XDemographicsType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XDemographicsType
    /// </summary>
    public class XDemographicsType
    {
        public XDemographicsType()
        {
            races = new XRaceListType();
            hispanicLatinoEthnicity = null;
            sex = null;
            birthDate = null;
            countryOfBirth = null;
            usCitizenshipStatus = null;
        }
        public XRaceListType races { get; set; }
        public bool? hispanicLatinoEthnicity { get; set; }
        public string sex { get; set; }
        public string birthDate { get; set; }
        public string countryOfBirth { get; set; }
        public string usCitizenshipStatus { get; set; }
    }
}
