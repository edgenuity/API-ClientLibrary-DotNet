using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStudentContactListType
    /// </summary>
    public class StudentContacts
    {
        public StudentContacts()
        {
            contactPersonRefId = new List<String>();
            xContact = new List<Contact>();
        }
        public List<String> contactPersonRefId { get; set; }
        public List<Contact> xContact { get; set; }
    }
}
