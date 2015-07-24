using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XContactStudentRelationshipListType
    /// </summary>
    public class XContactStudentRelationshipListType
    {
        public XContactStudentRelationshipListType()
        {
            relationship = new List<XContactStudentRelationshipType>();
        }
        public List<XContactStudentRelationshipType> relationship { get; set; }
    }
}
