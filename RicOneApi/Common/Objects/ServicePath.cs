/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6.1
 * Since       2018-06-04
 */
namespace RicOneApi.Common.Objects
{
    internal enum ServicePathType { Object, Single, Predicate }

    /// <summary>
    /// Class that stores service path information. Used for GetLastPage().
    /// </summary>
    public class ServicePath
    {
        private readonly string servicePathName;
        private readonly string servicePath;
        private readonly ServicePathType servicePathType;

        private ServicePath(string servicePathName, string servicePath, ServicePathType servicePathType)
        {
            this.servicePathName = servicePathName;
            this.servicePath = servicePath;
            this.servicePathType = servicePathType;
        }

        /// <summary>
        /// Returns all Leas.
        /// </summary>
        public static ServicePath GetXLeas = new ServicePath("GetXLeas", "xLeas", ServicePathType.Object);
        /// <summary>
        /// Returns a single Lea by refId.
        /// </summary>
        public static ServicePath GetXLeaByRefId = new ServicePath("GetXLeaByRefId", "xLeas/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns a single Lea by BEDS code or Local Id.
        /// </summary>
        public static ServicePath GetXLeaById = new ServicePath("GetXLeaById", "xLeas/{id}", ServicePathType.Single);
        /// <summary>
        /// Returns Leas associated to a specific School by refId.
        /// </summary>
        public static ServicePath GetXLeasByXSchool = new ServicePath("GetXLeasByXSchool", "xSchools/{refId}/xLeas", ServicePathType.Predicate);
        /// <summary>
        /// Returns Leas associated to a specific Roster by refId.
        /// </summary>
        public static ServicePath GetXLeasByXRoster = new ServicePath("GetXLeasByXRoster", "xRosters/{refId}/xLeas", ServicePathType.Predicate);
        /// <summary>
        /// Returns Leas associated to a specific Staff by refId.
        /// </summary>
        public static ServicePath GetXLeasByXStaff = new ServicePath("GetXLeasByXStaff", "xStaffs/{refId}/xLeas", ServicePathType.Predicate);
        /// <summary>
        /// Returns Leas associated to a specific Student by refId.
        /// </summary>
        public static ServicePath GetXLeasByXStudent = new ServicePath("GetXLeasByXStudent", "xStudents/{refId}/xLeas", ServicePathType.Predicate);
        /// <summary>
        /// Returns Leas associated to a specific Contact by refId
        /// </summary>
        public static ServicePath GetXLeasByXContact = new ServicePath("GetXLeasByXContact", "xContacts/{refId}/xLeas", ServicePathType.Predicate);
        /// <summary>
        /// Returns all Schools.
        /// </summary>
        public static ServicePath GetXSchools = new ServicePath("GetXSchools", "xSchools", ServicePathType.Object);
        /// <summary>
        /// Returns a single School by refId.
        /// </summary>
        public static ServicePath GetXSchoolByRefId = new ServicePath("GetXSchoolByRefId", "xSchools/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns a single School by BEDS code or Local Id.
        /// </summary>
        public static ServicePath GetXSchoolById = new ServicePath("GetXSchoolById", "xSchools/{id}", ServicePathType.Single);
        /// <summary>
        /// Returns Schools associated to a specific Lea by refId.
        /// </summary>
        public static ServicePath GetXSchoolsByXLea = new ServicePath("GetXSchoolsByXLea", "xLeas/{refId}/xSchools", ServicePathType.Predicate);
        /// <summary>
        /// Returns Schools associated to a specific Calendar by refId.
        /// </summary>
        public static ServicePath GetXSchoolsByXCalendar = new ServicePath("GetXSchoolsByXCalendar", "xCalendars/{refId}/xSchools", ServicePathType.Predicate);
        /// <summary>
        /// Returns Schools associated to a specific Course by refId.
        /// </summary>
        public static ServicePath GetXSchoolsByXCourse = new ServicePath("GetXSchoolsByXCourse", "xCourses/{refId}/xSchools", ServicePathType.Predicate);
        /// <summary>
        /// Returns Schools associated to a specific Roster by refId.
        /// </summary>
        public static ServicePath GetXSchoolsByXRoster = new ServicePath("GetXSchoolsByXRoster", "xRosters/{refId}/xSchools", ServicePathType.Predicate);
        /// <summary>
        /// Returns Schools associated to a specific Staff by refId.
        /// </summary>
        public static ServicePath GetXSchoolsByXStaff = new ServicePath("GetXSchoolsByXStaff", "xStaffs/{refId}/xSchools", ServicePathType.Predicate);
        /// <summary>
        /// Returns Schools associated to a specific Student by refId.
        /// </summary>
        public static ServicePath GetXSchoolsByXStudent = new ServicePath("GetXSchoolsByXStudent", "xStudents/{refId}/xSchools", ServicePathType.Predicate);
        /// <summary>
        /// Returns Schools associated to a specific Contact by refId.
        /// </summary>
        public static ServicePath GetXSchoolsByXContact = new ServicePath("GetXSchoolsByXContact", "xContacts/{refId}/xSchools", ServicePathType.Predicate);
        /// <summary>
        /// Returns all Calendars.
        /// </summary>
        public static ServicePath GetXCalendars = new ServicePath("GetXCalendars", "xCalendars", ServicePathType.Object);
        /// <summary>
        /// Returns a single Calendar by refId.
        /// </summary>
        public static ServicePath GetXCalendarByRefId = new ServicePath("GetXCalendarByRefId", "xCalendars/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns Calendars associated to a specific Lea by refId
        /// </summary>
        public static ServicePath GetXCalendarsByXLea = new ServicePath("GetXCalendarsByXLea", "xLeas/{refId}/xCalendars", ServicePathType.Predicate);
        /// <summary>
        /// Returns Calendars associated to a specific School by refId.
        /// </summary>
        public static ServicePath GetXCalendarsByXSchool = new ServicePath("GetXCalendarsByXSchool", "xSchools/{refId}/xCalendars", ServicePathType.Predicate);
        /// <summary>
        /// Returns all Courses.
        /// </summary>
        public static ServicePath GetXCourses = new ServicePath("GetXCourses", "xCourses", ServicePathType.Object);
        /// <summary>
        /// Returns a single Course by refId.
        /// </summary>
        public static ServicePath GetXCourseByRefId = new ServicePath("GetXCourseByRefId", "xCourses/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns Courses associated to a specific Lea by refId.
        /// </summary>
        public static ServicePath GetXCoursesByXLea = new ServicePath("GetXCoursesByXLea", "xLeas/{refId}/xCourses", ServicePathType.Predicate);
        /// <summary>
        /// Returns Courses associated to a specific School by refId.
        /// </summary>
        public static ServicePath GetXCoursesByXSchool = new ServicePath("GetXCoursesByXSchool", "xSchools/{refId}/xCourses", ServicePathType.Predicate);
        /// <summary>
        /// Returns Courses associated to a specific Roster by refId.
        /// </summary>
        public static ServicePath GetXCoursesByXRoster = new ServicePath("GetXCoursesByXRoster", "xRosters/{refId}/xCourses", ServicePathType.Predicate);
        /// <summary>
        /// Returns all Rosters.
        /// </summary>
        public static ServicePath GetXRosters = new ServicePath("GetXRosters", "xRosters", ServicePathType.Object);
        /// <summary>
        /// Returns a single Roster by refId.
        /// </summary>
        public static ServicePath GetXRosterByRefId = new ServicePath("GetXRosterByRefId", "xRosters/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns Rosters associated to a specific Lea by refId.
        /// </summary>
        public static ServicePath GetXRostersByXLea = new ServicePath("GetXRostersByXLea", "xLeas/{refId}/xRosters", ServicePathType.Predicate);
        /// <summary>
        /// Returns Rosters associated to a specific School by refId.
        /// </summary>
        public static ServicePath GetXRostersByXSchool = new ServicePath("GetXRostersByXSchool", "xSchools/{refId}/xRosters", ServicePathType.Predicate);
        /// <summary>
        /// Returns Rosters associated to a specific Course by refId.
        /// </summary>
        public static ServicePath GetXRostersByXCourse = new ServicePath("GetXRostersByXCourse", "xCourses/{refId}/xRosters", ServicePathType.Predicate);
        /// <summary>
        /// Returns Sections associated to a specific Staff by refId.
        /// </summary>
        public static ServicePath GetXRostersByXStaff = new ServicePath("GetXRostersByXStaff", "xStaffs/{refId}/xRosters", ServicePathType.Predicate);
        /// <summary>
        /// Returns Rosters associated to a specific Student by refId.
        /// </summary>
        public static ServicePath GetXRostersByXStudent = new ServicePath("GetXRostersByXStudent", "xStudents/{refId}/xRosters", ServicePathType.Predicate);
        /// <summary>
        /// Returns all Staff.
        /// </summary>
        public static ServicePath GetXStaffs = new ServicePath("GetXStaffs", "xStaffs", ServicePathType.Object);
        /// <summary>
        /// Returns a single Staff by refId.
        /// </summary>
        public static ServicePath GetXStaffByRefId = new ServicePath("GetXStaffByRefId", "xStaffs/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns a single Staff by state or local id.
        /// </summary>
        public static ServicePath GetXStaffById = new ServicePath("GetXStaffById", "xStaffs/{id}", ServicePathType.Single);
        /// <summary>
        /// Returns Staff associated to a specific Lea by refId.
        /// </summary>
        public static ServicePath GetXStaffsByXLea = new ServicePath("GetXStaffsByXLea", "xLeas/{refId}/xStaffs", ServicePathType.Predicate);
        /// <summary>
        /// Returns Staff associated to a specific School by refId.
        /// </summary>
        public static ServicePath GetXStaffsByXSchool = new ServicePath("GetXStaffsByXSchool", "xSchools/{refId}/xStaffs", ServicePathType.Predicate);
        /// <summary>
        /// Returns Staff associated to a specific Course by refId.
        /// </summary>
        public static ServicePath GetXStaffsByXCourse = new ServicePath("GetXStaffsByXCourse", "xCourses/{refId}/xStaffs", ServicePathType.Predicate);
        /// <summary>
        /// Returns Staff associated to a specific Roster by refId
        /// </summary>
        public static ServicePath GetXStaffsByXRoster = new ServicePath("GetXStaffsByXRoster", "xRosters/{refId}/xStaffs", ServicePathType.Predicate);
        /// <summary>
        /// Returns Staff associated to a specific Student by refId.
        /// </summary>
        public static ServicePath GetXStaffsByXStudent = new ServicePath("GetXStaffsByXStudent", "xStudents/{refId}/xStaffs", ServicePathType.Predicate);
        /// <summary>
        /// Returns all Students.
        /// </summary>
        public static ServicePath GetXStudents = new ServicePath("GetXStudents", "xStudents", ServicePathType.Object);
        /// <summary>
        /// Returns a single Student by refId.
        /// </summary>
        public static ServicePath GetXStudentByRefId = new ServicePath("GetXStudentByRefId", "xStudents/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns a single Student by state or local id.
        /// </summary>
        public static ServicePath GetXStudentById = new ServicePath("GetXStudentById", "xStudents/{id}", ServicePathType.Single);
        /// <summary>
        /// Returns Students associated to a specific Lea by refId.
        /// </summary>
        public static ServicePath GetXStudentsByXLea = new ServicePath("GetXStudentsByXLea", "xLeas/{refId}/xStudents", ServicePathType.Predicate);
        /// <summary>
        /// Returns Students associated to a specific School by refId.
        /// </summary>
        public static ServicePath GetXStudentsByXSchool = new ServicePath("GetXStudentsByXSchool", "xSchools/{refId}/xStudents", ServicePathType.Predicate);
        /// <summary>
        /// Returns Students associated to a specific Roster by refId.
        /// </summary>
        public static ServicePath GetXStudentsByXRoster = new ServicePath("GetXStudentsByXRoster", "xRosters/{refId}/xStudents", ServicePathType.Predicate);
        /// <summary>
        /// Returns Students associated to a specific Staff by refId.
        /// </summary>
        public static ServicePath GetXStudentsByXStaff = new ServicePath("GetXStudentsByXStaff", "xStaffs/{refId}/xStudents", ServicePathType.Predicate);
        /// <summary>
        /// Returns Students associated to a specific Contact by refId.
        /// </summary>
        public static ServicePath GetXStudentsByXContact = new ServicePath("GetXStudentsByXContact", "xContacts/{refId}/xStudents", ServicePathType.Predicate);
        /// <summary>
        /// Returns all Contacts.
        /// </summary>
        public static ServicePath GetXContacts = new ServicePath("GetXContacts", "xContacts", ServicePathType.Object);
        /// <summary>
        /// Returns a single Contact by refId.
        /// </summary>
        public static ServicePath GetXContactByRefId = new ServicePath("GetXContactByRefId", "xContacts/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns Contacts associated to a specific Lea by refId.
        /// </summary>
        public static ServicePath GetXContactsByXLea = new ServicePath("GetXContactsByXLea", "xLeas/{refId}/xContacts", ServicePathType.Predicate);
        /// <summary>
        /// Returns Contacts associated to a specific School by refId.
        /// </summary>
        public static ServicePath GetXContactsByXSchool = new ServicePath("GetXContactsByXSchool", "xSchools/{refId}/xContacts", ServicePathType.Predicate);
        /// <summary>
        /// Returns Contacts associated to a specific Student by refId.
        /// </summary>
        public static ServicePath GetXContactsByXStudent = new ServicePath("GetXContactsByXStudent", "xStudents/{refId}/xContacts", ServicePathType.Predicate);
        /// <summary>
        /// Returns all xEmployments.
        /// </summary>
        public static ServicePath GetXEmployments = new ServicePath("GetXEmployments", "xEmployments", ServicePathType.Object);
        /// <summary>
        /// Returns a single xEmployment by refId.
        /// </summary>
        public static ServicePath GetXEmploymentByRefId = new ServicePath("GetXEmploymentByRefId", "xEmployments/{refId}", ServicePathType.Single);
        /// <summary>
        /// Returns xEmployments associated to a specific Lea by refId.
        /// </summary>
        public static ServicePath GetXEmploymentsByXLea = new ServicePath("GetXEmploymentsByXLea", "xLeas/{refId}/xEmployments", ServicePathType.Predicate);
        /// <summary>
        /// Returns xEmployments associated to a specific School by refId.
        /// </summary>
        public static ServicePath GetXEmploymentsByXSchool = new ServicePath("GetXEmploymentsByXSchool", "xSchools/{refId}/xEmployments", ServicePathType.Predicate);

        internal string GetServicePathName() { return servicePathName; }
        internal string GetServicePath() { return servicePath; }
        internal ServicePathType GetServicePathType() { return servicePathType; }
    }
}
