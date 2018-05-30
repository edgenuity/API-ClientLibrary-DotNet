using System;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using System.Configuration;
using RicOneApi.Common.Objects;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6
 * Since       2018-05-23
 * Filename    Paging.cs
 */
namespace RicOneApi.Tests
{
    class Paging
    {
        #region Test Constants
        static string authUrl = ConfigurationManager.AppSettings["authUrl"];
        static string clientId = ConfigurationManager.AppSettings["authClientId"];
        static string clientSecret = ConfigurationManager.AppSettings["authClientSecret"];
        static string providerId = ConfigurationManager.AppSettings["authProviderId"];

        const int NAVIGATION_PAGE_SIZE = 1;

        const String LEA_REFID = "03ACF04F-DC12-411A-9A42-E8323516D699";
        const String SCHOOL_REFID = "AE6B3441-5E31-4573-BADB-081669D79C7F";
        const String CALENDAR_REFID = "C419EBD3-5EFC-449C-8890-28545663350F";
        const String COURSE_REFID = "50F2377E-29BD-45C6-950C-C41B3432FC0A";
        const String ROSTER_REFID = "00BAD4F5-9CF4-4D49-A8CC-666D02180300";
        const String STAFF_REFID = "0C6E7BFA-4E4E-4F82-BCE8-C27729A79F29";
        const String STUDENT_REFID = "3089EF6E-143D-4C58-ABF3-8CED68B7AEEE";
        const String CONTACT_REFID = "0BFFDDCF-B25C-423B-BC65-553DE0B95F4B";
        #endregion

        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);

            //Get endpoints by provider
            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(e.href);

                #region navigationLastPage
                XPress_LastPage_Counts(xPress);

                #region xLeas
                //XLeas_GetXLeasLastPage(xPress);
                //XLeas_GetXLeasByXSchoolLastPage(xPress);
                //XLeas_GetXLeasByXRosterLastPage(xPress);
                //XLeas_GetXLeasByXStaffLastPage(xPress);
                //XLeas_GetXLeasByXStudentLastPage(xPress);
                //XLeas_GetXLeasByXContactLastPage(xPress);
                #endregion

                #region xSchools
                //XSchools_GetXSchoolsLastPage(xPress);
                //XSchools_GetXSchoolsByXLeaLastPage(xPress);
                //XSchools_GetXSchoolsByXCalendarLastPage(xPress);
                //XSchools_GetXSchoolsByXCourseLastPage(xPress);
                //XSchools_GetXSchoolsByXRosterLastPage(xPress);
                //XSchools_GetXSchoolsByXStaffLastPage(xPress);
                //XSchools_GetXSchoolsByXStudentLastPage(xPress);
                //XSchools_GetXSchoolsByXContactLastPage(xPress);
                #endregion

                #region xCalendars
                //XCalendars_GetXCalendarsLastPage(xPress);
                //XCalendars_GetXCalendarsByXLeaLastPage(xPress);
                //XCalendars_GetXCalendarsByXSchoolLastPage(xPress);
                #endregion

                #region xCourses
                //XCourses_GetXCoursesLastPage(xPress);
                //XCourses_GetXCoursesByXLeaLastPage(xPress);
                //XCourses_GetXCoursesByXSchoolLastPage(xPress);
                //XCourses_GetXCoursesByXRosterLastPage(xPress);
                #endregion

                #region xRosters
                //XRosters_GetXRostersLastPage(xPress);
                //XRosters_GetXRostersByXLeaLastPage(xPress);
                //XRosters_GetXRostersByXSchoolLastPage(xPress);
                //XRosters_GetXRostersByXCourseLastPage(xPress);
                //XRosters_GetXRostersByXStaffLastPage(xPress);
                //XRosters_GetXRostersByXStudentLastPage(xPress);
                #endregion

                #region xStaffs
                //XStaffs_GetXStaffsLastPage(xPress);
                //XStaffs_GetXStaffsByXLeaLastPage(xPress);
                //XStaffs_GetXStaffsByXSchoolLastPage(xPress);
                //XStaffs_GetXStaffsByXCourseLastPage(xPress);
                //XStaffs_GetXStaffsByXRosterLastPage(xPress);
                //XStaffs_GetXStaffsByXStudentLastPage(xPress);
                #endregion

                #region xStudents
                //XStudents_GetXStudentsLastPage(xPress);
                //XStudents_GetXStudentsByXLeaLastPage(xPress);
                //XStudents_GetXStudentsByXSchoolLastPage(xPress);
                //XStudents_GetXStudentsByXRosterLastPage(xPress);
                //XStudents_GetXStudentsByXStaffLastPage(xPress);
                //XStudents_GetXStudentsByXContactLastPage(xPress);
                #endregion

                #region xContacts
                //XContacts_GetXContactsLastPage(xPress);
                //XContacts_GetXContactsByXLeaLastPage(xPress);
                //XContacts_GetXContactsByXSchoolLastPage(xPress);
                //XContacts_GetXContactsByXStudentLastPage(xPress);
                #endregion
                #endregion
            }

            Console.ReadLine();
        }

        #region navigationLastPage

        public static void XPress_LastPage_Counts(XPress xPress)
        {
            string format = "{0,-60}{1,0}";
            Console.WriteLine("NavigationPageSize: " + NAVIGATION_PAGE_SIZE);
            /* xLeas */
            Console.WriteLine(String.Format(format, "-----xLeas-----", "-----NavigationLastPage-----"));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXLeas)", xPress.GetLastPage(ServicePath.GetXLeas, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXLeasByXSchool, SCHOOL_REFID)", xPress.GetLastPage(ServicePath.GetXLeasByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXLeasByXRoster, ROSTER_REFID)", xPress.GetLastPage(ServicePath.GetXLeasByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXLeasByXStaff, STAFF_REFID)", xPress.GetLastPage(ServicePath.GetXLeasByXStaff, STAFF_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXLeasByXStudent, STUDENT_REFID)", xPress.GetLastPage(ServicePath.GetXLeasByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXLeasByXContact, CONTACT_REFID)", xPress.GetLastPage(ServicePath.GetXLeasByXContact, CONTACT_REFID, NAVIGATION_PAGE_SIZE)));
            
            /* xSchools */
            Console.WriteLine(String.Format(format, "-----xSchools-----", "-----NavigationLastPage-----"));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXSchools)", xPress.GetLastPage(ServicePath.GetXSchools, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXSchoolsByXLea, LEA_REFID)", xPress.GetLastPage(ServicePath.GetXSchoolsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXSchoolsByXCalendar, CALENDAR_REFID)", xPress.GetLastPage(ServicePath.GetXSchoolsByXCalendar, CALENDAR_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXSchoolsByXCourse, COURSE_REFID)", xPress.GetLastPage(ServicePath.GetXSchoolsByXCourse, COURSE_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXSchoolsByXRoster, ROSTER_REFID)", xPress.GetLastPage(ServicePath.GetXSchoolsByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXSchoolsByXStaff, STAFF_REFID)", xPress.GetLastPage(ServicePath.GetXSchoolsByXStaff, STAFF_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXSchoolsByXStudent, STUDENT_REFID)", xPress.GetLastPage(ServicePath.GetXSchoolsByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXSchoolsByXContact, CONTACT_REFID)", xPress.GetLastPage(ServicePath.GetXSchoolsByXContact, CONTACT_REFID, NAVIGATION_PAGE_SIZE)));

            /* xCalendars */
            Console.WriteLine(String.Format(format, "-----xCalendars-----", "-----NavigationLastPage-----"));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXCalendars)", xPress.GetLastPage(ServicePath.GetXCalendars, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXCalendarsByXLea, LEA_REFID)", xPress.GetLastPage(ServicePath.GetXCalendarsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXCalendarsByXSchool, SCHOOL_REFID)", xPress.GetLastPage(ServicePath.GetXCalendarsByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE)));

            /* xCourses */
            Console.WriteLine(String.Format(format, "-----xCourses-----", "-----NavigationLastPage-----"));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXCourses)", xPress.GetLastPage(ServicePath.GetXCourses, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXCoursesByXLea, LEA_REFID)", xPress.GetLastPage(ServicePath.GetXCoursesByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXCoursesByXSchool, SCHOOL_REFID)", xPress.GetLastPage(ServicePath.GetXCoursesByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXCoursesByXRoster, ROSTER_REFID)", xPress.GetLastPage(ServicePath.GetXCoursesByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE)));

            /* xRosters */
            Console.WriteLine(String.Format(format, "-----xRosters-----", "-----NavigationLastPage-----"));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXRosters)", xPress.GetLastPage(ServicePath.GetXRosters, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXRostersByXLea, LEA_REFID)", xPress.GetLastPage(ServicePath.GetXRostersByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXRostersByXSchool, SCHOOL_REFID)", xPress.GetLastPage(ServicePath.GetXRostersByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXRostersByXCourse, COURSE_REFID)", xPress.GetLastPage(ServicePath.GetXRostersByXCourse, COURSE_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXRostersByXStaff, STAFF_REFID)", xPress.GetLastPage(ServicePath.GetXRostersByXStaff, STAFF_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXRostersByXStudent, STUDENT_REFID)", xPress.GetLastPage(ServicePath.GetXRostersByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE)));

            /* xStaffs */
            Console.WriteLine(String.Format(format, "-----xStaffs-----", "-----NavigationLastPage-----"));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStaffs)", xPress.GetLastPage(ServicePath.GetXStaffs, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStaffsByXLea, LEA_REFID)", xPress.GetLastPage(ServicePath.GetXStaffsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStaffsByXSchool, SCHOOL_REFID)", xPress.GetLastPage(ServicePath.GetXStaffsByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStaffsByXCourse, COURSE_REFID)", xPress.GetLastPage(ServicePath.GetXStaffsByXCourse, COURSE_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStaffsByXRoster, ROSTER_REFID)", xPress.GetLastPage(ServicePath.GetXStaffsByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStaffsByXStudent, STUDENT_REFID)", xPress.GetLastPage(ServicePath.GetXStaffsByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE)));

            /* xStudents */
            Console.WriteLine(String.Format(format, "-----xStudents-----", "-----NavigationLastPage-----"));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStudents)", xPress.GetLastPage(ServicePath.GetXStudents, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStudentsByXLea, LEA_REFID)", xPress.GetLastPage(ServicePath.GetXStudentsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStudentsByXSchool, SCHOOL_REFID)", xPress.GetLastPage(ServicePath.GetXStudentsByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStudentsByXRoster, ROSTER_REFID)", xPress.GetLastPage(ServicePath.GetXStudentsByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStudentsByXStaff, STAFF_REFID)", xPress.GetLastPage(ServicePath.GetXStudentsByXStaff, STAFF_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXStudentsByXContact, CONTACT_REFID)", xPress.GetLastPage(ServicePath.GetXStudentsByXContact, CONTACT_REFID, NAVIGATION_PAGE_SIZE)));

            /* xContacts */
            Console.WriteLine(String.Format(format, "-----xContacts-----", "-----NavigationLastPage-----"));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXContacts)", xPress.GetLastPage(ServicePath.GetXContacts, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXContactsByXLea, LEA_REFID)", xPress.GetLastPage(ServicePath.GetXContactsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXContactsByXSchool, SCHOOL_REFID)", xPress.GetLastPage(ServicePath.GetXContactsByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE)));
            Console.WriteLine(String.Format(format, "GetLastPage(GetXContactsByXStudent, STUDENT_REFID)", xPress.GetLastPage(ServicePath.GetXContactsByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE)));
        }

        #region xLeas

        ////RETURN ALL LEAS
        public static void XLeas_GetXLeasLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXLeas, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XLeaType lea in xPress.GetXLeas(i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        ////RETURN LEAS BY SCHOOL
        public static void XLeas_GetXLeasByXSchoolLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXLeasByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXSchool(SCHOOL_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }

        }
        ////RETURN LEAS BY ROSTER
        public static void XLeas_GetXLeasByXRosterLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXLeasByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXRoster(ROSTER_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        ////RETURN LEAS BY STAFF
        public static void XLeas_GetXLeasByXStaffLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXLeasByXStaff, STAFF_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXStaff(STAFF_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        ////RETURN LEAS BY STUDENT
        public static void XLeas_GetXLeasByXStudentLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXLeasByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXStudent(STUDENT_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }

        }
        ////RETURN LEAS BY CONTACT
        public static void XLeas_GetXLeasByXContactLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXLeasByXContact, CONTACT_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXContact(CONTACT_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }

        }
        #endregion

        #region xSchools
        ////RETURN ALL SCHOOLS
        public static void XSchools_GetXSchoolsLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXSchools, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XSchoolType school in xPress.GetXSchools(i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }

        //RETURN SCHOOLS BY LEA
        public static void XSchools_GetXSchoolsByXLeaLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXSchoolsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XSchoolType school in xPress.GetXSchoolsByXLea(LEA_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN SCHOOLS BY CALENDAR
        public static void XSchools_GetXSchoolsByXCalendarLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXSchoolsByXCalendar, CALENDAR_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XSchoolType school in xPress.GetXSchoolsByXCalendar(CALENDAR_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN SCHOOLS BY COURSE
        public static void XSchools_GetXSchoolsByXCourseLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXSchoolsByXCourse, COURSE_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XSchoolType school in xPress.GetXSchoolsByXCourse(COURSE_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN SCHOOLS BY ROSTER
        public static void XSchools_GetXSchoolsByXRosterLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXSchoolsByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XSchoolType school in xPress.GetXSchoolsByXRoster(ROSTER_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN SCHOOLS BY STAFF
        public static void XSchools_GetXSchoolsByXStaffLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXSchoolsByXStaff, STAFF_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XSchoolType school in xPress.GetXSchoolsByXStaff(STAFF_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN SCHOOLS BY STUDENT
        public static void XSchools_GetXSchoolsByXStudentLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXSchoolsByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XSchoolType school in xPress.GetXSchoolsByXStudent(STUDENT_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN SCHOOLS BY CONTACT
        public static void XSchools_GetXSchoolsByXContactLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXSchoolsByXContact, CONTACT_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XSchoolType school in xPress.GetXSchoolsByXContact(CONTACT_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        #endregion

        #region xCalendars
        //RETURN ALL CALENDARS
        public static void XCalendars_GetXCalendarsLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXCalendars, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XCalendarType calendar in xPress.GetXCalendars(i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + calendar.refId);
                    Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
                    Console.WriteLine("schoolYear: " + calendar.schoolYear);
                    Console.WriteLine("##### BEGIN SESSIONLIST #####");
                    foreach (XSessionType sl in calendar.sessions.sessionList)
                    {
                        Console.WriteLine("sessionType: " + sl.sessionType);
                        Console.WriteLine("sessionCode: " + sl.sessionCode);
                        Console.WriteLine("description: " + sl.description);
                        Console.WriteLine("markingTerm: " + sl.markingTerm);
                        Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
                        Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
                        Console.WriteLine("startDate: " + sl.startDate);
                        Console.WriteLine("endDate: " + sl.endDate);
                    }
                    Console.WriteLine("##### END SESSIONLIST #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN CALENDARS BY LEA
        public static void XCalendars_GetXCalendarsByXLeaLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXCalendarsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XCalendarType calendar in xPress.GetXCalendarsByXLea(LEA_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + calendar.refId);
                    Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
                    Console.WriteLine("schoolYear: " + calendar.schoolYear);
                    Console.WriteLine("##### BEGIN SESSIONLIST #####");
                    foreach (XSessionType sl in calendar.sessions.sessionList)
                    {
                        Console.WriteLine("sessionType: " + sl.sessionType);
                        Console.WriteLine("sessionCode: " + sl.sessionCode);
                        Console.WriteLine("description: " + sl.description);
                        Console.WriteLine("markingTerm: " + sl.markingTerm);
                        Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
                        Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
                        Console.WriteLine("startDate: " + sl.startDate);
                        Console.WriteLine("endDate: " + sl.endDate);
                    }
                    Console.WriteLine("##### END SESSIONLIST #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN CALENDARS BY SCHOOL
        public static void XCalendars_GetXCalendarsByXSchoolLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXCalendarsByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XCalendarType calendar in xPress.GetXCalendarsByXSchool(SCHOOL_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + calendar.refId);
                    Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
                    Console.WriteLine("schoolYear: " + calendar.schoolYear);
                    Console.WriteLine("##### BEGIN SESSIONLIST #####");
                    foreach (XSessionType sl in calendar.sessions.sessionList)
                    {
                        Console.WriteLine("sessionType: " + sl.sessionType);
                        Console.WriteLine("sessionCode: " + sl.sessionCode);
                        Console.WriteLine("description: " + sl.description);
                        Console.WriteLine("markingTerm: " + sl.markingTerm);
                        Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
                        Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
                        Console.WriteLine("startDate: " + sl.startDate);
                        Console.WriteLine("endDate: " + sl.endDate);
                    }
                    Console.WriteLine("##### END SESSIONLIST #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        #endregion

        #region xCourses
        //RETURN ALL COURSES
        public static void XCourses_GetXCoursesLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXCourses, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XCourseType course in xPress.GetXCourses(i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + course.refId);
                    Console.WriteLine("schoolRefId: " + course.schoolRefId);
                    Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                    Console.WriteLine("leaCourseId: " + course.leaCourseId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherCourseIdType id in course.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("courseTitle: " + course.courseTitle);
                    Console.WriteLine("description: " + course.description);
                    Console.WriteLine("subject: " + course.subject);
                    Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
                    foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                    {
                        Console.WriteLine("applicableEducationLevel: " + ael);
                    }
                    Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                    Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                    Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                    Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }

        //RETURN COURSES BY LEA
        public static void XCourses_GetXCoursesByXLeaLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXCoursesByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XCourseType course in xPress.GetXCoursesByXLea(LEA_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + course.refId);
                    Console.WriteLine("schoolRefId: " + course.schoolRefId);
                    Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                    Console.WriteLine("leaCourseId: " + course.leaCourseId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherCourseIdType id in course.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("courseTitle: " + course.courseTitle);
                    Console.WriteLine("description: " + course.description);
                    Console.WriteLine("subject: " + course.subject);
                    Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
                    foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                    {
                        Console.WriteLine("applicableEducationLevel: " + ael);
                    }
                    Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                    Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                    Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                    Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN COURSES BY SCHOOL
        public static void XCourses_GetXCoursesByXSchoolLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXCoursesByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XCourseType course in xPress.GetXCoursesByXSchool(SCHOOL_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + course.refId);
                    Console.WriteLine("schoolRefId: " + course.schoolRefId);
                    Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                    Console.WriteLine("leaCourseId: " + course.leaCourseId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherCourseIdType id in course.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("courseTitle: " + course.courseTitle);
                    Console.WriteLine("description: " + course.description);
                    Console.WriteLine("subject: " + course.subject);
                    Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
                    foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                    {
                        Console.WriteLine("applicableEducationLevel: " + ael);
                    }
                    Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                    Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                    Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                    Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN COURSES BY ROSTER
        public static void XCourses_GetXCoursesByXRosterLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXCoursesByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XCourseType course in xPress.GetXCoursesByXRoster(ROSTER_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + course.refId);
                    Console.WriteLine("schoolRefId: " + course.schoolRefId);
                    Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                    Console.WriteLine("leaCourseId: " + course.leaCourseId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherCourseIdType id in course.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("courseTitle: " + course.courseTitle);
                    Console.WriteLine("description: " + course.description);
                    Console.WriteLine("subject: " + course.subject);
                    Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
                    foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                    {
                        Console.WriteLine("applicableEducationLevel: " + ael);
                    }
                    Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                    Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                    Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                    Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        #endregion

        #region xRosters
        //RETURN ALL ROSTERS
        public static void XRosters_GetXRostersLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXRosters, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XRosterType r in xPress.GetXRosters(i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);
                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("sessionCode: " + mt.sessionCode);
                        Console.WriteLine("schoolCalendarRefId: " + mt.schoolCalendarRefId);
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);
                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }

        //RETURN ROSTERS BY LEA
        public static void XRosters_GetXRostersByXLeaLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXRostersByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XRosterType r in xPress.GetXRostersByXLea(LEA_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("sessionCode: " + mt.sessionCode);
                        Console.WriteLine("schoolCalendarRefId: " + mt.schoolCalendarRefId);
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);
                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN ROSTERS BY SCHOOL
        public static void XRosters_GetXRostersByXSchoolLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXRostersByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XRosterType r in xPress.GetXRostersByXSchool(SCHOOL_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("sessionCode: " + mt.sessionCode);
                        Console.WriteLine("schoolCalendarRefId: " + mt.schoolCalendarRefId);
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);
                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN ROSTERS BY CROUSE
        public static void XRosters_GetXRostersByXCourseLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXRostersByXCourse, COURSE_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XRosterType r in xPress.GetXRostersByXCourse(COURSE_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("sessionCode: " + mt.sessionCode);
                        Console.WriteLine("schoolCalendarRefId: " + mt.schoolCalendarRefId);
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);
                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN ROSTERS BY STAFF
        public static void XRosters_GetXRostersByXStaffLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXRostersByXStaff, STAFF_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XRosterType r in xPress.GetXRostersByXStaff(STAFF_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("sessionCode: " + mt.sessionCode);
                        Console.WriteLine("schoolCalendarRefId: " + mt.schoolCalendarRefId);
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);
                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN ROSTERS BY STUDENT
        public static void XRosters_GetXRostersByXStudentLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXRostersByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XRosterType r in xPress.GetXRostersByXStudent(STUDENT_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("sessionCode: " + mt.sessionCode);
                        Console.WriteLine("schoolCalendarRefId: " + mt.schoolCalendarRefId);
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);
                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        #endregion

        #region xStaffs
        //RETURN ALL STAFFS
        public static void XStaffs_GetXStaffsLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStaffs, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStaffType s in xPress.GetXStaffs(i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }

        //RETURN STAFFS BY LEA
        public static void XStaffs_GetXStaffsByXLeaLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStaffsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStaffType s in xPress.GetXStaffsByXLea(LEA_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN STAFFS BY SCHOOL
        public static void XStaffs_GetXStaffsByXSchoolLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStaffsByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStaffType s in xPress.GetXStaffsByXSchool(SCHOOL_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN STAFFS BY COURSE
        public static void XStaffs_GetXStaffsByXCourseLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStaffsByXCourse, COURSE_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStaffType s in xPress.GetXStaffsByXCourse(COURSE_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN STAFFS BY ROSTER
        public static void XStaffs_GetXStaffsByXRosterLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStaffsByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStaffType s in xPress.GetXStaffsByXRoster(ROSTER_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN STAFFS BY STUDENT
        public static void XStaffs_GetXStaffsByXStudentLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStaffsByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStaffType s in xPress.GetXStaffsByXStudent(STUDENT_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        #endregion

        #region xStudents
        //RETURN ALL STUDENTS
        public static void XStudents_GetXStudentsLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStudents, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStudentType s in xPress.GetXStudents(i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    if (s.enrollment.entryType != null)
                    {
                        Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                        Console.WriteLine("entryCode: " + s.enrollment.entryType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.entryType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END ENTRYTYPE #####");
                    }
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    if (s.enrollment.exitType != null)
                    {
                        Console.WriteLine("##### BEGIN EXITTYPE #####");
                        Console.WriteLine("exitCode: " + s.enrollment.exitType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.exitType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END EXITTYPE #####");
                    }
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        if (e.entryType != null)
                        {
                            Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                            Console.WriteLine("entryCode: " + e.entryType.code);
                            foreach (XOtherCodeType oct in e.entryType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END ENTRYTYPE #####");
                        }
                        Console.WriteLine("exitDate: " + e.exitDate);
                        if (e.exitType != null)
                        {
                            Console.WriteLine("##### BEGIN EXITTYPE #####");
                            Console.WriteLine("exitCode: " + e.exitType.code);
                            foreach (XOtherCodeType oct in e.exitType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END EXITTYPE #####");
                        }
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }

        //RETURN STUDENTS BY LEA
        public static void XStudents_GetXStudentsByXLeaLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStudentsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStudentType s in xPress.GetXStudentsByXLea(LEA_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    if (s.enrollment.entryType != null)
                    {
                        Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                        Console.WriteLine("entryCode: " + s.enrollment.entryType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.entryType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END ENTRYTYPE #####");
                    }
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    if (s.enrollment.exitType != null)
                    {
                        Console.WriteLine("##### BEGIN EXITTYPE #####");
                        Console.WriteLine("exitCode: " + s.enrollment.exitType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.exitType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END EXITTYPE #####");
                    }
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        if (e.entryType != null)
                        {
                            Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                            Console.WriteLine("entryCode: " + e.entryType.code);
                            foreach (XOtherCodeType oct in e.entryType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END ENTRYTYPE #####");
                        }
                        Console.WriteLine("exitDate: " + e.exitDate);
                        if (e.exitType != null)
                        {
                            Console.WriteLine("##### BEGIN EXITTYPE #####");
                            Console.WriteLine("exitCode: " + e.exitType.code);
                            foreach (XOtherCodeType oct in e.exitType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END EXITTYPE #####");
                        }
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN STUDENTS BY SCHOOL
        public static void XStudents_GetXStudentsByXSchoolLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStudentsByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStudentType s in xPress.GetXStudentsByXSchool(SCHOOL_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    if (s.enrollment.entryType != null)
                    {
                        Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                        Console.WriteLine("entryCode: " + s.enrollment.entryType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.entryType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END ENTRYTYPE #####");
                    }
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    if (s.enrollment.exitType != null)
                    {
                        Console.WriteLine("##### BEGIN EXITTYPE #####");
                        Console.WriteLine("exitCode: " + s.enrollment.exitType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.exitType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END EXITTYPE #####");
                    }
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        if (e.entryType != null)
                        {
                            Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                            Console.WriteLine("entryCode: " + e.entryType.code);
                            foreach (XOtherCodeType oct in e.entryType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END ENTRYTYPE #####");
                        }
                        Console.WriteLine("exitDate: " + e.exitDate);
                        if (e.exitType != null)
                        {
                            Console.WriteLine("##### BEGIN EXITTYPE #####");
                            Console.WriteLine("exitCode: " + e.exitType.code);
                            foreach (XOtherCodeType oct in e.exitType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END EXITTYPE #####");
                        }
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN STUDENTS BY ROSTER
        public static void XStudents_GetXStudentsByXRosterLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStudentsByXRoster, ROSTER_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStudentType s in xPress.GetXStudentsByXRoster(ROSTER_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    if (s.enrollment.entryType != null)
                    {
                        Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                        Console.WriteLine("entryCode: " + s.enrollment.entryType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.entryType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END ENTRYTYPE #####");
                    }
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    if (s.enrollment.exitType != null)
                    {
                        Console.WriteLine("##### BEGIN EXITTYPE #####");
                        Console.WriteLine("exitCode: " + s.enrollment.exitType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.exitType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END EXITTYPE #####");
                    }
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        if (e.entryType != null)
                        {
                            Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                            Console.WriteLine("entryCode: " + e.entryType.code);
                            foreach (XOtherCodeType oct in e.entryType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END ENTRYTYPE #####");
                        }
                        Console.WriteLine("exitDate: " + e.exitDate);
                        if (e.exitType != null)
                        {
                            Console.WriteLine("##### BEGIN EXITTYPE #####");
                            Console.WriteLine("exitCode: " + e.exitType.code);
                            foreach (XOtherCodeType oct in e.exitType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END EXITTYPE #####");
                        }
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN STUDENTS BY STAFF
        public static void XStudents_GetXStudentsByXStaffLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStudentsByXStaff, STAFF_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStudentType s in xPress.GetXStudentsByXStaff(STAFF_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    if (s.enrollment.entryType != null)
                    {
                        Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                        Console.WriteLine("entryCode: " + s.enrollment.entryType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.entryType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END ENTRYTYPE #####");
                    }
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    if (s.enrollment.exitType != null)
                    {
                        Console.WriteLine("##### BEGIN EXITTYPE #####");
                        Console.WriteLine("exitCode: " + s.enrollment.exitType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.exitType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END EXITTYPE #####");
                    }
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        if (e.entryType != null)
                        {
                            Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                            Console.WriteLine("entryCode: " + e.entryType.code);
                            foreach (XOtherCodeType oct in e.entryType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END ENTRYTYPE #####");
                        }
                        Console.WriteLine("exitDate: " + e.exitDate);
                        if (e.exitType != null)
                        {
                            Console.WriteLine("##### BEGIN EXITTYPE #####");
                            Console.WriteLine("exitCode: " + e.exitType.code);
                            foreach (XOtherCodeType oct in e.exitType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END EXITTYPE #####");
                        }
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN STUDENTS BY CONTACT
        public static void XStudents_GetXStudentsByXContactLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXStudentsByXContact, CONTACT_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XStudentType s in xPress.GetXStudentsByXContact(CONTACT_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    if (s.enrollment.entryType != null)
                    {
                        Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                        Console.WriteLine("entryCode: " + s.enrollment.entryType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.entryType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END ENTRYTYPE #####");
                    }
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    if (s.enrollment.exitType != null)
                    {
                        Console.WriteLine("##### BEGIN EXITTYPE #####");
                        Console.WriteLine("exitCode: " + s.enrollment.exitType.code);
                        foreach (XOtherCodeType otherCodeType in s.enrollment.exitType.otherCode)
                        {
                            Console.WriteLine("otherCodesetName: " + otherCodeType.codesetName);
                            Console.WriteLine("otherCodeValue" + otherCodeType.otherCodeValue);
                        }
                        Console.WriteLine("##### END EXITTYPE #####");
                    }
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        if (e.entryType != null)
                        {
                            Console.WriteLine("##### BEGIN ENTRYTYPE #####");
                            Console.WriteLine("entryCode: " + e.entryType.code);
                            foreach (XOtherCodeType oct in e.entryType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END ENTRYTYPE #####");
                        }
                        Console.WriteLine("exitDate: " + e.exitDate);
                        if (e.exitType != null)
                        {
                            Console.WriteLine("##### BEGIN EXITTYPE #####");
                            Console.WriteLine("exitCode: " + e.exitType.code);
                            foreach (XOtherCodeType oct in e.exitType.otherCode)
                            {
                                Console.WriteLine("otherCodesetName: " + oct.codesetName);
                                Console.WriteLine("otherCodeValue" + oct.otherCodeValue);
                            }
                            Console.WriteLine("##### END EXITTYPE #####");
                        }
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        #endregion

        #region xContacts
        //RETURN ALL CONTACTS
        public static void XContacts_GetXContactsLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXContacts, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XContactType c in xPress.GetXContacts(i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + c.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + c.localId);

                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("sex: " + c.sex);
                    Console.WriteLine("employerType: " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }

        //RETURN CONTACTS BY LEA
        public static void XContacts_GetXContactsByXLeaLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXContactsByXLea, LEA_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XContactType c in xPress.GetXContactsByXLea(LEA_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + c.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + c.localId);

                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("sex: " + c.sex);
                    Console.WriteLine("employerType: " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN CONTACTS BY SCHOOL
        public static void XContacts_GetXContactsByXSchoolLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXContactsByXSchool, SCHOOL_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XContactType c in xPress.GetXContactsByXSchool(SCHOOL_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + c.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + c.localId);

                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("sex: " + c.sex);
                    Console.WriteLine("employerType: " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        //RETURN CONTACTS BY STUDENT
        public static void XContacts_GetXContactsByXStudentLastPage(XPress xPress)
        {
            for (int i = 1; i <= xPress.GetLastPage(ServicePath.GetXContactsByXStudent, STUDENT_REFID, NAVIGATION_PAGE_SIZE); i++)
            {
                foreach (XContactType c in xPress.GetXContactsByXStudent(STUDENT_REFID, i, NAVIGATION_PAGE_SIZE).Data)
                {
                    Console.WriteLine("refId: " + c.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + c.localId);

                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("sex: " + c.sex);
                    Console.WriteLine("employerType: " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    Console.WriteLine("========================================");
                }
                Console.WriteLine("######## PAGE " + i + " ########");
            }
        }
        #endregion
        #endregion
    }
}
