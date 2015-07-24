using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XContactStudentRelationshipType
    /// </summary>
    public class XContactStudentRelationshipType
    {
        public XContactStudentRelationshipType()
        {
            studentRefId = null;
            relationshipCode = null;
            restrictions = null;
            livesWith = null;
            primaryContactIndicator = null;
            emergencyContactIndicator = null;
            financialResponsibilityIndicator = null;
            custodialIndicator = null;
            communicationsIndicator = null;
            contactSequence = null;
        }
        public string studentRefId { get; set; }
        public string relationshipCode { get; set; }
        public string restrictions { get; set; }
        public bool? livesWith { get; set; }
        public bool? primaryContactIndicator { get; set; }
        public bool? emergencyContactIndicator { get; set; }
        public bool? financialResponsibilityIndicator { get; set; }
        public bool? custodialIndicator { get; set; }
        public bool? communicationsIndicator { get; set; }
        public int? contactSequence { get; set; }


    }
}
