using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    public class OtherStaff
    {
        public OtherStaff()
        {
            staffPersonReference = new PersonReference();
            teacherOfRecord = null;
            percentResponsible = null;
        }
        public PersonReference staffPersonReference { get; set; }
        public string teacherOfRecord { get; set; }
        public string percentResponsible { get; set; }
    }
}
