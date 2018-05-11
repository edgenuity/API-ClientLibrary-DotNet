using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Common.Objects
{
    enum ServicePathType { Object, Single, Predicate }

    class ServicePath
    {
        private readonly string servicePath;
        private readonly ServicePathType servicePathType;

        internal ServicePath(string servicePath, ServicePathType servicePathType)
        {
            this.servicePath = servicePath;
            this.servicePathType = servicePathType;
        }

        public static ServicePath GetXLeas = new ServicePath("xLeas", ServicePathType.Object);
        public static ServicePath GetXLeaByRefId = new ServicePath("xLeas/{refId}", ServicePathType.Single);
        public static ServicePath GetXLeaById = new ServicePath("xLeas/{id}", ServicePathType.Single);
        public static ServicePath GetXLeasByXSchool = new ServicePath("xSchools/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXLeasByXRoster = new ServicePath("xRosters/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXLeasByXStaff = new ServicePath("xStaffs/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXLeasByXStudent = new ServicePath("xStudents/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXLeasByXContact = new ServicePath("xContacts/{refId}/xLeas", ServicePathType.Predicate);
        public static ServicePath GetXSchools = new ServicePath("xSchools", ServicePathType.Object);
        public static ServicePath GetXSchoolByRefId = new ServicePath("xSchools/{refId}", ServicePathType.Single);
        public static ServicePath GetXSchoolById = new ServicePath("xSchools/{id}", ServicePathType.Single);
        public static ServicePath GetXSchoolsByXLea = new ServicePath("xLeas/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXCalendar = new ServicePath("xCalendars/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXCourse = new ServicePath("xCourses/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXRoster = new ServicePath("xRosters/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXStaff = new ServicePath("xStaffs/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXStudent = new ServicePath("xStudents/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXSchoolsByXContact = new ServicePath("xContacts/{refId}/xSchools", ServicePathType.Predicate);
        public static ServicePath GetXCalendars = new ServicePath("xCalendars", ServicePathType.Object);
        public static ServicePath GetXCalendarByRefId = new ServicePath("xCalendars/{refId}", ServicePathType.Single);
        public static ServicePath GetXCalendarsByXLea = new ServicePath("xLeas/{refId}/xCalendars", ServicePathType.Predicate);
        public static ServicePath GetXCalendarsByXSchool = new ServicePath("xSchools/{refId}/xCalendars", ServicePathType.Predicate);
        public static ServicePath GetXCourses = new ServicePath("xCourses", ServicePathType.Object);
        public static ServicePath GetXCourseByRefId = new ServicePath("xCourses/{refId}", ServicePathType.Single);
        public static ServicePath GetXCoursesByXLea = new ServicePath("xLeas/{refId}/xCourses", ServicePathType.Predicate);
        public static ServicePath GetXCoursesByXSchool = new ServicePath("xSchools/{refId}/xCourses", ServicePathType.Predicate);
        public static ServicePath GetXCoursesByXRoster = new ServicePath("xRosters/{refId}/xCourses", ServicePathType.Predicate);
        public static ServicePath GetXRosters = new ServicePath("xRosters", ServicePathType.Object);
        public static ServicePath GetXRosterByRefId = new ServicePath("xRosters/{refId}", ServicePathType.Single);
        public static ServicePath GetXRostersByXLea = new ServicePath("xLeas/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXRostersByXSchool = new ServicePath("xSchools/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXRostersByXCourse = new ServicePath("xCourses/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXRostersByXStaff = new ServicePath("xStaffs/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXRostersByXStudent = new ServicePath("xStudents/{refId}/xRosters", ServicePathType.Predicate);
        public static ServicePath GetXStaffs = new ServicePath("xStaffs", ServicePathType.Object);
        public static ServicePath GetXStaffByRefId = new ServicePath("xStaffs/{refId}", ServicePathType.Single);
        public static ServicePath GetXStaffsByXLea = new ServicePath("xLeas/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXSchool = new ServicePath("xSchools/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXSchoolAUPP = new ServicePath("xSchools/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXCourse = new ServicePath("xCourses/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXRoster = new ServicePath("xRosters/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStaffsByXStudent = new ServicePath("xStudents/{refId}/xStaffs", ServicePathType.Predicate);
        public static ServicePath GetXStudents = new ServicePath("xStudents", ServicePathType.Object);
        public static ServicePath GetXStudentByRefId = new ServicePath("xStudents/{refId}", ServicePathType.Single);
        public static ServicePath GetXStudentsByXLea = new ServicePath("xLeas/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXSchool = new ServicePath("xSchools/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXSchoolAUPP = new ServicePath("xSchools/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXRoster = new ServicePath("xRosters/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXStaff = new ServicePath("xStaffs/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXStudentsByXContact = new ServicePath("xContacts/{refId}/xStudents", ServicePathType.Predicate);
        public static ServicePath GetXContacts = new ServicePath("xContacts", ServicePathType.Object);
        public static ServicePath GetXContactByRefId = new ServicePath("xContacts/{refId}", ServicePathType.Single);
        public static ServicePath GetXContactsByXLea = new ServicePath("xLeas/{refId}/xContacts", ServicePathType.Predicate);
        public static ServicePath GetXContactsByXSchool = new ServicePath("xSchools/{refId}/xContacts", ServicePathType.Predicate);
        public static ServicePath GetXContactsByXStudent = new ServicePath("xStudents/{refId}/xContacts", ServicePathType.Predicate);

        public string GetServicePath() { return servicePath; }
        public ServicePathType GetServicePathType() { return servicePathType; }
    }
}
