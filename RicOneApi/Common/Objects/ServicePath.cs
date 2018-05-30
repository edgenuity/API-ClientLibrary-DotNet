/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6
 * Since       2018-05-24
 */
namespace RicOneApi.Common.Objects
{
    public enum ServicePathType { Object, Single, Predicate }

    public class ServicePath
    {
        private readonly string servicePathName;
        private readonly string servicePath;
        private readonly ServicePathType servicePathType;

        public ServicePath(string servicePathName, string servicePath, ServicePathType servicePathType)
        {
            this.servicePathName = servicePathName;
            this.servicePath = servicePath;
            this.servicePathType = servicePathType;
        }

        public static ServicePath GetXLeas = new ServicePath("GetXLeas", "xLeas", ServicePathType.Object);
        public static ServicePath GetXLeaByRefId = new ServicePath("GetXLeaByRefId", "xLeas/{refId}", ServicePathType.Single);
        public static ServicePath GetXLeaById = new ServicePath("GetXLeaById", "xLeas/{id}", ServicePathType.Single);
        public static ServicePath GetXLeasByXSchool = new ServicePath("GetXLeasByXSchool", "xSchools/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXLeasByXRoster = new ServicePath("GetXLeasByXRoster", "xRosters/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXLeasByXStaff = new ServicePath("GetXLeasByXStaff", "xStaffs/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXLeasByXStudent = new ServicePath("GetXLeasByXStudent", "xStudents/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXLeasByXContact = new ServicePath("GetXLeasByXContact", "xContacts/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXSchools = new ServicePath("GetXSchools", "xSchools", ServicePathType.Object);
        public static ServicePath GetXSchoolByRefId = new ServicePath("GetXSchoolByRefId", "xSchools/{refId}", ServicePathType.Single);
        public static ServicePath GetXSchoolById = new ServicePath("GetXSchoolById", "xSchools/{id}", ServicePathType.Single);
        public static ServicePath GetXSchoolsByXLea = new ServicePath("GetXSchoolsByXLea", "xLeas/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXCalendar = new ServicePath("GetXSchoolsByXCalendar", "xCalendars/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXCourse = new ServicePath("GetXSchoolsByXCourse", "xCourses/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXRoster = new ServicePath("GetXSchoolsByXRoster", "xRosters/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXStaff = new ServicePath("GetXSchoolsByXStaff", "xStaffs/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXStudent = new ServicePath("GetXSchoolsByXStudent", "xStudents/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXContact = new ServicePath("GetXSchoolsByXContact", "xContacts/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXCalendars = new ServicePath("GetXCalendars", "xCalendars", ServicePathType.Object);
        public static ServicePath GetXCalendarByRefId = new ServicePath("GetXCalendarByRefId", "xCalendars/{refId}", ServicePathType.Single);
        public static ServicePath GetXCalendarsByXLea = new ServicePath("GetXCalendarsByXLea", "xLeas/{refId}/xCalendars", ServicePathType.Predicate);
        public static ServicePath GetXCalendarsByXSchool = new ServicePath("GetXCalendarsByXSchool", "xSchools/{refId}/xCalendars", ServicePathType.Predicate);
        public static ServicePath GetXCourses = new ServicePath("GetXCourses", "xCourses", ServicePathType.Object);
        public static ServicePath GetXCourseByRefId = new ServicePath("GetXCourseByRefId", "xCourses/{refId}", ServicePathType.Single);
        public static ServicePath GetXCoursesByXLea = new ServicePath("GetXCoursesByXLea", "xLeas/{refId}/xCourses", ServicePathType.Predicate);
        public static ServicePath GetXCoursesByXSchool = new ServicePath("GetXCoursesByXSchool", "xSchools/{refId}/xCourses", ServicePathType.Predicate);
        public static ServicePath GetXCoursesByXRoster = new ServicePath("GetXCoursesByXRoster", "xRosters/{refId}/xCourses", ServicePathType.Predicate);
        public static ServicePath GetXRosters = new ServicePath("GetXRosters", "xRosters", ServicePathType.Object);
        public static ServicePath GetXRosterByRefId = new ServicePath("GetXRosterByRefId", "xRosters/{refId}", ServicePathType.Single);
        public static ServicePath GetXRostersByXLea = new ServicePath("GetXRostersByXLea", "xLeas/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXRostersByXSchool = new ServicePath("GetXRostersByXSchool", "xSchools/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXRostersByXCourse = new ServicePath("GetXRostersByXCourse", "xCourses/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXRostersByXStaff = new ServicePath("GetXRostersByXStaff", "xStaffs/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXRostersByXStudent = new ServicePath("GetXRostersByXStudent", "xStudents/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXStaffs = new ServicePath("GetXStaffs", "xStaffs", ServicePathType.Object);
        public static ServicePath GetXStaffByRefId = new ServicePath("GetXStaffByRefId", "xStaffs/{refId}", ServicePathType.Single);
        public static ServicePath GetXStaffsByXLea = new ServicePath("GetXStaffsByXLea", "xLeas/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXSchool = new ServicePath("GetXStaffsByXSchool", "xSchools/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXSchoolAUPP = new ServicePath("GetXStaffsByXSchoolAUPP", "xSchools/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXCourse = new ServicePath("GetXStaffsByXCourse", "xCourses/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXRoster = new ServicePath("GetXStaffsByXRoster", "xRosters/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXStudent = new ServicePath("GetXStaffsByXStudent", "xStudents/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStudents = new ServicePath("GetXStudents", "xStudents", ServicePathType.Object);
        public static ServicePath GetXStudentByRefId = new ServicePath("GetXStudentByRefId", "xStudents/{refId}", ServicePathType.Single);
        public static ServicePath GetXStudentsByXLea = new ServicePath("GetXStudentsByXLea", "xLeas/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXSchool = new ServicePath("GetXStudentsByXSchool", "xSchools/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXSchoolAUPP = new ServicePath("GetXStudentsByXSchoolAUPP", "xSchools/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXRoster = new ServicePath("GetXStudentsByXRoster", "xRosters/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXStaff = new ServicePath("GetXStudentsByXStaff", "xStaffs/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXContact = new ServicePath("GetXStudentsByXContact", "xContacts/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXContacts = new ServicePath("GetXContacts", "xContacts", ServicePathType.Object);
        public static ServicePath GetXContactByRefId = new ServicePath("GetXContactByRefId", "xContacts/{refId}", ServicePathType.Single);
        public static ServicePath GetXContactsByXLea = new ServicePath("GetXContactsByXLea", "xLeas/{refId}/xContacts", ServicePathType.Predicate);
        public static ServicePath GetXContactsByXSchool = new ServicePath("GetXContactsByXSchool", "xSchools/{refId}/xContacts", ServicePathType.Predicate);
        public static ServicePath GetXContactsByXStudent = new ServicePath("GetXContactsByXStudent", "xStudents/{refId}/xContacts", ServicePathType.Predicate);

        public string GetServicePathName() { return servicePathName; }
        public string GetServicePath() { return servicePath; }
        public ServicePathType GetServicePathType() { return servicePathType; }
    }
}
