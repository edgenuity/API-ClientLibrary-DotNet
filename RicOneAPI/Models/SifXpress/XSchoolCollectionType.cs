using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XSchoolCollectionType
    /// </summary>
    public class XSchoolCollectionType
    {
        public XSchoolCollectionType()
        {
            xSchools = null;
            xSchool = new List<XSchoolType>();
        }
        public XSchoolCollectionType xSchools { get; set; }
        public List<XSchoolType> xSchool { get; set; }
    }
}
