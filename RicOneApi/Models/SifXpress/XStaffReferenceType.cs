using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XStaffReferenceType
    /// </summary>
    public class XStaffReferenceType
    {
        public XStaffReferenceType()
        {
            staffPersonReference = new XPersonReferenceType();
            teacherOfRecord = null;
            percentResponsible = null;
        }
        public XPersonReferenceType staffPersonReference { get; set; }
        public bool? teacherOfRecord { get; set; }
        public decimal? percentResponsible { get; set; }
    }
}
