/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XEnrollmentType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XEnrollmentType
    /// </summary>
    public class XEnrollmentType
    {
        public XEnrollmentType()
        {
            leaRefId = null;
            schoolRefId = null;
            studentSchoolAssociationRefId = null;
            responsibleSchoolType = null;
            membershipType = null;
            entryDate = null;
            exitDate = null;
            homeRoomNumber = null;
            homeRoomTeacher = new XPersonReferenceType();
            gradeLevel = null;
            projectedGraduationYear = null;
            counselor = new XPersonReferenceType();
        }
        public string leaRefId { get; set; }
        public string schoolRefId { get; set; }
        public string studentSchoolAssociationRefId { get; set; }
        public string responsibleSchoolType { get; set; }
        public string membershipType { get; set; }
        public string entryDate { get; set; }
        public string exitDate { get; set; }
        public string homeRoomNumber { get; set; }
        public XPersonReferenceType homeRoomTeacher { get; set; }
        public string gradeLevel { get; set; }
        public string projectedGraduationYear { get; set; }
        public XPersonReferenceType counselor { get; set; }
    }
}
