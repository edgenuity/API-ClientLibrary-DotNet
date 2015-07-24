using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
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
