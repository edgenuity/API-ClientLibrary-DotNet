using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStudentContactListType
    /// </summary>
    public class XStudentContactListType
    {
        public XStudentContactListType()
        {
            contactPersonRefId = new List<String>();
            xContact = new List<XContactType>();
        }
        public List<String> contactPersonRefId { get; set; }
        public List<XContactType> xContact { get; set; }
    }
}
