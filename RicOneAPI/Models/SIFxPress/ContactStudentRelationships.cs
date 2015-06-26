using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XContactStudentRelationshipListType
    /// </summary>
    public class ContactStudentRelationships
    {
        public ContactStudentRelationships()
        {
            relationship = new List<ContactStudentRelationship>();
        }
        public List<ContactStudentRelationship> relationship { get; set; }
    }
}
