using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XApplicableEducationLevelListType
    /// </summary>
    public class XApplicableEducationLevelListType
    {
        public XApplicableEducationLevelListType()
        {
            applicableEducationLevel = new List<String>();
        }
        public List<String> applicableEducationLevel { get; set; }
    }
}
