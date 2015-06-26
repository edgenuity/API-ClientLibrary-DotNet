using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XDemographicsType
    /// </summary>
    public class Demographics
    {
        public Demographics()
        {
            races = new Races();
            hispanicLatinoEthnicity = null;
            sex = null;
            birthDate = null;
            countryOfBirth = null;
            usCitizenshipStatus = null;
        }
        public Races races { get; set; }
        public string hispanicLatinoEthnicity { get; set; }
        public string sex { get; set; }
        public string birthDate { get; set; }
        public string countryOfBirth { get; set; }
        public string usCitizenshipStatus { get; set; }
    }
}
