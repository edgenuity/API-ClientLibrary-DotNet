using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStudentReferenceListType
    /// </summary>
    public class XStudentReferenceListType
    {
        public XStudentReferenceListType()
        {
            studentReference = new List<XPersonReferenceType>();
        }
        public List<XPersonReferenceType> studentReference { get; set; }
    }
}
