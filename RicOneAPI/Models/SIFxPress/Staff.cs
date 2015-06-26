using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XStaffReferenceType
    /// </summary>
    public class Staff
    {
        public Staff()
        {
            staffPersonReference = new PersonReference();
            teacherOfRecord = null;
            percentResponsible = null;
        }
        public PersonReference staffPersonReference { get; set; }
        public string teacherOfRecord { get; set; }
        public decimal? percentResponsible { get; set; }
    }
}
