using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XEnrollmentType
    /// </summary>
    public class Enrollment
    {
        public Enrollment()
        {
            leaRefId = null;
            schoolRefId = null;
            studentSchoolAssociationRefId = null;
            responsibleSchoolType = null;
            membershipType = null;
            entryDate = null;
            exitDate = null;
            homeRoomNumber = null;
            homeRoomTeacher = new PersonReference();
            gradeLevel = null;
            projectedGraduationYear = null;
            counselor = new PersonReference();
        }
        public string leaRefId { get; set; }
        public string schoolRefId { get; set; }
        public string studentSchoolAssociationRefId { get; set; }
        public string responsibleSchoolType { get; set; }
        public string membershipType { get; set; }
        public string entryDate { get; set; }
        public string exitDate { get; set; }
        public string homeRoomNumber { get; set; }
        public PersonReference homeRoomTeacher { get; set; }
        public string gradeLevel { get; set; }
        public string projectedGraduationYear { get; set; }
        public PersonReference counselor { get; set; }
    }
}
