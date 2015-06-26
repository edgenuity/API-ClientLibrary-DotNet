using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStudentReferenceListType
    /// </summary>
    public class Students
    {
        public Students()
        {
            studentReference = new List<PersonReference>();
        }
        public List<PersonReference> studentReference { get; set; }
    }
}
