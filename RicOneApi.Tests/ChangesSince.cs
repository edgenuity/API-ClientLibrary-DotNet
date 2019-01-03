using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using System;
using System.Collections.Generic;

namespace RicOneApi.Tests
{
    class ChangesSince
    {
        #region Test Constants
        const string authUrl = "https://auth.test.ricone.org/login";
        const string clientId = "dpaDemo";
        const string clientSecret = "deecd889bff5ed0101a86680752f5f9";
        const string providerId = "localhost";

        const string LEA_REFID = "03ACF04F-DC12-411A-9A42-E8323516D699";
        const string SCHOOL_REFID = "AE6B3441-5E31-4573-BADB-081669D79C7F";
        const string CALENDAR_REFID = "09C5E439-D7DA-45A1-AB0D-D7524C7B1DD0";
        const string COURSE_REFID = "32B850D8-2B67-47ED-ADC2-8BA02C376F67";
        const string ROSTER_REFID = "00BAD4F5-9CF4-4D49-A8CC-666D02180300";
        const string STAFF_REFID = "0C6E7BFA-4E4E-4F82-BCE8-C27729A79F29";
        const string STUDENT_REFID = "77F372FF-3C8B-450D-86DE-8899318813A7";
        const string CONTACT_REFID = "06F78B09-F30D-43F8-AC68-5399336B0972";

        const string OPAQUE_MARKER = "2018-11-30T10:28:24.626-05:00";
        #endregion

        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);

            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(e.href);

                /* xLeas */
                //GetXLeas(xPress);
                //GetXLeasByXSchool(xPress);
                //GetXLeasByXRoster(xPress);
                //GetXLeasByXStaff(xPress);
                //GetXLeasByXStudent(xPress);
                //GetXLeasByXContact(xPress);
                /* xSchools */
                //GetXSchools(xPress);
                //GetXSchoolsByXLea(xPress);
                //GetXSchoolsByXCalendar(xPress);
                //GetXSchoolsByXCourse(xPress);
                //GetXSchoolsByXRoster(xPress);
                //GetXSchoolsByXStaff(xPress);
                //GetXSchoolsByXStudent(xPress);
                //GetXSchoolsByXContact(xPress);
                /* xCalendars */
                //GetXCalendars(xPress);
                //GetXCalendarsByXLea(xPress);
                //GetXCalendarsByXSchool(xPress);
                /* xCourses */
                //GetXCourses(xPress);
                //GetXCoursesByXLea(xPress);
                //GetXCoursesByXSchool(xPress);
                //GetXCoursesByXRoster(xPress);
                /* xRosters */
                //GetXRosters(xPress);
                //GetXRostersByXLea(xPress);
                //GetXRostersByXSchool(xPress);
                //GetXRostersByXCourse(xPress);
                //GetXRostersByXStaff(xPress);
                //GetXRostersByXStudent(xPress);
                /* xStaffs */
                //GetXStaffs(xPress);
                //GetXStaffsByXLea(xPress);
                //GetXStaffsByXSchool(xPress);
                //GetXStaffsByXCourse(xPress);
                //GetXStaffsByXRoster(xPress);
                //GetXStaffsByXStudent(xPress);
                /* xStudents */
                //GetXStudents(xPress);
                //GetXStudentsByXLea(xPress);
                //GetXStudentsByXSchool(xPress);
                //GetXStudentsByXRoster(xPress);
                //GetXStudentsByXStaff(xPress);
                //GetXStudentsByXContact(xPress);
                /* xContacts */
                //GetXContacts(xPress);
                //GetXContactsByXLea(xPress);
                //GetXContactsByXSchool(xPress);
                //GetXContactsByXStudent(xPress);

            }

            Console.Read();
        }

        /* xLeas */
        public static void GetXLeas(XPress xPress)
        {
            List<XLeaType> xLeaTypeList = xPress.GetXLeas(OPAQUE_MARKER).Data;
            
            foreach (XLeaType o in xLeaTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.leaName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXLeasByXSchool(XPress xPress)
        {
            List<XLeaType> xLeaTypeList = xPress.GetXLeasByXSchool(SCHOOL_REFID, OPAQUE_MARKER).Data;
            foreach (XLeaType o in xLeaTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.leaName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXLeasByXRoster(XPress xPress)
        {
            List<XLeaType> xLeaTypeList = xPress.GetXLeasByXRoster(ROSTER_REFID, OPAQUE_MARKER).Data;
            foreach (XLeaType o in xLeaTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.leaName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXLeasByXStaff(XPress xPress)
        {
            List<XLeaType> xLeaTypeList = xPress.GetXLeasByXStaff(STAFF_REFID, OPAQUE_MARKER).Data;
            foreach (XLeaType o in xLeaTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.leaName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXLeasByXStudent(XPress xPress)
        {
            List<XLeaType> xLeaTypeList = xPress.GetXLeasByXStudent(STUDENT_REFID, OPAQUE_MARKER).Data;
            foreach (XLeaType o in xLeaTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.leaName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXLeasByXContact(XPress xPress)
        {
            List<XLeaType> xLeaTypeList = xPress.GetXLeasByXContact(CONTACT_REFID, OPAQUE_MARKER).Data;
            foreach (XLeaType o in xLeaTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.leaName + " | " + o.Metadata.SchoolYear);
            }
        }

        /* xSchools */
        public static void GetXSchools(XPress xPress)
        {
            List<XSchoolType> xSchoolTypeList = xPress.GetXSchools(OPAQUE_MARKER).Data;
            foreach (XSchoolType o in xSchoolTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXSchoolsByXLea(XPress xPress)
        {
            List<XSchoolType> xSchoolTypeList = xPress.GetXSchoolsByXLea(LEA_REFID, OPAQUE_MARKER).Data;
            foreach (XSchoolType o in xSchoolTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXSchoolsByXCalendar(XPress xPress)
        {
            List<XSchoolType> xSchoolTypeList = xPress.GetXSchoolsByXCalendar(CALENDAR_REFID, OPAQUE_MARKER).Data;
            foreach (XSchoolType o in xSchoolTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXSchoolsByXCourse(XPress xPress)
        {
            List<XSchoolType> xSchoolTypeList = xPress.GetXSchoolsByXCourse(COURSE_REFID, OPAQUE_MARKER).Data;
            foreach (XSchoolType o in xSchoolTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXSchoolsByXRoster(XPress xPress)
        {
            List<XSchoolType> xSchoolTypeList = xPress.GetXSchoolsByXRoster(ROSTER_REFID, OPAQUE_MARKER).Data;
            foreach (XSchoolType o in xSchoolTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXSchoolsByXStaff(XPress xPress)
        {
            List<XSchoolType> xSchoolTypeList = xPress.GetXSchoolsByXStaff(STAFF_REFID, OPAQUE_MARKER).Data;
            foreach (XSchoolType o in xSchoolTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXSchoolsByXStudent(XPress xPress)
        {
            List<XSchoolType> xSchoolTypeList = xPress.GetXSchoolsByXStudent(STUDENT_REFID, OPAQUE_MARKER).Data;
            foreach (XSchoolType o in xSchoolTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolName + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXSchoolsByXContact(XPress xPress)
        {
            List<XSchoolType> xSchoolTypeList = xPress.GetXSchoolsByXContact(CONTACT_REFID, OPAQUE_MARKER).Data;
            foreach (XSchoolType o in xSchoolTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolName + " | " + o.Metadata.SchoolYear);
            }
        }

        ///* xCalendars */
        public static void GetXCalendars(XPress xPress)
        {
            List<XCalendarType> xCalendarTypeList = xPress.GetXCalendars(OPAQUE_MARKER).Data;
            foreach (XCalendarType o in xCalendarTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolRefId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXCalendarsByXLea(XPress xPress)
        {
            List<XCalendarType> xCalendarTypeList = xPress.GetXCalendarsByXLea(LEA_REFID, OPAQUE_MARKER).Data;
            foreach (XCalendarType o in xCalendarTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolRefId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXCalendarsByXSchool(XPress xPress)
        {
            List<XCalendarType> xCalendarTypeList = xPress.GetXCalendarsByXSchool(SCHOOL_REFID, OPAQUE_MARKER).Data;
            foreach (XCalendarType o in xCalendarTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.schoolRefId + " | " + o.Metadata.SchoolYear);
            }
        }

        /* xCourses */
        public static void GetXCourses(XPress xPress)
        {
            List<XCourseType> xCourseTypeList = xPress.GetXCourses(OPAQUE_MARKER).Data;
            foreach (XCourseType o in xCourseTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXCoursesByXLea(XPress xPress)
        {
            List<XCourseType> xCourseTypeList = xPress.GetXCoursesByXLea(LEA_REFID, OPAQUE_MARKER).Data;
            foreach (XCourseType o in xCourseTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXCoursesByXSchool(XPress xPress)
        {
            List<XCourseType> xCourseTypeList = xPress.GetXCoursesByXSchool(SCHOOL_REFID, OPAQUE_MARKER).Data;
            foreach (XCourseType o in xCourseTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXCoursesByXRoster(XPress xPress)
        {
            List<XCourseType> xCourseTypeList = xPress.GetXCoursesByXRoster(ROSTER_REFID, OPAQUE_MARKER).Data;
            foreach (XCourseType o in xCourseTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }

        /* xRosters */
        public static void GetXRosters(XPress xPress)
        {
            List<XRosterType> xRosterTypeList = xPress.GetXRosters(OPAQUE_MARKER).Data;
            foreach (XRosterType o in xRosterTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXRostersByXLea(XPress xPress)
        {
            List<XRosterType> xRosterTypeList = xPress.GetXRostersByXLea(LEA_REFID, OPAQUE_MARKER).Data;
            foreach (XRosterType o in xRosterTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXRostersByXSchool(XPress xPress)
        {
            List<XRosterType> xRosterTypeList = xPress.GetXRostersByXSchool(SCHOOL_REFID, OPAQUE_MARKER).Data;
            foreach (XRosterType o in xRosterTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXRostersByXCourse(XPress xPress)
        {
            List<XRosterType> xRosterTypeList = xPress.GetXRostersByXCourse(COURSE_REFID, OPAQUE_MARKER).Data;
            foreach (XRosterType o in xRosterTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXRostersByXStaff(XPress xPress)
        {
            List<XRosterType> xRosterTypeList = xPress.GetXRostersByXStaff(STAFF_REFID, OPAQUE_MARKER).Data;
            foreach (XRosterType o in xRosterTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXRostersByXStudent(XPress xPress)
        {
            List<XRosterType> xRosterTypeList = xPress.GetXRostersByXStudent(STUDENT_REFID, OPAQUE_MARKER).Data;
            foreach (XRosterType o in xRosterTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.courseTitle + " | " + o.Metadata.SchoolYear);
            }
        }

        /* xStaffs */
        public static void GetXStaffs(XPress xPress)
        {
            List<XStaffType> xStaffTypeList = xPress.GetXStaffs(OPAQUE_MARKER).Data;
            foreach (XStaffType o in xStaffTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStaffsByXLea(XPress xPress)
        {
            List<XStaffType> xStaffTypeList = xPress.GetXStaffsByXLea(LEA_REFID, OPAQUE_MARKER).Data;
            foreach (XStaffType o in xStaffTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStaffsByXSchool(XPress xPress)
        {
            List<XStaffType> xStaffTypeList = xPress.GetXStaffsByXSchool(SCHOOL_REFID, OPAQUE_MARKER).Data;
            foreach (XStaffType o in xStaffTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStaffsByXCourse(XPress xPress)
        {
            List<XStaffType> xStaffTypeList = xPress.GetXStaffsByXCourse(COURSE_REFID, OPAQUE_MARKER).Data;
            foreach (XStaffType o in xStaffTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStaffsByXRoster(XPress xPress)
        {
            List<XStaffType> xStaffTypeList = xPress.GetXStaffsByXRoster(ROSTER_REFID, OPAQUE_MARKER).Data;
            foreach (XStaffType o in xStaffTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStaffsByXStudent(XPress xPress)
        {
            List<XStaffType> xStaffTypeList = xPress.GetXStaffsByXStudent(STUDENT_REFID, OPAQUE_MARKER).Data;
            foreach (XStaffType o in xStaffTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }

        /* xStudents */
        public static void GetXStudents(XPress xPress)
        {
            List<XStudentType> xStudentTypeList = xPress.GetXStudents(OPAQUE_MARKER).Data;
            foreach (XStudentType o in xStudentTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStudentsByXLea(XPress xPress)
        {
            List<XStudentType> xStudentTypeList = xPress.GetXStudentsByXLea(LEA_REFID, OPAQUE_MARKER).Data;
            foreach (XStudentType o in xStudentTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStudentsByXSchool(XPress xPress)
        {
            List<XStudentType> xStudentTypeList = xPress.GetXStudentsByXSchool(SCHOOL_REFID, OPAQUE_MARKER).Data;
            foreach (XStudentType o in xStudentTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStudentsByXRoster(XPress xPress)
        {
            List<XStudentType> xStudentTypeList = xPress.GetXStudentsByXRoster(ROSTER_REFID, OPAQUE_MARKER).Data;
            foreach (XStudentType o in xStudentTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStudentsByXStaff(XPress xPress)
        {
            List<XStudentType> xStudentTypeList = xPress.GetXStudentsByXStaff(STAFF_REFID, OPAQUE_MARKER).Data;
            foreach (XStudentType o in xStudentTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXStudentsByXContact(XPress xPress)
        {
            List<XStudentType> xStudentTypeList = xPress.GetXStudentsByXContact(CONTACT_REFID, OPAQUE_MARKER).Data;
            foreach (XStudentType o in xStudentTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }

        /* xContacts */
        public static void GetXContacts(XPress xPress)
        {
            List<XContactType> xContactTypeList = xPress.GetXContacts(OPAQUE_MARKER).Data;
            foreach (XContactType o in xContactTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXContactsByXLea(XPress xPress)
        {
            List<XContactType> xContactTypeList = xPress.GetXContactsByXLea(LEA_REFID, OPAQUE_MARKER).Data;
            foreach (XContactType o in xContactTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXContactsByXSchool(XPress xPress)
        {
            List<XContactType> xContactTypeList = xPress.GetXContactsByXSchool(SCHOOL_REFID, OPAQUE_MARKER).Data;
            foreach (XContactType o in xContactTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }
        public static void GetXContactsByXStudent(XPress xPress)
        {
            List<XContactType> xContactTypeList = xPress.GetXContactsByXStudent(STUDENT_REFID, OPAQUE_MARKER).Data;
            foreach (XContactType o in xContactTypeList)
            {
                Console.WriteLine(o.refId + " | " + o.Metadata.SchoolYear);
            }
        }        
    }
}
