/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.4
 * Since       2016-09-12
 * Filename    Program.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Net;
using System.Net.Security;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using System.Configuration;

namespace RicOneApi.Tests
{
    class Program
    {
        #region Test Constants
        static string authUrl = ConfigurationManager.AppSettings["authUrl"];
        static string clientId = ConfigurationManager.AppSettings["authClientId"];
        static string clientSecret = ConfigurationManager.AppSettings["authClientSecret"];
        static string providerId = ConfigurationManager.AppSettings["authProviderId"];
        //static string token = ConfigurationManager.AppSettings["authToken"];

        const String LEA_REFID = "03ACF04F-DC12-411A-9A42-E8323516D699";
        const String LEA_BEDSIDTYPE = "beds";
        const String LEA_BEDSID = "530501060000";
        const String LEA_LOCALIDTYPE = "local";
        const String LEA_LOCALID = "530501";
        const String SCHOOL_REFID = "AE6B3441-5E31-4573-BADB-081669D79C7F";
        const String SCHOOL_BEDSIDTYPE = "BEDS";
        const String SCHOOL_BEDSID = "530501060004";
        const String SCHOOL_LOCALIDTYPE = "local";
        const String SCHOOL_LOCALID = "shm";
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

                XPress_StatusCodes(xPress);

                #region xLeas
                //XLeas_GetXLeas(xPress);
                //XLeas_GetXLea(xPress);
                //XLeas_GetXLeasByXSchool(xPress);
                //XLeas_GetXLeasByXRoster(xPress);
                //XLeas_GetXLeasByXStaff(xPress);
                //XLeas_GetXLeasByXStudent(xPress);
                //XLeas_GetXLeasByXContact(xPress);
                #endregion

                #region xSchools
                //XSchools_GetXSchools(xPress);
                //XSchools_GetXSchool(xPress);
                //XSchools_GetXSchoolsByXLea(xPress);
                //XSchools_GetXSchoolsByXCalendar(xPress);
                //XSchools_GetXSchoolsByXCourse(xPress);
                //XSchools_GetXSchoolsByXRoster(xPress);
                //XSchools_GetXSchoolsByXStaff(xPress);
                //XSchools_GetXSchoolsByXStudent(xPress);
                //XSchools_GetXSchoolsByXContact(xPress);
                #endregion

                #region xCalendars

                //XCalendars_GetXCalendars(xPress);
                //XCalendars_GetXCalendar(xPress);
                //XCalendars_GetXCalendarsByXLea(xPress); 
                //XCalendars_GetXCalendarsByXSchool(xPress);

                #endregion

                #region xCourses

                //XCourses_GetXCourses(xPress);
                //XCourses_GetXCourse(xPress);
                //XCourses_GetXCoursesByXLea(xPress);
                //XCourses_GetXCoursesByXSchool(xPress);
                //XCourses_GetXCoursesByXRoster(xPress);

                #endregion

                #region xRosters

                //XRosters_GetXRosters(xPress);
                //XRosters_GetXRoster(xPress);
                //XRosters_GetXRostersByXLea(xPress);
                //XRosters_GetXRostersByXSchool(xPress);
                //XRosters_GetXRostersByXCourse(xPress);
                //XRosters_GetXRostersByXStaff(xPress);
                //XRosters_GetXRostersByXStudent(xPress);

                #endregion

                #region xStaffs
                //XStaffs_GetXStaffs(xPress);
                //XStaffs_GetXStaff(xPress);
                //XStaffs_GetXStaffsByXLea(xPress);
                //XStaffs_GetXStaffsByXSchool(xPress);
                //XStaffs_GetXStaffsByXCourse(xPress);
                //XStaffs_GetXStaffsByXRoster(xPress);
                //XStaffs_GetXStaffsByXStudent(xPress);
                #endregion

                #region xStudents
                //XStudents_GetXStudents(xPress);
                //XStudents_GetXStudent(xPress);
                //XStudents_GetXStudentsByXLea(xPress);
                //XStudents_GetXStudentsByXSchool(xPress);
                //XStudents_GetXStudentsByXRoster(xPress);
                //XStudents_GetXStudentsByXStaff(xPress);
                //XStudents_GetXStudentsByXContact(xPress);
                #endregion

                #region xContacts
                //XContacts_GetXContacts(xPress);
                //XContacts_GetXContact(xPress);
                //XContacts_GetXContactsByXLea(xPress);
                //XContacts_GetXContactsByXSchool(xPress);
                //XContacts_GetXContactsByXStudent(xPress);
                #endregion
            }

            Console.ReadLine();
        }

        public static void XPress_StatusCodes(XPress xPress)
        {
            string format = "{0,-20} {1,10}";
            
            /* xLeas */
            Console.WriteLine("-----xLeas-----");
            Console.WriteLine(format, "GetXLeas()", xPress.GetXLeas().StatusCode);
            Console.WriteLine(format, "GetXLea(LEA_REFID)", xPress.GetXLea(LEA_REFID).StatusCode);
            Console.WriteLine(format, "GetXLea(LEA_BEDSIDTYPE, LEA_BEDSID)", xPress.GetXLea(LEA_BEDSIDTYPE, LEA_BEDSID).StatusCode);
            Console.WriteLine(format, "GetXLea(LEA_LOCALIDTYPE, LEA_LOCALID)", xPress.GetXLea(LEA_LOCALIDTYPE, LEA_LOCALID).StatusCode);
            Console.WriteLine(format, "GetXLeasByXSchool(SCHOOL_REFID)", xPress.GetXLeasByXSchool(SCHOOL_REFID).StatusCode);
            Console.WriteLine(format, "GetXLeasByXRoster(ROSTER_REFID", xPress.GetXLeasByXRoster(ROSTER_REFID).StatusCode);
            Console.WriteLine(format, "GetXLeasByXStaff(STAFF_REFID)", xPress.GetXLeasByXStaff(STAFF_REFID).StatusCode);
            Console.WriteLine(format, "GetXLeasByXStudent(STUDENT_REFID)", xPress.GetXLeasByXStudent(STUDENT_REFID).StatusCode);
            Console.WriteLine(format, "GetXLeasByXContact(CONTACT_REFID)", xPress.GetXLeasByXContact(CONTACT_REFID).StatusCode);
        }

        #region xLeas

        //RETURN ALL LEAS
        public static void XLeas_GetXLeas(XPress xPress)
        {
            if (xPress.GetXLeas().Data != null)
            {
                foreach (XLeaType lea in xPress.GetXLeas().Data)
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
            }
        }
        //RETURN SINGLE LEA
        public static void XLeas_GetXLea(XPress xPress)
        {
            if (xPress.GetXLea(LEA_REFID).Data != null)
            {
                XLeaType lea = xPress.GetXLea(LEA_REFID).Data;

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
        }
        //RETURN LEAS BY SCHOOL
        public static void XLeas_GetXLeasByXSchool(XPress xPress)
        {
            if (xPress.GetXLeasByXSchool(SCHOOL_REFID).Data != null)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXSchool(SCHOOL_REFID).Data)
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
            }
        }
        //RETURN LEAS BY ROSTER
        public static void XLeas_GetXLeasByXRoster(XPress xPress)
        {
            if (xPress.GetXLeasByXRoster(ROSTER_REFID) != null)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXRoster(ROSTER_REFID).Data)
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
            }
        }
        //RETURN LEAS BY STAFF
        public static void XLeas_GetXLeasByXStaff(XPress xPress)
        {
            if (xPress.GetXLeasByXStaff(STAFF_REFID) != null)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXStaff(STAFF_REFID).Data)
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
            }
        }
        //RETURN LEAS BY STUDENT
        public static void XLeas_GetXLeasByXStudent(XPress xPress)
        {
            if (xPress.GetXLeasByXStudent(STUDENT_REFID).Data != null)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXStudent(STUDENT_REFID).Data)
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
            }
        }
        //RETURN LEAS BY CONTACT
        public static void XLeas_GetXLeasByXContact(XPress xPress)
        {
            if (xPress.GetXLeasByXContact(CONTACT_REFID) != null)
            {
                foreach (XLeaType lea in xPress.GetXLeasByXContact(CONTACT_REFID).Data)
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
            }
        }

        #endregion

        //#region xSchools
        ////RETURN ALL SCHOOLS
        //public static void XSchools_GetXSchools(XPress xPress)
        //{
        //    if (xPress.GetXSchools().Data != null)
        //    {
        //        foreach (XSchoolType school in xPress.GetXSchools().Data)
        //        {
        //            Console.WriteLine("refId: " + school.refId);
        //            Console.WriteLine("leaRefId: " + school.leaRefId);
        //            Console.WriteLine("localId: " + school.localId);
        //            Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("schoolName: " + school.schoolName);
        //            Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //            foreach (String gl in school.gradeLevels.gradeLevel)
        //            {
        //                Console.WriteLine("gradeLevel: " + gl);
        //            }
        //            Console.WriteLine("##### END GRADELEVELS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + school.address.addressType);
        //            Console.WriteLine("city: " + school.address.city);
        //            Console.WriteLine("line1: " + school.address.line1);
        //            Console.WriteLine("line2: " + school.address.line2);
        //            Console.WriteLine("countryCode: " + school.address.countryCode);
        //            Console.WriteLine("postalCode: " + school.address.postalCode);
        //            Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + school.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SINGLE SCHOOL
        //public static void XSchools_GetXSchool(XPress xPress)
        //{
        //    if (xPress.GetXSchool(refId).Data != null)
        //    {
        //        XSchoolType school = xPress.GetXSchool(refId).Data;

        //        Console.WriteLine("refId: " + school.refId);
        //        Console.WriteLine("leaRefId: " + school.leaRefId);
        //        Console.WriteLine("localId: " + school.localId);
        //        Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //        Console.WriteLine("##### BEGIN OTHERIDS #####");
        //        foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //        {
        //            Console.WriteLine("otherId id" + id.id);
        //            Console.WriteLine("type: " + id.type);
        //        }
        //        Console.WriteLine("##### END OTHERIDS #####");
        //        Console.WriteLine("schoolName: " + school.schoolName);
        //        Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //        foreach (String gl in school.gradeLevels.gradeLevel)
        //        {
        //            Console.WriteLine("gradeLevel: " + gl);
        //        }
        //        Console.WriteLine("##### END GRADELEVELS #####");
        //        Console.WriteLine("##### BEGIN ADDRESS #####");
        //        Console.WriteLine("addressType: " + school.address.addressType);
        //        Console.WriteLine("city: " + school.address.city);
        //        Console.WriteLine("line1: " + school.address.line1);
        //        Console.WriteLine("line2: " + school.address.line2);
        //        Console.WriteLine("countryCode: " + school.address.countryCode);
        //        Console.WriteLine("postalCode: " + school.address.postalCode);
        //        Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //        Console.WriteLine("##### END ADDRESS #####");
        //        Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //        Console.WriteLine("number: " + school.phoneNumber.number);
        //        Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //        Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //        Console.WriteLine("##### END PHONENUMBER #####");
        //        Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //        foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //        {
        //            Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //        }
        //        Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //        Console.WriteLine("========================================");
        //    }

        //}
        ////RETURN SCHOOLS BY LEA
        //public static void XSchools_GetXSchoolsByXLea(XPress xPress)
        //{
        //    if (xPress.GetXSchoolsByXLea(LEA_REFID).Data != null)
        //    {
        //        foreach (XSchoolType school in xPress.GetXSchoolsByXLea(LEA_REFID).Data)
        //        {
        //            Console.WriteLine("refId: " + school.refId);
        //            Console.WriteLine("leaRefId: " + school.leaRefId);
        //            Console.WriteLine("localId: " + school.localId);
        //            Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("schoolName: " + school.schoolName);
        //            Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //            foreach (String gl in school.gradeLevels.gradeLevel)
        //            {
        //                Console.WriteLine("gradeLevel: " + gl);
        //            }
        //            Console.WriteLine("##### END GRADELEVELS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + school.address.addressType);
        //            Console.WriteLine("city: " + school.address.city);
        //            Console.WriteLine("line1: " + school.address.line1);
        //            Console.WriteLine("line2: " + school.address.line2);
        //            Console.WriteLine("countryCode: " + school.address.countryCode);
        //            Console.WriteLine("postalCode: " + school.address.postalCode);
        //            Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + school.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SCHOOLS BY CALENDAR
        //public static void XSchools_GetXSchoolsByXCalendar(XPress xPress)
        //{
        //    if (xPress.GetXSchoolsByXCalendar(refId) != null)
        //    {
        //        foreach (XSchoolType school in xPress.GetXSchoolsByXCalendar(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + school.refId);
        //            Console.WriteLine("leaRefId: " + school.leaRefId);
        //            Console.WriteLine("localId: " + school.localId);
        //            Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("schoolName: " + school.schoolName);
        //            Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //            foreach (String gl in school.gradeLevels.gradeLevel)
        //            {
        //                Console.WriteLine("gradeLevel: " + gl);
        //            }
        //            Console.WriteLine("##### END GRADELEVELS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + school.address.addressType);
        //            Console.WriteLine("city: " + school.address.city);
        //            Console.WriteLine("line1: " + school.address.line1);
        //            Console.WriteLine("line2: " + school.address.line2);
        //            Console.WriteLine("countryCode: " + school.address.countryCode);
        //            Console.WriteLine("postalCode: " + school.address.postalCode);
        //            Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + school.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SCHOOLS BY COURSE
        //public static void XSchools_GetXSchoolsByXCourse(XPress xPress)
        //{
        //    if (xPress.GetXSchoolsByXCourse(refId).Data != null)
        //    {
        //        foreach (XSchoolType school in xPress.GetXSchoolsByXCourse(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + school.refId);
        //            Console.WriteLine("leaRefId: " + school.leaRefId);
        //            Console.WriteLine("localId: " + school.localId);
        //            Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("schoolName: " + school.schoolName);
        //            Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //            foreach (String gl in school.gradeLevels.gradeLevel)
        //            {
        //                Console.WriteLine("gradeLevel: " + gl);
        //            }
        //            Console.WriteLine("##### END GRADELEVELS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + school.address.addressType);
        //            Console.WriteLine("city: " + school.address.city);
        //            Console.WriteLine("line1: " + school.address.line1);
        //            Console.WriteLine("line2: " + school.address.line2);
        //            Console.WriteLine("countryCode: " + school.address.countryCode);
        //            Console.WriteLine("postalCode: " + school.address.postalCode);
        //            Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + school.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SCHOOLS BY ROSTER
        //public static void XSchools_GetXSchoolsByXRoster(XPress xPress)
        //{
        //    if (xPress.GetXSchoolsByXRoster(refId).Data != null)
        //    {
        //        foreach (XSchoolType school in xPress.GetXSchoolsByXRoster(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + school.refId);
        //            Console.WriteLine("leaRefId: " + school.leaRefId);
        //            Console.WriteLine("localId: " + school.localId);
        //            Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("schoolName: " + school.schoolName);
        //            Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //            foreach (String gl in school.gradeLevels.gradeLevel)
        //            {
        //                Console.WriteLine("gradeLevel: " + gl);
        //            }
        //            Console.WriteLine("##### END GRADELEVELS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + school.address.addressType);
        //            Console.WriteLine("city: " + school.address.city);
        //            Console.WriteLine("line1: " + school.address.line1);
        //            Console.WriteLine("line2: " + school.address.line2);
        //            Console.WriteLine("countryCode: " + school.address.countryCode);
        //            Console.WriteLine("postalCode: " + school.address.postalCode);
        //            Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + school.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SCHOOLS BY STAFF
        //public static void XSchools_GetXSchoolsByXStaff(XPress xPress)
        //{
        //    if (xPress.GetXSchoolsByXStaff(refId).Data != null)
        //    {
        //        foreach (XSchoolType school in xPress.GetXSchoolsByXStaff(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + school.refId);
        //            Console.WriteLine("leaRefId: " + school.leaRefId);
        //            Console.WriteLine("localId: " + school.localId);
        //            Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("schoolName: " + school.schoolName);
        //            Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //            foreach (String gl in school.gradeLevels.gradeLevel)
        //            {
        //                Console.WriteLine("gradeLevel: " + gl);
        //            }
        //            Console.WriteLine("##### END GRADELEVELS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + school.address.addressType);
        //            Console.WriteLine("city: " + school.address.city);
        //            Console.WriteLine("line1: " + school.address.line1);
        //            Console.WriteLine("line2: " + school.address.line2);
        //            Console.WriteLine("countryCode: " + school.address.countryCode);
        //            Console.WriteLine("postalCode: " + school.address.postalCode);
        //            Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + school.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SCHOOLS BY STUDENT
        //public static void XSchools_GetXSchoolsByXStudent(XPress xPress)
        //{
        //    if (xPress.GetXSchoolsByXStudent(refId).Data != null)
        //    {
        //        foreach (XSchoolType school in xPress.GetXSchoolsByXStudent(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + school.refId);
        //            Console.WriteLine("leaRefId: " + school.leaRefId);
        //            Console.WriteLine("localId: " + school.localId);
        //            Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("schoolName: " + school.schoolName);
        //            Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //            foreach (String gl in school.gradeLevels.gradeLevel)
        //            {
        //                Console.WriteLine("gradeLevel: " + gl);
        //            }
        //            Console.WriteLine("##### END GRADELEVELS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + school.address.addressType);
        //            Console.WriteLine("city: " + school.address.city);
        //            Console.WriteLine("line1: " + school.address.line1);
        //            Console.WriteLine("line2: " + school.address.line2);
        //            Console.WriteLine("countryCode: " + school.address.countryCode);
        //            Console.WriteLine("postalCode: " + school.address.postalCode);
        //            Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + school.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SCHOOLS BY CONTACT
        //public static void XSchools_GetXSchoolsByXContact(XPress xPress)
        //{
        //    if (xPress.GetXSchoolsByXContact(refId).Data != null)
        //    {
        //        foreach (XSchoolType school in xPress.GetXSchoolsByXContact(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + school.refId);
        //            Console.WriteLine("leaRefId: " + school.leaRefId);
        //            Console.WriteLine("localId: " + school.localId);
        //            Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("schoolName: " + school.schoolName);
        //            Console.WriteLine("##### BEGIN GRADELEVELS #####");
        //            foreach (String gl in school.gradeLevels.gradeLevel)
        //            {
        //                Console.WriteLine("gradeLevel: " + gl);
        //            }
        //            Console.WriteLine("##### END GRADELEVELS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + school.address.addressType);
        //            Console.WriteLine("city: " + school.address.city);
        //            Console.WriteLine("line1: " + school.address.line1);
        //            Console.WriteLine("line2: " + school.address.line2);
        //            Console.WriteLine("countryCode: " + school.address.countryCode);
        //            Console.WriteLine("postalCode: " + school.address.postalCode);
        //            Console.WriteLine("stateProvince: " + school.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + school.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        //#endregion

        //#region xCalendars
        ////RETURN ALL CALENDARS
        //public static void XCalendars_GetXCalendars(XPress xPress)
        //{
        //    if (xPress.GetXCalendars().Data != null)
        //    {
        //        foreach (XCalendarType calendar in xPress.GetXCalendars().Data)
        //        {
        //            Console.WriteLine("refId: " + calendar.refId);
        //            Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
        //            Console.WriteLine("schoolYear: " + calendar.schoolYear);
        //            Console.WriteLine("##### BEGIN SESSIONLIST #####");
        //            foreach (XSessionType sl in calendar.sessions.sessionList)
        //            {
        //                Console.WriteLine("sessionType: " + sl.sessionType);
        //                Console.WriteLine("sessionCode: " + sl.sessionCode);
        //                Console.WriteLine("description: " + sl.description);
        //                Console.WriteLine("markingTerm: " + sl.markingTerm);
        //                Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
        //                Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
        //                Console.WriteLine("startDate: " + sl.startDate);
        //                Console.WriteLine("endDate: " + sl.endDate);
        //            }
        //            Console.WriteLine("##### END SESSIONLIST #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SINGLE CALENDAR
        //public static void XCalendars_GetXCalendar(XPress xPress)
        //{
        //    if (xPress.GetXCalendar(refId).Data != null)
        //    {
        //        XCalendarType calendar = xPress.GetXCalendar(refId).Data;

        //        Console.WriteLine("refId: " + calendar.refId);
        //        Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
        //        Console.WriteLine("schoolYear: " + calendar.schoolYear);
        //        Console.WriteLine("##### BEGIN SESSIONLIST #####");
        //        foreach (XSessionType sl in calendar.sessions.sessionList)
        //        {
        //            Console.WriteLine("sessionType: " + sl.sessionType);
        //            Console.WriteLine("sessionCode: " + sl.sessionCode);
        //            Console.WriteLine("description: " + sl.description);
        //            Console.WriteLine("markingTerm: " + sl.markingTerm);
        //            Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
        //            Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
        //            Console.WriteLine("startDate: " + sl.startDate);
        //            Console.WriteLine("endDate: " + sl.endDate);
        //        }
        //        Console.WriteLine("##### END SESSIONLIST #####");
        //        Console.WriteLine("========================================");
        //    }
        //}
        ////RETURN CALENDARS BY LEA
        //public static void XCalendars_GetXCalendarsByXLea(XPress xPress)
        //{
        //    if (xPress.GetXCalendarsByXLea(LEA_REFID).Data != null)
        //    {
        //        foreach (XCalendarType calendar in xPress.GetXCalendarsByXLea(LEA_REFID).Data)
        //        {
        //            Console.WriteLine("refId: " + calendar.refId);
        //            Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
        //            Console.WriteLine("schoolYear: " + calendar.schoolYear);
        //            Console.WriteLine("##### BEGIN SESSIONLIST #####");
        //            foreach (XSessionType sl in calendar.sessions.sessionList)
        //            {
        //                Console.WriteLine("sessionType: " + sl.sessionType);
        //                Console.WriteLine("sessionCode: " + sl.sessionCode);
        //                Console.WriteLine("description: " + sl.description);
        //                Console.WriteLine("markingTerm: " + sl.markingTerm);
        //                Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
        //                Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
        //                Console.WriteLine("startDate: " + sl.startDate);
        //                Console.WriteLine("endDate: " + sl.endDate);
        //            }
        //            Console.WriteLine("##### END SESSIONLIST #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN CALENDARS BY SCHOOL
        //public static void XCalendars_GetXCalendarsByXSchool(XPress xPress)
        //{
        //    if (xPress.GetXCalendarsByXSchool(refId).Data != null)
        //    {
        //        foreach (XCalendarType calendar in xPress.GetXCalendarsByXSchool(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + calendar.refId);
        //            Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
        //            Console.WriteLine("schoolYear: " + calendar.schoolYear);
        //            Console.WriteLine("##### BEGIN SESSIONLIST #####");
        //            foreach (XSessionType sl in calendar.sessions.sessionList)
        //            {
        //                Console.WriteLine("sessionType: " + sl.sessionType);
        //                Console.WriteLine("sessionCode: " + sl.sessionCode);
        //                Console.WriteLine("description: " + sl.description);
        //                Console.WriteLine("markingTerm: " + sl.markingTerm);
        //                Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
        //                Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
        //                Console.WriteLine("startDate: " + sl.startDate);
        //                Console.WriteLine("endDate: " + sl.endDate);
        //            }
        //            Console.WriteLine("##### END SESSIONLIST #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        //#endregion

        //#region xCourses
        ////RETURN ALL COURSES
        //public static void XCourses_GetXCourses(XPress xPress)
        //{
        //    if (xPress.GetXCourses().Data != null)
        //    {
        //        foreach (XCourseType course in xPress.GetXCourses().Data)
        //        {
        //            Console.WriteLine("refId: " + course.refId);
        //            Console.WriteLine("schoolRefId: " + course.schoolRefId);
        //            Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
        //            Console.WriteLine("leaCourseId: " + course.leaCourseId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherCourseIdType id in course.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("courseTitle: " + course.courseTitle);
        //            Console.WriteLine("description: " + course.description);
        //            Console.WriteLine("subject: " + course.subject);
        //            Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
        //            foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
        //            {
        //                Console.WriteLine("applicableEducationLevel: " + ael);
        //            }
        //            Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
        //            Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
        //            Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
        //            Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SINGLE COURSE
        //public static void XCourses_GetXCourse(XPress xPress)
        //{
        //    if (xPress.GetXCourse(refId).Data != null)
        //    {
        //        XCourseType course = xPress.GetXCourse(refId).Data;

        //        Console.WriteLine("refId: " + course.refId);
        //        Console.WriteLine("schoolRefId: " + course.schoolRefId);
        //        Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
        //        Console.WriteLine("leaCourseId: " + course.leaCourseId);
        //        Console.WriteLine("##### BEGIN OTHERIDS #####");
        //        foreach (XOtherCourseIdType id in course.otherIds.otherId)
        //        {
        //            Console.WriteLine("otherId id" + id.id);
        //            Console.WriteLine("type: " + id.type);
        //        }
        //        Console.WriteLine("##### END OTHERIDS #####");
        //        Console.WriteLine("courseTitle: " + course.courseTitle);
        //        Console.WriteLine("description: " + course.description);
        //        Console.WriteLine("subject: " + course.subject);
        //        Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
        //        foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
        //        {
        //            Console.WriteLine("applicableEducationLevel: " + ael);
        //        }
        //        Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
        //        Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
        //        Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
        //        Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

        //        Console.WriteLine("========================================");
        //    }
        //}
        ////RETURN COURSES BY LEA
        //public static void XCourses_GetXCoursesByXLea(XPress xPress)
        //{
        //    if (xPress.GetXCoursesByXLea(LEA_REFID).Data != null)
        //    {
        //        foreach (XCourseType course in xPress.GetXCoursesByXLea(LEA_REFID).Data)
        //        {
        //            Console.WriteLine("refId: " + course.refId);
        //            Console.WriteLine("schoolRefId: " + course.schoolRefId);
        //            Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
        //            Console.WriteLine("leaCourseId: " + course.leaCourseId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherCourseIdType id in course.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("courseTitle: " + course.courseTitle);
        //            Console.WriteLine("description: " + course.description);
        //            Console.WriteLine("subject: " + course.subject);
        //            Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
        //            foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
        //            {
        //                Console.WriteLine("applicableEducationLevel: " + ael);
        //            }
        //            Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
        //            Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
        //            Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
        //            Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN COURSES BY SCHOOL
        //public static void XCourses_GetXCoursesByXSchool(XPress xPress)
        //{
        //    if (xPress.GetXCoursesByXSchool(refId).Data != null)
        //    {
        //        foreach (XCourseType course in xPress.GetXCoursesByXSchool(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + course.refId);
        //            Console.WriteLine("schoolRefId: " + course.schoolRefId);
        //            Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
        //            Console.WriteLine("leaCourseId: " + course.leaCourseId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherCourseIdType id in course.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("courseTitle: " + course.courseTitle);
        //            Console.WriteLine("description: " + course.description);
        //            Console.WriteLine("subject: " + course.subject);
        //            Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
        //            foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
        //            {
        //                Console.WriteLine("applicableEducationLevel: " + ael);
        //            }
        //            Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
        //            Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
        //            Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
        //            Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN COURSES BY ROSTER
        //public static void XCourses_GetXCoursesByXRoster(XPress xPress)
        //{
        //    if (xPress.GetXCoursesByXRoster(refId) != null)
        //    {
        //        foreach (XCourseType course in xPress.GetXCoursesByXRoster(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + course.refId);
        //            Console.WriteLine("schoolRefId: " + course.schoolRefId);
        //            Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
        //            Console.WriteLine("leaCourseId: " + course.leaCourseId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherCourseIdType id in course.otherIds.otherId)
        //            {
        //                Console.WriteLine("otherId id" + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("courseTitle: " + course.courseTitle);
        //            Console.WriteLine("description: " + course.description);
        //            Console.WriteLine("subject: " + course.subject);
        //            Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
        //            foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
        //            {
        //                Console.WriteLine("applicableEducationLevel: " + ael);
        //            }
        //            Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
        //            Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
        //            Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
        //            Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        //#endregion

        //#region xRosters
        ////RETURN ALL ROSTERS
        //public static void XRosters_GetXRosters(XPress xPress)
        //{
        //    if (xPress.GetXRosters().Data != null)
        //    {
        //        foreach (XRosterType r in xPress.GetXRosters().Data)
        //        {
        //            Console.WriteLine("refId: " + r.refId);
        //            Console.WriteLine("courseRefId: " + r.courseRefId);
        //            Console.WriteLine("courseTitle: " + r.courseTitle);
        //            Console.WriteLine("sectionRefId: " + r.sectionRefId);
        //            Console.WriteLine("subject: " + r.subject);
        //            Console.WriteLine("schoolRefId: " + r.schoolRefId);
        //            Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
        //            Console.WriteLine("schoolYear: " + r.schoolYear);
        //            Console.WriteLine("sessionCode: " + r.sessionCode);
        //            Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

        //            Console.WriteLine("##### BEGIN MEETING TIMES #####");
        //            foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
        //            {
        //                Console.WriteLine("timeTableDay: " + mt.timeTableDay);

        //                Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
        //                Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
        //                Console.WriteLine("roomNumber: " + mt.roomNumber);
        //                Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
        //                Console.WriteLine("classEndingTime: " + mt.classEndingTime);
        //            }
        //            Console.WriteLine("##### END MEETING TIMES #####");

        //            Console.WriteLine("##### BEGIN STUDENTS #####");
        //            foreach (XPersonReferenceType student in r.students.studentReference)
        //            {
        //                Console.WriteLine("refId: " + student.refId);
        //                Console.WriteLine("localId: " + student.localId);
        //                Console.WriteLine("givenName: " + student.givenName);
        //                Console.WriteLine("familyName: " + student.familyName);
        //            }
        //            Console.WriteLine("##### END STUDENTS #####");

        //            Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
        //            Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
        //            Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
        //            Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
        //            Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
        //            Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
        //            Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
        //            Console.WriteLine("##### END PRIMARY STAFF #####");

        //            Console.WriteLine("##### BEGIN OTHER STAFF #####");
        //            foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
        //            {
        //                Console.WriteLine("refId: " + staff.staffPersonReference.refId);
        //                Console.WriteLine("localId: " + staff.staffPersonReference.localId);
        //                Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
        //                Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
        //                Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
        //                Console.WriteLine("percentResponsible: " + staff.percentResponsible);
        //            }
        //            Console.WriteLine("##### END OTHER STAFF #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SINGLE ROSTER
        //public static void XRosters_GetXRoster(XPress xPress)
        //{
        //    if (xPress.GetXRoster(refId).Data != null)
        //    {
        //        XRosterType r = xPress.GetXRoster(refId).Data;

        //        Console.WriteLine("refId: " + r.refId);
        //        Console.WriteLine("courseRefId: " + r.courseRefId);
        //        Console.WriteLine("courseTitle: " + r.courseTitle);
        //        Console.WriteLine("sectionRefId: " + r.sectionRefId);
        //        Console.WriteLine("subject: " + r.subject);
        //        Console.WriteLine("schoolRefId: " + r.schoolRefId);
        //        Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
        //        Console.WriteLine("schoolYear: " + r.schoolYear);
        //        Console.WriteLine("sessionCode: " + r.sessionCode);
        //        Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

        //        Console.WriteLine("##### BEGIN MEETING TIMES #####");
        //        foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
        //        {
        //            Console.WriteLine("timeTableDay: " + mt.timeTableDay);

        //            Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
        //            Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
        //            Console.WriteLine("roomNumber: " + mt.roomNumber);
        //            Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
        //            Console.WriteLine("classEndingTime: " + mt.classEndingTime);
        //        }
        //        Console.WriteLine("##### END MEETING TIMES #####");

        //        Console.WriteLine("##### BEGIN STUDENTS #####");
        //        foreach (XPersonReferenceType student in r.students.studentReference)
        //        {
        //            Console.WriteLine("refId: " + student.refId);
        //            Console.WriteLine("localId: " + student.localId);
        //            Console.WriteLine("givenName: " + student.givenName);
        //            Console.WriteLine("familyName: " + student.familyName);
        //        }
        //        Console.WriteLine("##### END STUDENTS #####");

        //        Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
        //        Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
        //        Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
        //        Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
        //        Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
        //        Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
        //        Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
        //        Console.WriteLine("##### END PRIMARY STAFF #####");

        //        Console.WriteLine("##### BEGIN OTHER STAFF #####");
        //        foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
        //        {
        //            Console.WriteLine("refId: " + staff.staffPersonReference.refId);
        //            Console.WriteLine("localId: " + staff.staffPersonReference.localId);
        //            Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
        //            Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
        //            Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
        //            Console.WriteLine("percentResponsible: " + staff.percentResponsible);
        //        }
        //        Console.WriteLine("##### END OTHER STAFF #####");
        //        Console.WriteLine("========================================");
        //    }
        //}
        ////RETURN ROSTERS BY LEA
        //public static void XRosters_GetXRostersByXLea(XPress xPress)
        //{
        //    if (xPress.GetXRostersByXLea(LEA_REFID).Data != null)
        //    {
        //        foreach (XRosterType r in xPress.GetXRostersByXLea(LEA_REFID).Data)
        //        {
        //            Console.WriteLine("refId: " + r.refId);
        //            Console.WriteLine("courseRefId: " + r.courseRefId);
        //            Console.WriteLine("courseTitle: " + r.courseTitle);
        //            Console.WriteLine("sectionRefId: " + r.sectionRefId);
        //            Console.WriteLine("subject: " + r.subject);
        //            Console.WriteLine("schoolRefId: " + r.schoolRefId);
        //            Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
        //            Console.WriteLine("schoolYear: " + r.schoolYear);
        //            Console.WriteLine("sessionCode: " + r.sessionCode);
        //            Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

        //            Console.WriteLine("##### BEGIN MEETING TIMES #####");
        //            foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
        //            {
        //                Console.WriteLine("timeTableDay: " + mt.timeTableDay);

        //                Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
        //                Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
        //                Console.WriteLine("roomNumber: " + mt.roomNumber);
        //                Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
        //                Console.WriteLine("classEndingTime: " + mt.classEndingTime);
        //            }
        //            Console.WriteLine("##### END MEETING TIMES #####");

        //            Console.WriteLine("##### BEGIN STUDENTS #####");
        //            foreach (XPersonReferenceType student in r.students.studentReference)
        //            {
        //                Console.WriteLine("refId: " + student.refId);
        //                Console.WriteLine("localId: " + student.localId);
        //                Console.WriteLine("givenName: " + student.givenName);
        //                Console.WriteLine("familyName: " + student.familyName);
        //            }
        //            Console.WriteLine("##### END STUDENTS #####");

        //            Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
        //            Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
        //            Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
        //            Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
        //            Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
        //            Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
        //            Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
        //            Console.WriteLine("##### END PRIMARY STAFF #####");

        //            Console.WriteLine("##### BEGIN OTHER STAFF #####");
        //            foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
        //            {
        //                Console.WriteLine("refId: " + staff.staffPersonReference.refId);
        //                Console.WriteLine("localId: " + staff.staffPersonReference.localId);
        //                Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
        //                Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
        //                Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
        //                Console.WriteLine("percentResponsible: " + staff.percentResponsible);
        //            }
        //            Console.WriteLine("##### END OTHER STAFF #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN ROSTERS BY SCHOOL
        //public static void XRosters_GetXRostersByXSchool(XPress xPress)
        //{
        //    if (xPress.GetXRostersByXSchool(refId).Data != null)
        //    {
        //        foreach (XRosterType r in xPress.GetXRostersByXSchool(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + r.refId);
        //            Console.WriteLine("courseRefId: " + r.courseRefId);
        //            Console.WriteLine("courseTitle: " + r.courseTitle);
        //            Console.WriteLine("sectionRefId: " + r.sectionRefId);
        //            Console.WriteLine("subject: " + r.subject);
        //            Console.WriteLine("schoolRefId: " + r.schoolRefId);
        //            Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
        //            Console.WriteLine("schoolYear: " + r.schoolYear);
        //            Console.WriteLine("sessionCode: " + r.sessionCode);
        //            Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

        //            Console.WriteLine("##### BEGIN MEETING TIMES #####");
        //            foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
        //            {
        //                Console.WriteLine("timeTableDay: " + mt.timeTableDay);

        //                Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
        //                Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
        //                Console.WriteLine("roomNumber: " + mt.roomNumber);
        //                Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
        //                Console.WriteLine("classEndingTime: " + mt.classEndingTime);
        //            }
        //            Console.WriteLine("##### END MEETING TIMES #####");

        //            Console.WriteLine("##### BEGIN STUDENTS #####");
        //            foreach (XPersonReferenceType student in r.students.studentReference)
        //            {
        //                Console.WriteLine("refId: " + student.refId);
        //                Console.WriteLine("localId: " + student.localId);
        //                Console.WriteLine("givenName: " + student.givenName);
        //                Console.WriteLine("familyName: " + student.familyName);
        //            }
        //            Console.WriteLine("##### END STUDENTS #####");

        //            Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
        //            Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
        //            Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
        //            Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
        //            Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
        //            Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
        //            Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
        //            Console.WriteLine("##### END PRIMARY STAFF #####");

        //            Console.WriteLine("##### BEGIN OTHER STAFF #####");
        //            foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
        //            {
        //                Console.WriteLine("refId: " + staff.staffPersonReference.refId);
        //                Console.WriteLine("localId: " + staff.staffPersonReference.localId);
        //                Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
        //                Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
        //                Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
        //                Console.WriteLine("percentResponsible: " + staff.percentResponsible);
        //            }
        //            Console.WriteLine("##### END OTHER STAFF #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN ROSTERS BY CROUSE
        //public static void XRosters_GetXRostersByXCourse(XPress xPress)
        //{
        //    if (xPress.GetXRostersByXCourse(refId).Data != null)
        //    {
        //        foreach (XRosterType r in xPress.GetXRostersByXCourse(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + r.refId);
        //            Console.WriteLine("courseRefId: " + r.courseRefId);
        //            Console.WriteLine("courseTitle: " + r.courseTitle);
        //            Console.WriteLine("sectionRefId: " + r.sectionRefId);
        //            Console.WriteLine("subject: " + r.subject);
        //            Console.WriteLine("schoolRefId: " + r.schoolRefId);
        //            Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
        //            Console.WriteLine("schoolYear: " + r.schoolYear);
        //            Console.WriteLine("sessionCode: " + r.sessionCode);
        //            Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

        //            Console.WriteLine("##### BEGIN MEETING TIMES #####");
        //            foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
        //            {
        //                Console.WriteLine("timeTableDay: " + mt.timeTableDay);

        //                Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
        //                Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
        //                Console.WriteLine("roomNumber: " + mt.roomNumber);
        //                Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
        //                Console.WriteLine("classEndingTime: " + mt.classEndingTime);
        //            }
        //            Console.WriteLine("##### END MEETING TIMES #####");

        //            Console.WriteLine("##### BEGIN STUDENTS #####");
        //            foreach (XPersonReferenceType student in r.students.studentReference)
        //            {
        //                Console.WriteLine("refId: " + student.refId);
        //                Console.WriteLine("localId: " + student.localId);
        //                Console.WriteLine("givenName: " + student.givenName);
        //                Console.WriteLine("familyName: " + student.familyName);
        //            }
        //            Console.WriteLine("##### END STUDENTS #####");

        //            Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
        //            Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
        //            Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
        //            Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
        //            Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
        //            Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
        //            Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
        //            Console.WriteLine("##### END PRIMARY STAFF #####");

        //            Console.WriteLine("##### BEGIN OTHER STAFF #####");
        //            foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
        //            {
        //                Console.WriteLine("refId: " + staff.staffPersonReference.refId);
        //                Console.WriteLine("localId: " + staff.staffPersonReference.localId);
        //                Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
        //                Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
        //                Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
        //                Console.WriteLine("percentResponsible: " + staff.percentResponsible);
        //            }
        //            Console.WriteLine("##### END OTHER STAFF #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN ROSTERS BY STAFF
        //public static void XRosters_GetXRostersByXStaff(XPress xPress)
        //{
        //    if (xPress.GetXRostersByXStaff(refId).Data != null)
        //    {
        //        foreach (XRosterType r in xPress.GetXRostersByXStaff(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + r.refId);
        //            Console.WriteLine("courseRefId: " + r.courseRefId);
        //            Console.WriteLine("courseTitle: " + r.courseTitle);
        //            Console.WriteLine("sectionRefId: " + r.sectionRefId);
        //            Console.WriteLine("subject: " + r.subject);
        //            Console.WriteLine("schoolRefId: " + r.schoolRefId);
        //            Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
        //            Console.WriteLine("schoolYear: " + r.schoolYear);
        //            Console.WriteLine("sessionCode: " + r.sessionCode);
        //            Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

        //            Console.WriteLine("##### BEGIN MEETING TIMES #####");
        //            foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
        //            {
        //                Console.WriteLine("timeTableDay: " + mt.timeTableDay);

        //                Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
        //                Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
        //                Console.WriteLine("roomNumber: " + mt.roomNumber);
        //                Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
        //                Console.WriteLine("classEndingTime: " + mt.classEndingTime);
        //            }
        //            Console.WriteLine("##### END MEETING TIMES #####");

        //            Console.WriteLine("##### BEGIN STUDENTS #####");
        //            foreach (XPersonReferenceType student in r.students.studentReference)
        //            {
        //                Console.WriteLine("refId: " + student.refId);
        //                Console.WriteLine("localId: " + student.localId);
        //                Console.WriteLine("givenName: " + student.givenName);
        //                Console.WriteLine("familyName: " + student.familyName);
        //            }
        //            Console.WriteLine("##### END STUDENTS #####");

        //            Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
        //            Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
        //            Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
        //            Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
        //            Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
        //            Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
        //            Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
        //            Console.WriteLine("##### END PRIMARY STAFF #####");

        //            Console.WriteLine("##### BEGIN OTHER STAFF #####");
        //            foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
        //            {
        //                Console.WriteLine("refId: " + staff.staffPersonReference.refId);
        //                Console.WriteLine("localId: " + staff.staffPersonReference.localId);
        //                Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
        //                Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
        //                Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
        //                Console.WriteLine("percentResponsible: " + staff.percentResponsible);
        //            }
        //            Console.WriteLine("##### END OTHER STAFF #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN ROSTERS BY STUDENT
        //public static void XRosters_GetXRostersByXStudent(XPress xPress)
        //{
        //    if (xPress.GetXRostersByXStudent(refId).Data != null)
        //    {
        //        foreach (XRosterType r in xPress.GetXRostersByXStudent(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + r.refId);
        //            Console.WriteLine("courseRefId: " + r.courseRefId);
        //            Console.WriteLine("courseTitle: " + r.courseTitle);
        //            Console.WriteLine("sectionRefId: " + r.sectionRefId);
        //            Console.WriteLine("subject: " + r.subject);
        //            Console.WriteLine("schoolRefId: " + r.schoolRefId);
        //            Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
        //            Console.WriteLine("schoolYear: " + r.schoolYear);
        //            Console.WriteLine("sessionCode: " + r.sessionCode);
        //            Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

        //            Console.WriteLine("##### BEGIN MEETING TIMES #####");
        //            foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
        //            {
        //                Console.WriteLine("timeTableDay: " + mt.timeTableDay);

        //                Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
        //                Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
        //                Console.WriteLine("roomNumber: " + mt.roomNumber);
        //                Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
        //                Console.WriteLine("classEndingTime: " + mt.classEndingTime);
        //            }
        //            Console.WriteLine("##### END MEETING TIMES #####");

        //            Console.WriteLine("##### BEGIN STUDENTS #####");
        //            foreach (XPersonReferenceType student in r.students.studentReference)
        //            {
        //                Console.WriteLine("refId: " + student.refId);
        //                Console.WriteLine("localId: " + student.localId);
        //                Console.WriteLine("givenName: " + student.givenName);
        //                Console.WriteLine("familyName: " + student.familyName);
        //            }
        //            Console.WriteLine("##### END STUDENTS #####");

        //            Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
        //            Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
        //            Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
        //            Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
        //            Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
        //            Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
        //            Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
        //            Console.WriteLine("##### END PRIMARY STAFF #####");

        //            Console.WriteLine("##### BEGIN OTHER STAFF #####");
        //            foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
        //            {
        //                Console.WriteLine("refId: " + staff.staffPersonReference.refId);
        //                Console.WriteLine("localId: " + staff.staffPersonReference.localId);
        //                Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
        //                Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
        //                Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
        //                Console.WriteLine("percentResponsible: " + staff.percentResponsible);
        //            }
        //            Console.WriteLine("##### END OTHER STAFF #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}

        //#endregion

        //#region xStaffs
        ////RETURN ALL STAFFS
        //public static void XStaffs_GetXStaffs(XPress xPress)
        //{
        //    if (xPress.GetXStaffs().Data != null)
        //    {
        //        foreach (XStaffType s in xPress.GetXStaffs().Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("localId: " + s.localId);
        //            Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("sex: " + s.sex);
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
        //            Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
        //            Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
        //            foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
        //            {
        //                Console.WriteLine("leaRefId: " + pa.leaRefId);
        //                Console.WriteLine("schoolRefId: " + pa.schoolRefId);
        //                Console.WriteLine("jobFunction: " + pa.jobFunction);
        //            }
        //            Console.WriteLine("##### END OTHERASSIGNMENT #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SINGLE STAFF
        //public static void XStaffs_GetXStaff(XPress xPress)
        //{
        //    if (xPress.GetXStaff(refId).Data != null)
        //    {
        //        XStaffType s = xPress.GetXStaff(refId).Data;

        //        Console.WriteLine("refId: " + s.refId);
        //        Console.WriteLine("##### BEGIN NAME #####");
        //        Console.WriteLine("type: " + s.name.type);
        //        Console.WriteLine("prefix: " + s.name.prefix);
        //        Console.WriteLine("familyName: " + s.name.familyName);
        //        Console.WriteLine("givenName: " + s.name.givenName);
        //        Console.WriteLine("middleName: " + s.name.middleName);
        //        Console.WriteLine("suffix: " + s.name.suffix);
        //        Console.WriteLine("##### END NAME #####");
        //        Console.WriteLine("localId: " + s.localId);

        //        Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
        //        Console.WriteLine("##### BEGIN OTHERIDS #####");
        //        foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //        {
        //            Console.WriteLine("id: " + id.id);
        //            Console.WriteLine("type: " + id.type);
        //        }
        //        Console.WriteLine("##### END OTHERIDS #####");
        //        Console.WriteLine("sex: " + s.sex);
        //        Console.WriteLine("##### BEGIN EMAIL #####");
        //        Console.WriteLine("emailType: " + s.email.emailType);
        //        Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //        Console.WriteLine("##### END EMAIL #####");
        //        Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
        //        Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
        //        Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
        //        Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
        //        Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
        //        Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
        //        foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
        //        {
        //            Console.WriteLine("leaRefId: " + pa.leaRefId);
        //            Console.WriteLine("schoolRefId: " + pa.schoolRefId);
        //            Console.WriteLine("jobFunction: " + pa.jobFunction);
        //        }
        //        Console.WriteLine("##### END OTHERASSIGNMENT #####");
        //        Console.WriteLine("========================================");
        //    }
        //}
        ////RETURN STAFFS BY LEA
        //public static void XStaffs_GetXStaffsByXLea(XPress xPress)
        //{
        //    if (xPress.GetXStaffsByXLea(LEA_REFID).Data != null)
        //    {
        //        foreach (XStaffType s in xPress.GetXStaffsByXLea(LEA_REFID).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("sex: " + s.sex);
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
        //            Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
        //            Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
        //            foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
        //            {
        //                Console.WriteLine("leaRefId: " + pa.leaRefId);
        //                Console.WriteLine("schoolRefId: " + pa.schoolRefId);
        //                Console.WriteLine("jobFunction: " + pa.jobFunction);
        //            }
        //            Console.WriteLine("##### END OTHERASSIGNMENT #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN STAFFS BY SCHOOL
        //public static void XStaffs_GetXStaffsByXSchool(XPress xPress)
        //{
        //    if (xPress.GetXStaffsByXSchool(refId).Data != null)
        //    {
        //        foreach (XStaffType s in xPress.GetXStaffsByXSchool(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("sex: " + s.sex);
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
        //            Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
        //            Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
        //            foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
        //            {
        //                Console.WriteLine("leaRefId: " + pa.leaRefId);
        //                Console.WriteLine("schoolRefId: " + pa.schoolRefId);
        //                Console.WriteLine("jobFunction: " + pa.jobFunction);
        //            }
        //            Console.WriteLine("##### END OTHERASSIGNMENT #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN STAFFS BY COURSE
        //public static void XStaffs_GetXStaffsByXCourse(XPress xPress)
        //{
        //    if (xPress.GetXStaffsByXCourse(refId).Data != null)
        //    {
        //        foreach (XStaffType s in xPress.GetXStaffsByXCourse(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("sex: " + s.sex);
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
        //            Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
        //            Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
        //            foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
        //            {
        //                Console.WriteLine("leaRefId: " + pa.leaRefId);
        //                Console.WriteLine("schoolRefId: " + pa.schoolRefId);
        //                Console.WriteLine("jobFunction: " + pa.jobFunction);
        //            }
        //            Console.WriteLine("##### END OTHERASSIGNMENT #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN STAFFS BY ROSTER
        //public static void XStaffs_GetXStaffsByXRoster(XPress xPress)
        //{
        //    if (xPress.GetXStaffsByXRoster(refId).Data != null)
        //    {
        //        foreach (XStaffType s in xPress.GetXStaffsByXRoster(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("sex: " + s.sex);
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
        //            Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
        //            Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
        //            foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
        //            {
        //                Console.WriteLine("leaRefId: " + pa.leaRefId);
        //                Console.WriteLine("schoolRefId: " + pa.schoolRefId);
        //                Console.WriteLine("jobFunction: " + pa.jobFunction);
        //            }
        //            Console.WriteLine("##### END OTHERASSIGNMENT #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN STAFFS BY STUDENT
        //public static void XStaffs_GetXStaffsByXStudent(XPress xPress)
        //{
        //    if (xPress.GetXStaffsByXStudent(refId).Data != null)
        //    {
        //        foreach (XStaffType s in xPress.GetXStaffsByXStudent(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("sex: " + s.sex);
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
        //            Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
        //            Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
        //            foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
        //            {
        //                Console.WriteLine("leaRefId: " + pa.leaRefId);
        //                Console.WriteLine("schoolRefId: " + pa.schoolRefId);
        //                Console.WriteLine("jobFunction: " + pa.jobFunction);
        //            }
        //            Console.WriteLine("##### END OTHERASSIGNMENT #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        //#endregion

        //#region xStudents
        ////RETURN ALL STUDENTS
        //public static void XStudents_GetXStudents(XPress xPress)
        //{
        //    if (xPress.GetXStudents().Data != null)
        //    {
        //        foreach (XStudentType s in xPress.GetXStudents().Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in s.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + s.address.addressType);
        //            Console.WriteLine("city: " + s.address.city);
        //            Console.WriteLine("line1: " + s.address.line1);
        //            Console.WriteLine("line2: " + s.address.line2);
        //            Console.WriteLine("countryCode: " + s.address.countryCode);
        //            Console.WriteLine("postalCode: " + s.address.postalCode);
        //            Console.WriteLine("stateProvince: " + s.address.stateProvince);
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in s.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN RACES #####");
        //            foreach (XRaceType r in s.demographics.races.race)
        //            {
        //                Console.WriteLine("race: " + r.race);
        //            }
        //            Console.WriteLine("##### END RACES #####");
        //            Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
        //            Console.WriteLine("sex: " + s.demographics.sex);
        //            Console.WriteLine("birthDate: " + s.demographics.birthDate);
        //            Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
        //            Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
        //            Console.WriteLine("##### END DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN ENROLLMENT #####");
        //            Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
        //            Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
        //            Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
        //            Console.WriteLine("membershipType: " + s.enrollment.membershipType);
        //            Console.WriteLine("entryDate: " + s.enrollment.entryDate);
        //            Console.WriteLine("exitDate: " + s.enrollment.exitDate);
        //            Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
        //            Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //            Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
        //            Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
        //            Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //            Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
        //            Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
        //            Console.WriteLine("##### BEGIN COUNSELOR #####");
        //            Console.WriteLine("refId: " + s.enrollment.counselor.refId);
        //            Console.WriteLine("localId: " + s.enrollment.counselor.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
        //            Console.WriteLine("##### END COUNSELOR #####");
        //            Console.WriteLine("##### END ENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
        //            foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
        //            {
        //                Console.WriteLine("leaRefId: " + e.leaRefId);
        //                Console.WriteLine("schoolRefId: " + e.schoolRefId);
        //                Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
        //                Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
        //                Console.WriteLine("membershipType: " + e.membershipType);
        //                Console.WriteLine("entryDate: " + e.entryDate);
        //                Console.WriteLine("exitDate: " + e.exitDate);
        //                Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
        //                Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //                Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
        //                Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
        //                Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
        //                Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
        //                Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //                Console.WriteLine("gradeLevel: " + e.gradeLevel);
        //                Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
        //                Console.WriteLine("##### BEGIN COUNSELOR #####");
        //                Console.WriteLine("refId: " + e.counselor.refId);
        //                Console.WriteLine("localId: " + e.counselor.localId);
        //                Console.WriteLine("givenName: " + e.counselor.givenName);
        //                Console.WriteLine("familyName: " + e.counselor.familyName);
        //                Console.WriteLine("##### END COUNSELOR #####");
        //            }
        //            Console.WriteLine("##### END OTHERENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
        //            Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
        //            Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
        //            Console.WriteLine("classRank: " + s.academicSummary.classRank);
        //            Console.WriteLine("##### END ACADEMICSUMMARY #####");
        //            Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
        //            foreach (String contactRefid in s.studentContacts.contactPersonRefId)
        //            {
        //                Console.WriteLine("contactPersonRefId: " + contactRefid);
        //            }
        //            foreach (XContactType c in s.studentContacts.xContact)
        //            {
        //                Console.WriteLine("##### BEGIN NAME #####");
        //                Console.WriteLine("type: " + c.name.type);
        //                Console.WriteLine("prefix: " + c.name.prefix);
        //                Console.WriteLine("familyName: " + c.name.familyName);
        //                Console.WriteLine("givenName: " + c.name.givenName);
        //                Console.WriteLine("middleName: " + c.name.middleName);
        //                Console.WriteLine("suffix: " + c.name.suffix);
        //                Console.WriteLine("##### END NAME #####");
        //                Console.WriteLine("##### BEGIN OTHERNAME #####");
        //                foreach (XPersonNameType n in c.otherNames.name)
        //                {
        //                    Console.WriteLine("type: " + n.type);
        //                    Console.WriteLine("prefix: " + n.prefix);
        //                    Console.WriteLine("familyName: " + n.familyName);
        //                    Console.WriteLine("givenName: " + n.givenName);
        //                    Console.WriteLine("middleName: " + n.middleName);
        //                    Console.WriteLine("suffix: " + n.suffix);
        //                }
        //                Console.WriteLine("##### END OTHERNAME #####");
        //                Console.WriteLine(": " + c.localId);

        //                Console.WriteLine("##### BEGIN OTHERIDS #####");
        //                foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //                {
        //                    Console.WriteLine("id: " + id.id);
        //                    Console.WriteLine("type: " + id.type);
        //                }
        //                Console.WriteLine("##### END OTHERIDS #####");
        //                Console.WriteLine("##### BEGIN ADDRESS #####");
        //                Console.WriteLine("addressType: " + c.address.addressType);
        //                Console.WriteLine("city: " + c.address.city);
        //                Console.WriteLine("line1: " + c.address.line1);
        //                Console.WriteLine("line2: " + c.address.line2);
        //                Console.WriteLine("countryCode: " + c.address.countryCode);
        //                Console.WriteLine("postalCode: " + c.address.postalCode);
        //                Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END ADDRESS #####");
        //                Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END PHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //                foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //                {
        //                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //                }
        //                Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN EMAIL #####");
        //                Console.WriteLine("emailType: " + c.email.emailType);
        //                Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //                Console.WriteLine("##### END EMAIL #####");
        //                Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //                foreach (XEmailType e in c.otherEmails.email)
        //                {
        //                    Console.WriteLine("emailType: " + e.emailType);
        //                    Console.WriteLine("emailAddress: " + e.emailAddress);
        //                }
        //                Console.WriteLine("##### END OTHEREMAILS #####");
        //                Console.WriteLine(": " + c.sex);
        //                Console.WriteLine(": " + c.employerType);
        //                Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //                foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //                {
        //                    Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                    Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                    Console.WriteLine("restrictions: " + csr.restrictions);
        //                    Console.WriteLine("livesWith: " + csr.livesWith);
        //                    Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                    Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                    Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                    Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                    Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                    Console.WriteLine("contactSequence: " + csr.contactSequence);
        //                }
        //                Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            }
        //            Console.WriteLine("##### END STUDENTCONTACTS #####");
        //            Console.WriteLine("##### BEGIN LANGUAGES #####");
        //            foreach (XLanguageType l in s.languages.language)
        //            {
        //                Console.WriteLine("type: " + l.type);
        //                Console.WriteLine("code: " + l.code);
        //            }
        //            Console.WriteLine("##### END LANGUAGES #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SINGLE STUDENT
        //public static void XStudents_GetXStudent(XPress xPress)
        //{
        //    if (xPress.GetXStudent(refId).Data != null)
        //    {
        //        XStudentType s = xPress.GetXStudent(refId).Data;

        //        Console.WriteLine("refId: " + s.refId);
        //        Console.WriteLine("##### BEGIN NAME #####");
        //        Console.WriteLine("type: " + s.name.type);
        //        Console.WriteLine("prefix: " + s.name.prefix);
        //        Console.WriteLine("familyName: " + s.name.familyName);
        //        Console.WriteLine("givenName: " + s.name.givenName);
        //        Console.WriteLine("middleName: " + s.name.middleName);
        //        Console.WriteLine("suffix: " + s.name.suffix);
        //        Console.WriteLine("##### END NAME #####");
        //        Console.WriteLine("##### BEGIN OTHERNAME #####");
        //        foreach (XPersonNameType n in s.otherNames.name)
        //        {
        //            Console.WriteLine("type: " + n.type);
        //            Console.WriteLine("prefix: " + n.prefix);
        //            Console.WriteLine("familyName: " + n.familyName);
        //            Console.WriteLine("givenName: " + n.givenName);
        //            Console.WriteLine("middleName: " + n.middleName);
        //            Console.WriteLine("suffix: " + n.suffix);
        //        }
        //        Console.WriteLine("##### END OTHERNAME #####");

        //        Console.WriteLine("localId: " + s.localId);

        //        Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
        //        Console.WriteLine("##### BEGIN OTHERIDS #####");
        //        foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //        {
        //            Console.WriteLine("id: " + id.id);
        //            Console.WriteLine("type: " + id.type);
        //        }
        //        Console.WriteLine("##### END OTHERIDS #####");
        //        Console.WriteLine("##### BEGIN ADDRESS #####");
        //        Console.WriteLine("addressType: " + s.address.addressType);
        //        Console.WriteLine("city: " + s.address.city);
        //        Console.WriteLine("line1: " + s.address.line1);
        //        Console.WriteLine("line2: " + s.address.line2);
        //        Console.WriteLine("countryCode: " + s.address.countryCode);
        //        Console.WriteLine("postalCode: " + s.address.postalCode);
        //        Console.WriteLine("stateProvince: " + s.address.stateProvince);
        //        Console.WriteLine("number: " + s.phoneNumber.number);
        //        Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //        Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //        Console.WriteLine("##### END ADDRESS #####");
        //        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //        Console.WriteLine("number: " + s.phoneNumber.number);
        //        Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //        Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //        Console.WriteLine("##### END PHONENUMBERS #####");
        //        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //        foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
        //        {
        //            Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //        }
        //        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //        Console.WriteLine("##### BEGIN EMAIL #####");
        //        Console.WriteLine("emailType: " + s.email.emailType);
        //        Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //        Console.WriteLine("##### END EMAIL #####");
        //        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //        foreach (XEmailType e in s.otherEmails.email)
        //        {
        //            Console.WriteLine("emailType: " + e.emailType);
        //            Console.WriteLine("emailAddress: " + e.emailAddress);
        //        }
        //        Console.WriteLine("##### END OTHEREMAILS #####");
        //        Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
        //        Console.WriteLine("##### BEGIN RACES #####");
        //        foreach (XRaceType r in s.demographics.races.race)
        //        {
        //            Console.WriteLine("race: " + r.race);
        //        }
        //        Console.WriteLine("##### END RACES #####");
        //        Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
        //        Console.WriteLine("sex: " + s.demographics.sex);
        //        Console.WriteLine("birthDate: " + s.demographics.birthDate);
        //        Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
        //        Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
        //        Console.WriteLine("##### END DEMOGRAPHICS #####");
        //        Console.WriteLine("##### BEGIN ENROLLMENT #####");
        //        Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
        //        Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
        //        Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
        //        Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
        //        Console.WriteLine("membershipType: " + s.enrollment.membershipType);
        //        Console.WriteLine("entryDate: " + s.enrollment.entryDate);
        //        Console.WriteLine("exitDate: " + s.enrollment.exitDate);
        //        Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
        //        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //        Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
        //        Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
        //        Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
        //        Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
        //        Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //        Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
        //        Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
        //        Console.WriteLine("##### BEGIN COUNSELOR #####");
        //        Console.WriteLine("refId: " + s.enrollment.counselor.refId);
        //        Console.WriteLine("localId: " + s.enrollment.counselor.localId);
        //        Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
        //        Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
        //        Console.WriteLine("##### END COUNSELOR #####");
        //        Console.WriteLine("##### END ENROLLMENT #####");
        //        Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
        //        foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
        //        {
        //            Console.WriteLine("leaRefId: " + e.leaRefId);
        //            Console.WriteLine("schoolRefId: " + e.schoolRefId);
        //            Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
        //            Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
        //            Console.WriteLine("membershipType: " + e.membershipType);
        //            Console.WriteLine("entryDate: " + e.entryDate);
        //            Console.WriteLine("exitDate: " + e.exitDate);
        //            Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
        //            Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //            Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
        //            Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
        //            Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
        //            Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
        //            Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //            Console.WriteLine("gradeLevel: " + e.gradeLevel);
        //            Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
        //            Console.WriteLine("##### BEGIN COUNSELOR #####");
        //            Console.WriteLine("refId: " + e.counselor.refId);
        //            Console.WriteLine("localId: " + e.counselor.localId);
        //            Console.WriteLine("givenName: " + e.counselor.givenName);
        //            Console.WriteLine("familyName: " + e.counselor.familyName);
        //            Console.WriteLine("##### END COUNSELOR #####");
        //        }
        //        Console.WriteLine("##### END OTHERENROLLMENT #####");
        //        Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
        //        Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
        //        Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
        //        Console.WriteLine("classRank: " + s.academicSummary.classRank);
        //        Console.WriteLine("##### END ACADEMICSUMMARY #####");
        //        Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
        //        foreach (String contactRefid in s.studentContacts.contactPersonRefId)
        //        {
        //            Console.WriteLine("contactPersonRefId: " + contactRefid);
        //        }
        //        foreach (XContactType c in s.studentContacts.xContact)
        //        {
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + c.name.type);
        //            Console.WriteLine("prefix: " + c.name.prefix);
        //            Console.WriteLine("familyName: " + c.name.familyName);
        //            Console.WriteLine("givenName: " + c.name.givenName);
        //            Console.WriteLine("middleName: " + c.name.middleName);
        //            Console.WriteLine("suffix: " + c.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in c.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");
        //            Console.WriteLine(": " + c.localId);

        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + c.address.addressType);
        //            Console.WriteLine("city: " + c.address.city);
        //            Console.WriteLine("line1: " + c.address.line1);
        //            Console.WriteLine("line2: " + c.address.line2);
        //            Console.WriteLine("countryCode: " + c.address.countryCode);
        //            Console.WriteLine("postalCode: " + c.address.postalCode);
        //            Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + c.email.emailType);
        //            Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in c.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine(": " + c.sex);
        //            Console.WriteLine(": " + c.employerType);
        //            Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //            foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //            {
        //                Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                Console.WriteLine("restrictions: " + csr.restrictions);
        //                Console.WriteLine("livesWith: " + csr.livesWith);
        //                Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                Console.WriteLine("contactSequence: " + csr.contactSequence);
        //            }
        //            Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //        }
        //        Console.WriteLine("##### END STUDENTCONTACTS #####");
        //        Console.WriteLine("##### BEGIN LANGUAGES #####");
        //        foreach (XLanguageType l in s.languages.language)
        //        {
        //            Console.WriteLine("type: " + l.type);
        //            Console.WriteLine("code: " + l.code);
        //        }
        //        Console.WriteLine("##### END LANGUAGES #####");
        //        Console.WriteLine("========================================");
        //    }
        //}
        ////RETURN STUDENTS BY LEA
        //public static void XStudents_GetXStudentsByXLea(XPress xPress)
        //{
        //    if (xPress.GetXStudentsByXLea(LEA_REFID).Data != null)
        //    {
        //        foreach (XStudentType s in xPress.GetXStudentsByXLea(LEA_REFID).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in s.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + s.address.addressType);
        //            Console.WriteLine("city: " + s.address.city);
        //            Console.WriteLine("line1: " + s.address.line1);
        //            Console.WriteLine("line2: " + s.address.line2);
        //            Console.WriteLine("countryCode: " + s.address.countryCode);
        //            Console.WriteLine("postalCode: " + s.address.postalCode);
        //            Console.WriteLine("stateProvince: " + s.address.stateProvince);
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in s.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN RACES #####");
        //            foreach (XRaceType r in s.demographics.races.race)
        //            {
        //                Console.WriteLine("race: " + r.race);
        //            }
        //            Console.WriteLine("##### END RACES #####");
        //            Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
        //            Console.WriteLine("sex: " + s.demographics.sex);
        //            Console.WriteLine("birthDate: " + s.demographics.birthDate);
        //            Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
        //            Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
        //            Console.WriteLine("##### END DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN ENROLLMENT #####");
        //            Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
        //            Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
        //            Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
        //            Console.WriteLine("membershipType: " + s.enrollment.membershipType);
        //            Console.WriteLine("entryDate: " + s.enrollment.entryDate);
        //            Console.WriteLine("exitDate: " + s.enrollment.exitDate);
        //            Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
        //            Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //            Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
        //            Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
        //            Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //            Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
        //            Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
        //            Console.WriteLine("##### BEGIN COUNSELOR #####");
        //            Console.WriteLine("refId: " + s.enrollment.counselor.refId);
        //            Console.WriteLine("localId: " + s.enrollment.counselor.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
        //            Console.WriteLine("##### END COUNSELOR #####");
        //            Console.WriteLine("##### END ENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
        //            foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
        //            {
        //                Console.WriteLine("leaRefId: " + e.leaRefId);
        //                Console.WriteLine("schoolRefId: " + e.schoolRefId);
        //                Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
        //                Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
        //                Console.WriteLine("membershipType: " + e.membershipType);
        //                Console.WriteLine("entryDate: " + e.entryDate);
        //                Console.WriteLine("exitDate: " + e.exitDate);
        //                Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
        //                Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //                Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
        //                Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
        //                Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
        //                Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
        //                Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //                Console.WriteLine("gradeLevel: " + e.gradeLevel);
        //                Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
        //                Console.WriteLine("##### BEGIN COUNSELOR #####");
        //                Console.WriteLine("refId: " + e.counselor.refId);
        //                Console.WriteLine("localId: " + e.counselor.localId);
        //                Console.WriteLine("givenName: " + e.counselor.givenName);
        //                Console.WriteLine("familyName: " + e.counselor.familyName);
        //                Console.WriteLine("##### END COUNSELOR #####");
        //            }
        //            Console.WriteLine("##### END OTHERENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
        //            Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
        //            Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
        //            Console.WriteLine("classRank: " + s.academicSummary.classRank);
        //            Console.WriteLine("##### END ACADEMICSUMMARY #####");
        //            Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
        //            foreach (String contactRefid in s.studentContacts.contactPersonRefId)
        //            {
        //                Console.WriteLine("contactPersonRefId: " + contactRefid);
        //            }
        //            foreach (XContactType c in s.studentContacts.xContact)
        //            {
        //                Console.WriteLine("##### BEGIN NAME #####");
        //                Console.WriteLine("type: " + c.name.type);
        //                Console.WriteLine("prefix: " + c.name.prefix);
        //                Console.WriteLine("familyName: " + c.name.familyName);
        //                Console.WriteLine("givenName: " + c.name.givenName);
        //                Console.WriteLine("middleName: " + c.name.middleName);
        //                Console.WriteLine("suffix: " + c.name.suffix);
        //                Console.WriteLine("##### END NAME #####");
        //                Console.WriteLine("##### BEGIN OTHERNAME #####");
        //                foreach (XPersonNameType n in c.otherNames.name)
        //                {
        //                    Console.WriteLine("type: " + n.type);
        //                    Console.WriteLine("prefix: " + n.prefix);
        //                    Console.WriteLine("familyName: " + n.familyName);
        //                    Console.WriteLine("givenName: " + n.givenName);
        //                    Console.WriteLine("middleName: " + n.middleName);
        //                    Console.WriteLine("suffix: " + n.suffix);
        //                }
        //                Console.WriteLine("##### END OTHERNAME #####");
        //                Console.WriteLine(": " + c.localId);

        //                Console.WriteLine("##### BEGIN OTHERIDS #####");
        //                foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //                {
        //                    Console.WriteLine("id: " + id.id);
        //                    Console.WriteLine("type: " + id.type);
        //                }
        //                Console.WriteLine("##### END OTHERIDS #####");
        //                Console.WriteLine("##### BEGIN ADDRESS #####");
        //                Console.WriteLine("addressType: " + c.address.addressType);
        //                Console.WriteLine("city: " + c.address.city);
        //                Console.WriteLine("line1: " + c.address.line1);
        //                Console.WriteLine("line2: " + c.address.line2);
        //                Console.WriteLine("countryCode: " + c.address.countryCode);
        //                Console.WriteLine("postalCode: " + c.address.postalCode);
        //                Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END ADDRESS #####");
        //                Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END PHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //                foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //                {
        //                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //                }
        //                Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN EMAIL #####");
        //                Console.WriteLine("emailType: " + c.email.emailType);
        //                Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //                Console.WriteLine("##### END EMAIL #####");
        //                Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //                foreach (XEmailType e in c.otherEmails.email)
        //                {
        //                    Console.WriteLine("emailType: " + e.emailType);
        //                    Console.WriteLine("emailAddress: " + e.emailAddress);
        //                }
        //                Console.WriteLine("##### END OTHEREMAILS #####");
        //                Console.WriteLine(": " + c.sex);
        //                Console.WriteLine(": " + c.employerType);
        //                Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //                foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //                {
        //                    Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                    Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                    Console.WriteLine("restrictions: " + csr.restrictions);
        //                    Console.WriteLine("livesWith: " + csr.livesWith);
        //                    Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                    Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                    Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                    Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                    Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                    Console.WriteLine("contactSequence: " + csr.contactSequence);
        //                }
        //                Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            }
        //            Console.WriteLine("##### END STUDENTCONTACTS #####");
        //            Console.WriteLine("##### BEGIN LANGUAGES #####");
        //            foreach (XLanguageType l in s.languages.language)
        //            {
        //                Console.WriteLine("type: " + l.type);
        //                Console.WriteLine("code: " + l.code);
        //            }
        //            Console.WriteLine("##### END LANGUAGES #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN STUDENTS BY SCHOOL
        //public static void XStudents_GetXStudentsByXSchool(XPress xPress)
        //{
        //    if (xPress.GetXStudentsByXSchool(refId).Data != null)
        //    {
        //        foreach (XStudentType s in xPress.GetXStudentsByXSchool(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in s.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + s.address.addressType);
        //            Console.WriteLine("city: " + s.address.city);
        //            Console.WriteLine("line1: " + s.address.line1);
        //            Console.WriteLine("line2: " + s.address.line2);
        //            Console.WriteLine("countryCode: " + s.address.countryCode);
        //            Console.WriteLine("postalCode: " + s.address.postalCode);
        //            Console.WriteLine("stateProvince: " + s.address.stateProvince);
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in s.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN RACES #####");
        //            foreach (XRaceType r in s.demographics.races.race)
        //            {
        //                Console.WriteLine("race: " + r.race);
        //            }
        //            Console.WriteLine("##### END RACES #####");
        //            Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
        //            Console.WriteLine("sex: " + s.demographics.sex);
        //            Console.WriteLine("birthDate: " + s.demographics.birthDate);
        //            Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
        //            Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
        //            Console.WriteLine("##### END DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN ENROLLMENT #####");
        //            Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
        //            Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
        //            Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
        //            Console.WriteLine("membershipType: " + s.enrollment.membershipType);
        //            Console.WriteLine("entryDate: " + s.enrollment.entryDate);
        //            Console.WriteLine("exitDate: " + s.enrollment.exitDate);
        //            Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
        //            Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //            Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
        //            Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
        //            Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //            Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
        //            Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
        //            Console.WriteLine("##### BEGIN COUNSELOR #####");
        //            Console.WriteLine("refId: " + s.enrollment.counselor.refId);
        //            Console.WriteLine("localId: " + s.enrollment.counselor.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
        //            Console.WriteLine("##### END COUNSELOR #####");
        //            Console.WriteLine("##### END ENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
        //            foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
        //            {
        //                Console.WriteLine("leaRefId: " + e.leaRefId);
        //                Console.WriteLine("schoolRefId: " + e.schoolRefId);
        //                Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
        //                Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
        //                Console.WriteLine("membershipType: " + e.membershipType);
        //                Console.WriteLine("entryDate: " + e.entryDate);
        //                Console.WriteLine("exitDate: " + e.exitDate);
        //                Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
        //                Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //                Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
        //                Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
        //                Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
        //                Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
        //                Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //                Console.WriteLine("gradeLevel: " + e.gradeLevel);
        //                Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
        //                Console.WriteLine("##### BEGIN COUNSELOR #####");
        //                Console.WriteLine("refId: " + e.counselor.refId);
        //                Console.WriteLine("localId: " + e.counselor.localId);
        //                Console.WriteLine("givenName: " + e.counselor.givenName);
        //                Console.WriteLine("familyName: " + e.counselor.familyName);
        //                Console.WriteLine("##### END COUNSELOR #####");
        //            }
        //            Console.WriteLine("##### END OTHERENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
        //            Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
        //            Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
        //            Console.WriteLine("classRank: " + s.academicSummary.classRank);
        //            Console.WriteLine("##### END ACADEMICSUMMARY #####");
        //            Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
        //            foreach (String contactRefid in s.studentContacts.contactPersonRefId)
        //            {
        //                Console.WriteLine("contactPersonRefId: " + contactRefid);
        //            }
        //            foreach (XContactType c in s.studentContacts.xContact)
        //            {
        //                Console.WriteLine("##### BEGIN NAME #####");
        //                Console.WriteLine("type: " + c.name.type);
        //                Console.WriteLine("prefix: " + c.name.prefix);
        //                Console.WriteLine("familyName: " + c.name.familyName);
        //                Console.WriteLine("givenName: " + c.name.givenName);
        //                Console.WriteLine("middleName: " + c.name.middleName);
        //                Console.WriteLine("suffix: " + c.name.suffix);
        //                Console.WriteLine("##### END NAME #####");
        //                Console.WriteLine("##### BEGIN OTHERNAME #####");
        //                foreach (XPersonNameType n in c.otherNames.name)
        //                {
        //                    Console.WriteLine("type: " + n.type);
        //                    Console.WriteLine("prefix: " + n.prefix);
        //                    Console.WriteLine("familyName: " + n.familyName);
        //                    Console.WriteLine("givenName: " + n.givenName);
        //                    Console.WriteLine("middleName: " + n.middleName);
        //                    Console.WriteLine("suffix: " + n.suffix);
        //                }
        //                Console.WriteLine("##### END OTHERNAME #####");
        //                Console.WriteLine(": " + c.localId);

        //                Console.WriteLine("##### BEGIN OTHERIDS #####");
        //                foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //                {
        //                    Console.WriteLine("id: " + id.id);
        //                    Console.WriteLine("type: " + id.type);
        //                }
        //                Console.WriteLine("##### END OTHERIDS #####");
        //                Console.WriteLine("##### BEGIN ADDRESS #####");
        //                Console.WriteLine("addressType: " + c.address.addressType);
        //                Console.WriteLine("city: " + c.address.city);
        //                Console.WriteLine("line1: " + c.address.line1);
        //                Console.WriteLine("line2: " + c.address.line2);
        //                Console.WriteLine("countryCode: " + c.address.countryCode);
        //                Console.WriteLine("postalCode: " + c.address.postalCode);
        //                Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END ADDRESS #####");
        //                Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END PHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //                foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //                {
        //                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //                }
        //                Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN EMAIL #####");
        //                Console.WriteLine("emailType: " + c.email.emailType);
        //                Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //                Console.WriteLine("##### END EMAIL #####");
        //                Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //                foreach (XEmailType e in c.otherEmails.email)
        //                {
        //                    Console.WriteLine("emailType: " + e.emailType);
        //                    Console.WriteLine("emailAddress: " + e.emailAddress);
        //                }
        //                Console.WriteLine("##### END OTHEREMAILS #####");
        //                Console.WriteLine(": " + c.sex);
        //                Console.WriteLine(": " + c.employerType);
        //                Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //                foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //                {
        //                    Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                    Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                    Console.WriteLine("restrictions: " + csr.restrictions);
        //                    Console.WriteLine("livesWith: " + csr.livesWith);
        //                    Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                    Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                    Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                    Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                    Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                    Console.WriteLine("contactSequence: " + csr.contactSequence);
        //                }
        //                Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            }
        //            Console.WriteLine("##### END STUDENTCONTACTS #####");
        //            Console.WriteLine("##### BEGIN LANGUAGES #####");
        //            foreach (XLanguageType l in s.languages.language)
        //            {
        //                Console.WriteLine("type: " + l.type);
        //                Console.WriteLine("code: " + l.code);
        //            }
        //            Console.WriteLine("##### END LANGUAGES #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN STUDENTS BY ROSTER
        //public static void XStudents_GetXStudentsByXRoster(XPress xPress)
        //{
        //    if (xPress.GetXStudentsByXRoster(refId).Data != null)
        //    {
        //        foreach (XStudentType s in xPress.GetXStudentsByXRoster(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in s.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + s.address.addressType);
        //            Console.WriteLine("city: " + s.address.city);
        //            Console.WriteLine("line1: " + s.address.line1);
        //            Console.WriteLine("line2: " + s.address.line2);
        //            Console.WriteLine("countryCode: " + s.address.countryCode);
        //            Console.WriteLine("postalCode: " + s.address.postalCode);
        //            Console.WriteLine("stateProvince: " + s.address.stateProvince);
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in s.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN RACES #####");
        //            foreach (XRaceType r in s.demographics.races.race)
        //            {
        //                Console.WriteLine("race: " + r.race);
        //            }
        //            Console.WriteLine("##### END RACES #####");
        //            Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
        //            Console.WriteLine("sex: " + s.demographics.sex);
        //            Console.WriteLine("birthDate: " + s.demographics.birthDate);
        //            Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
        //            Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
        //            Console.WriteLine("##### END DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN ENROLLMENT #####");
        //            Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
        //            Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
        //            Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
        //            Console.WriteLine("membershipType: " + s.enrollment.membershipType);
        //            Console.WriteLine("entryDate: " + s.enrollment.entryDate);
        //            Console.WriteLine("exitDate: " + s.enrollment.exitDate);
        //            Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
        //            Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //            Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
        //            Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
        //            Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //            Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
        //            Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
        //            Console.WriteLine("##### BEGIN COUNSELOR #####");
        //            Console.WriteLine("refId: " + s.enrollment.counselor.refId);
        //            Console.WriteLine("localId: " + s.enrollment.counselor.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
        //            Console.WriteLine("##### END COUNSELOR #####");
        //            Console.WriteLine("##### END ENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
        //            foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
        //            {
        //                Console.WriteLine("leaRefId: " + e.leaRefId);
        //                Console.WriteLine("schoolRefId: " + e.schoolRefId);
        //                Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
        //                Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
        //                Console.WriteLine("membershipType: " + e.membershipType);
        //                Console.WriteLine("entryDate: " + e.entryDate);
        //                Console.WriteLine("exitDate: " + e.exitDate);
        //                Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
        //                Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //                Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
        //                Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
        //                Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
        //                Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
        //                Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //                Console.WriteLine("gradeLevel: " + e.gradeLevel);
        //                Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
        //                Console.WriteLine("##### BEGIN COUNSELOR #####");
        //                Console.WriteLine("refId: " + e.counselor.refId);
        //                Console.WriteLine("localId: " + e.counselor.localId);
        //                Console.WriteLine("givenName: " + e.counselor.givenName);
        //                Console.WriteLine("familyName: " + e.counselor.familyName);
        //                Console.WriteLine("##### END COUNSELOR #####");
        //            }
        //            Console.WriteLine("##### END OTHERENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
        //            Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
        //            Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
        //            Console.WriteLine("classRank: " + s.academicSummary.classRank);
        //            Console.WriteLine("##### END ACADEMICSUMMARY #####");
        //            Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
        //            foreach (String contactRefid in s.studentContacts.contactPersonRefId)
        //            {
        //                Console.WriteLine("contactPersonRefId: " + contactRefid);
        //            }
        //            foreach (XContactType c in s.studentContacts.xContact)
        //            {
        //                Console.WriteLine("##### BEGIN NAME #####");
        //                Console.WriteLine("type: " + c.name.type);
        //                Console.WriteLine("prefix: " + c.name.prefix);
        //                Console.WriteLine("familyName: " + c.name.familyName);
        //                Console.WriteLine("givenName: " + c.name.givenName);
        //                Console.WriteLine("middleName: " + c.name.middleName);
        //                Console.WriteLine("suffix: " + c.name.suffix);
        //                Console.WriteLine("##### END NAME #####");
        //                Console.WriteLine("##### BEGIN OTHERNAME #####");
        //                foreach (XPersonNameType n in c.otherNames.name)
        //                {
        //                    Console.WriteLine("type: " + n.type);
        //                    Console.WriteLine("prefix: " + n.prefix);
        //                    Console.WriteLine("familyName: " + n.familyName);
        //                    Console.WriteLine("givenName: " + n.givenName);
        //                    Console.WriteLine("middleName: " + n.middleName);
        //                    Console.WriteLine("suffix: " + n.suffix);
        //                }
        //                Console.WriteLine("##### END OTHERNAME #####");
        //                Console.WriteLine(": " + c.localId);

        //                Console.WriteLine("##### BEGIN OTHERIDS #####");
        //                foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //                {
        //                    Console.WriteLine("id: " + id.id);
        //                    Console.WriteLine("type: " + id.type);
        //                }
        //                Console.WriteLine("##### END OTHERIDS #####");
        //                Console.WriteLine("##### BEGIN ADDRESS #####");
        //                Console.WriteLine("addressType: " + c.address.addressType);
        //                Console.WriteLine("city: " + c.address.city);
        //                Console.WriteLine("line1: " + c.address.line1);
        //                Console.WriteLine("line2: " + c.address.line2);
        //                Console.WriteLine("countryCode: " + c.address.countryCode);
        //                Console.WriteLine("postalCode: " + c.address.postalCode);
        //                Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END ADDRESS #####");
        //                Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END PHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //                foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //                {
        //                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //                }
        //                Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN EMAIL #####");
        //                Console.WriteLine("emailType: " + c.email.emailType);
        //                Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //                Console.WriteLine("##### END EMAIL #####");
        //                Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //                foreach (XEmailType e in c.otherEmails.email)
        //                {
        //                    Console.WriteLine("emailType: " + e.emailType);
        //                    Console.WriteLine("emailAddress: " + e.emailAddress);
        //                }
        //                Console.WriteLine("##### END OTHEREMAILS #####");
        //                Console.WriteLine(": " + c.sex);
        //                Console.WriteLine(": " + c.employerType);
        //                Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //                foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //                {
        //                    Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                    Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                    Console.WriteLine("restrictions: " + csr.restrictions);
        //                    Console.WriteLine("livesWith: " + csr.livesWith);
        //                    Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                    Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                    Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                    Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                    Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                    Console.WriteLine("contactSequence: " + csr.contactSequence);
        //                }
        //                Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            }
        //            Console.WriteLine("##### END STUDENTCONTACTS #####");
        //            Console.WriteLine("##### BEGIN LANGUAGES #####");
        //            foreach (XLanguageType l in s.languages.language)
        //            {
        //                Console.WriteLine("type: " + l.type);
        //                Console.WriteLine("code: " + l.code);
        //            }
        //            Console.WriteLine("##### END LANGUAGES #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN STUDENTS BY STAFF
        //public static void XStudents_GetXStudentsByXStaff(XPress xPress)
        //{
        //    if (xPress.GetXStudentsByXStaff(refId).Data != null)
        //    {
        //        foreach (XStudentType s in xPress.GetXStudentsByXStaff(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in s.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + s.address.addressType);
        //            Console.WriteLine("city: " + s.address.city);
        //            Console.WriteLine("line1: " + s.address.line1);
        //            Console.WriteLine("line2: " + s.address.line2);
        //            Console.WriteLine("countryCode: " + s.address.countryCode);
        //            Console.WriteLine("postalCode: " + s.address.postalCode);
        //            Console.WriteLine("stateProvince: " + s.address.stateProvince);
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in s.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN RACES #####");
        //            foreach (XRaceType r in s.demographics.races.race)
        //            {
        //                Console.WriteLine("race: " + r.race);
        //            }
        //            Console.WriteLine("##### END RACES #####");
        //            Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
        //            Console.WriteLine("sex: " + s.demographics.sex);
        //            Console.WriteLine("birthDate: " + s.demographics.birthDate);
        //            Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
        //            Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
        //            Console.WriteLine("##### END DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN ENROLLMENT #####");
        //            Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
        //            Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
        //            Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
        //            Console.WriteLine("membershipType: " + s.enrollment.membershipType);
        //            Console.WriteLine("entryDate: " + s.enrollment.entryDate);
        //            Console.WriteLine("exitDate: " + s.enrollment.exitDate);
        //            Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
        //            Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //            Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
        //            Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
        //            Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //            Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
        //            Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
        //            Console.WriteLine("##### BEGIN COUNSELOR #####");
        //            Console.WriteLine("refId: " + s.enrollment.counselor.refId);
        //            Console.WriteLine("localId: " + s.enrollment.counselor.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
        //            Console.WriteLine("##### END COUNSELOR #####");
        //            Console.WriteLine("##### END ENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
        //            foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
        //            {
        //                Console.WriteLine("leaRefId: " + e.leaRefId);
        //                Console.WriteLine("schoolRefId: " + e.schoolRefId);
        //                Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
        //                Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
        //                Console.WriteLine("membershipType: " + e.membershipType);
        //                Console.WriteLine("entryDate: " + e.entryDate);
        //                Console.WriteLine("exitDate: " + e.exitDate);
        //                Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
        //                Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //                Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
        //                Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
        //                Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
        //                Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
        //                Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //                Console.WriteLine("gradeLevel: " + e.gradeLevel);
        //                Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
        //                Console.WriteLine("##### BEGIN COUNSELOR #####");
        //                Console.WriteLine("refId: " + e.counselor.refId);
        //                Console.WriteLine("localId: " + e.counselor.localId);
        //                Console.WriteLine("givenName: " + e.counselor.givenName);
        //                Console.WriteLine("familyName: " + e.counselor.familyName);
        //                Console.WriteLine("##### END COUNSELOR #####");
        //            }
        //            Console.WriteLine("##### END OTHERENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
        //            Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
        //            Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
        //            Console.WriteLine("classRank: " + s.academicSummary.classRank);
        //            Console.WriteLine("##### END ACADEMICSUMMARY #####");
        //            Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
        //            foreach (String contactRefid in s.studentContacts.contactPersonRefId)
        //            {
        //                Console.WriteLine("contactPersonRefId: " + contactRefid);
        //            }
        //            foreach (XContactType c in s.studentContacts.xContact)
        //            {
        //                Console.WriteLine("##### BEGIN NAME #####");
        //                Console.WriteLine("type: " + c.name.type);
        //                Console.WriteLine("prefix: " + c.name.prefix);
        //                Console.WriteLine("familyName: " + c.name.familyName);
        //                Console.WriteLine("givenName: " + c.name.givenName);
        //                Console.WriteLine("middleName: " + c.name.middleName);
        //                Console.WriteLine("suffix: " + c.name.suffix);
        //                Console.WriteLine("##### END NAME #####");
        //                Console.WriteLine("##### BEGIN OTHERNAME #####");
        //                foreach (XPersonNameType n in c.otherNames.name)
        //                {
        //                    Console.WriteLine("type: " + n.type);
        //                    Console.WriteLine("prefix: " + n.prefix);
        //                    Console.WriteLine("familyName: " + n.familyName);
        //                    Console.WriteLine("givenName: " + n.givenName);
        //                    Console.WriteLine("middleName: " + n.middleName);
        //                    Console.WriteLine("suffix: " + n.suffix);
        //                }
        //                Console.WriteLine("##### END OTHERNAME #####");
        //                Console.WriteLine(": " + c.localId);

        //                Console.WriteLine("##### BEGIN OTHERIDS #####");
        //                foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //                {
        //                    Console.WriteLine("id: " + id.id);
        //                    Console.WriteLine("type: " + id.type);
        //                }
        //                Console.WriteLine("##### END OTHERIDS #####");
        //                Console.WriteLine("##### BEGIN ADDRESS #####");
        //                Console.WriteLine("addressType: " + c.address.addressType);
        //                Console.WriteLine("city: " + c.address.city);
        //                Console.WriteLine("line1: " + c.address.line1);
        //                Console.WriteLine("line2: " + c.address.line2);
        //                Console.WriteLine("countryCode: " + c.address.countryCode);
        //                Console.WriteLine("postalCode: " + c.address.postalCode);
        //                Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END ADDRESS #####");
        //                Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END PHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //                foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //                {
        //                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //                }
        //                Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN EMAIL #####");
        //                Console.WriteLine("emailType: " + c.email.emailType);
        //                Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //                Console.WriteLine("##### END EMAIL #####");
        //                Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //                foreach (XEmailType e in c.otherEmails.email)
        //                {
        //                    Console.WriteLine("emailType: " + e.emailType);
        //                    Console.WriteLine("emailAddress: " + e.emailAddress);
        //                }
        //                Console.WriteLine("##### END OTHEREMAILS #####");
        //                Console.WriteLine(": " + c.sex);
        //                Console.WriteLine(": " + c.employerType);
        //                Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //                foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //                {
        //                    Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                    Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                    Console.WriteLine("restrictions: " + csr.restrictions);
        //                    Console.WriteLine("livesWith: " + csr.livesWith);
        //                    Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                    Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                    Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                    Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                    Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                    Console.WriteLine("contactSequence: " + csr.contactSequence);
        //                }
        //                Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            }
        //            Console.WriteLine("##### END STUDENTCONTACTS #####");
        //            Console.WriteLine("##### BEGIN LANGUAGES #####");
        //            foreach (XLanguageType l in s.languages.language)
        //            {
        //                Console.WriteLine("type: " + l.type);
        //                Console.WriteLine("code: " + l.code);
        //            }
        //            Console.WriteLine("##### END LANGUAGES #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN STUDENTS BY CONTACT
        //public static void XStudents_GetXStudentsByXContact(XPress xPress)
        //{
        //    if (xPress.GetXStudentsByXContact(refId).Data != null)
        //    {
        //        foreach (XStudentType s in xPress.GetXStudentsByXContact(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + s.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + s.name.type);
        //            Console.WriteLine("prefix: " + s.name.prefix);
        //            Console.WriteLine("familyName: " + s.name.familyName);
        //            Console.WriteLine("givenName: " + s.name.givenName);
        //            Console.WriteLine("middleName: " + s.name.middleName);
        //            Console.WriteLine("suffix: " + s.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in s.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + s.localId);

        //            Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in s.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + s.address.addressType);
        //            Console.WriteLine("city: " + s.address.city);
        //            Console.WriteLine("line1: " + s.address.line1);
        //            Console.WriteLine("line2: " + s.address.line2);
        //            Console.WriteLine("countryCode: " + s.address.countryCode);
        //            Console.WriteLine("postalCode: " + s.address.postalCode);
        //            Console.WriteLine("stateProvince: " + s.address.stateProvince);
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + s.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + s.email.emailType);
        //            Console.WriteLine("emailAddress: " + s.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in s.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN RACES #####");
        //            foreach (XRaceType r in s.demographics.races.race)
        //            {
        //                Console.WriteLine("race: " + r.race);
        //            }
        //            Console.WriteLine("##### END RACES #####");
        //            Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
        //            Console.WriteLine("sex: " + s.demographics.sex);
        //            Console.WriteLine("birthDate: " + s.demographics.birthDate);
        //            Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
        //            Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
        //            Console.WriteLine("##### END DEMOGRAPHICS #####");
        //            Console.WriteLine("##### BEGIN ENROLLMENT #####");
        //            Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
        //            Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
        //            Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
        //            Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
        //            Console.WriteLine("membershipType: " + s.enrollment.membershipType);
        //            Console.WriteLine("entryDate: " + s.enrollment.entryDate);
        //            Console.WriteLine("exitDate: " + s.enrollment.exitDate);
        //            Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
        //            Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //            Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
        //            Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
        //            Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //            Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
        //            Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
        //            Console.WriteLine("##### BEGIN COUNSELOR #####");
        //            Console.WriteLine("refId: " + s.enrollment.counselor.refId);
        //            Console.WriteLine("localId: " + s.enrollment.counselor.localId);
        //            Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
        //            Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
        //            Console.WriteLine("##### END COUNSELOR #####");
        //            Console.WriteLine("##### END ENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
        //            foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
        //            {
        //                Console.WriteLine("leaRefId: " + e.leaRefId);
        //                Console.WriteLine("schoolRefId: " + e.schoolRefId);
        //                Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
        //                Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
        //                Console.WriteLine("membershipType: " + e.membershipType);
        //                Console.WriteLine("entryDate: " + e.entryDate);
        //                Console.WriteLine("exitDate: " + e.exitDate);
        //                Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
        //                Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
        //                Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
        //                Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
        //                Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
        //                Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
        //                Console.WriteLine("##### END HOMEROOMTEACHER #####");
        //                Console.WriteLine("gradeLevel: " + e.gradeLevel);
        //                Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
        //                Console.WriteLine("##### BEGIN COUNSELOR #####");
        //                Console.WriteLine("refId: " + e.counselor.refId);
        //                Console.WriteLine("localId: " + e.counselor.localId);
        //                Console.WriteLine("givenName: " + e.counselor.givenName);
        //                Console.WriteLine("familyName: " + e.counselor.familyName);
        //                Console.WriteLine("##### END COUNSELOR #####");
        //            }
        //            Console.WriteLine("##### END OTHERENROLLMENT #####");
        //            Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
        //            Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
        //            Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
        //            Console.WriteLine("classRank: " + s.academicSummary.classRank);
        //            Console.WriteLine("##### END ACADEMICSUMMARY #####");
        //            Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
        //            foreach (String contactRefid in s.studentContacts.contactPersonRefId)
        //            {
        //                Console.WriteLine("contactPersonRefId: " + contactRefid);
        //            }
        //            foreach (XContactType c in s.studentContacts.xContact)
        //            {
        //                Console.WriteLine("##### BEGIN NAME #####");
        //                Console.WriteLine("type: " + c.name.type);
        //                Console.WriteLine("prefix: " + c.name.prefix);
        //                Console.WriteLine("familyName: " + c.name.familyName);
        //                Console.WriteLine("givenName: " + c.name.givenName);
        //                Console.WriteLine("middleName: " + c.name.middleName);
        //                Console.WriteLine("suffix: " + c.name.suffix);
        //                Console.WriteLine("##### END NAME #####");
        //                Console.WriteLine("##### BEGIN OTHERNAME #####");
        //                foreach (XPersonNameType n in c.otherNames.name)
        //                {
        //                    Console.WriteLine("type: " + n.type);
        //                    Console.WriteLine("prefix: " + n.prefix);
        //                    Console.WriteLine("familyName: " + n.familyName);
        //                    Console.WriteLine("givenName: " + n.givenName);
        //                    Console.WriteLine("middleName: " + n.middleName);
        //                    Console.WriteLine("suffix: " + n.suffix);
        //                }
        //                Console.WriteLine("##### END OTHERNAME #####");
        //                Console.WriteLine(": " + c.localId);

        //                Console.WriteLine("##### BEGIN OTHERIDS #####");
        //                foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //                {
        //                    Console.WriteLine("id: " + id.id);
        //                    Console.WriteLine("type: " + id.type);
        //                }
        //                Console.WriteLine("##### END OTHERIDS #####");
        //                Console.WriteLine("##### BEGIN ADDRESS #####");
        //                Console.WriteLine("addressType: " + c.address.addressType);
        //                Console.WriteLine("city: " + c.address.city);
        //                Console.WriteLine("line1: " + c.address.line1);
        //                Console.WriteLine("line2: " + c.address.line2);
        //                Console.WriteLine("countryCode: " + c.address.countryCode);
        //                Console.WriteLine("postalCode: " + c.address.postalCode);
        //                Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END ADDRESS #####");
        //                Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //                Console.WriteLine("number: " + c.phoneNumber.number);
        //                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //                Console.WriteLine("##### END PHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //                foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //                {
        //                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //                }
        //                Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //                Console.WriteLine("##### BEGIN EMAIL #####");
        //                Console.WriteLine("emailType: " + c.email.emailType);
        //                Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //                Console.WriteLine("##### END EMAIL #####");
        //                Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //                foreach (XEmailType e in c.otherEmails.email)
        //                {
        //                    Console.WriteLine("emailType: " + e.emailType);
        //                    Console.WriteLine("emailAddress: " + e.emailAddress);
        //                }
        //                Console.WriteLine("##### END OTHEREMAILS #####");
        //                Console.WriteLine(": " + c.sex);
        //                Console.WriteLine(": " + c.employerType);
        //                Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //                foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //                {
        //                    Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                    Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                    Console.WriteLine("restrictions: " + csr.restrictions);
        //                    Console.WriteLine("livesWith: " + csr.livesWith);
        //                    Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                    Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                    Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                    Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                    Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                    Console.WriteLine("contactSequence: " + csr.contactSequence);
        //                }
        //                Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            }
        //            Console.WriteLine("##### END STUDENTCONTACTS #####");
        //            Console.WriteLine("##### BEGIN LANGUAGES #####");
        //            foreach (XLanguageType l in s.languages.language)
        //            {
        //                Console.WriteLine("type: " + l.type);
        //                Console.WriteLine("code: " + l.code);
        //            }
        //            Console.WriteLine("##### END LANGUAGES #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        //#endregion

        //#region xContacts
        ////RETURN ALL CONTACTS
        //public static void XContacts_GetXContacts(XPress xPress)
        //{
        //    if (xPress.GetXContacts().Data != null)
        //    {
        //        foreach (XContactType c in xPress.GetXContacts().Data)
        //        {
        //            Console.WriteLine("refId: " + c.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + c.name.type);
        //            Console.WriteLine("prefix: " + c.name.prefix);
        //            Console.WriteLine("familyName: " + c.name.familyName);
        //            Console.WriteLine("givenName: " + c.name.givenName);
        //            Console.WriteLine("middleName: " + c.name.middleName);
        //            Console.WriteLine("suffix: " + c.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in c.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + c.localId);
        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + c.address.addressType);
        //            Console.WriteLine("city: " + c.address.city);
        //            Console.WriteLine("line1: " + c.address.line1);
        //            Console.WriteLine("line2: " + c.address.line2);
        //            Console.WriteLine("countryCode: " + c.address.countryCode);
        //            Console.WriteLine("postalCode: " + c.address.postalCode);
        //            Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + c.email.emailType);
        //            Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in c.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("sex: " + c.sex);
        //            Console.WriteLine("employerType: " + c.employerType);
        //            Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //            foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //            {
        //                Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                Console.WriteLine("restrictions: " + csr.restrictions);
        //                Console.WriteLine("livesWith: " + csr.livesWith);
        //                Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                Console.WriteLine("contactSequence: " + csr.contactSequence);
        //            }
        //            Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN SINGLE CONTACT
        //public static void XContacts_GetXContact(XPress xPress)
        //{
        //    if (xPress.GetXContact(refId).Data != null)
        //    {
        //        XContactType c = xPress.GetXContact(refId).Data;

        //        Console.WriteLine("refId: " + c.refId);
        //        Console.WriteLine("##### BEGIN NAME #####");
        //        Console.WriteLine("type: " + c.name.type);
        //        Console.WriteLine("prefix: " + c.name.prefix);
        //        Console.WriteLine("familyName: " + c.name.familyName);
        //        Console.WriteLine("givenName: " + c.name.givenName);
        //        Console.WriteLine("middleName: " + c.name.middleName);
        //        Console.WriteLine("suffix: " + c.name.suffix);
        //        Console.WriteLine("##### END NAME #####");
        //        Console.WriteLine("##### BEGIN OTHERNAME #####");
        //        foreach (XPersonNameType n in c.otherNames.name)
        //        {
        //            Console.WriteLine("type: " + n.type);
        //            Console.WriteLine("prefix: " + n.prefix);
        //            Console.WriteLine("familyName: " + n.familyName);
        //            Console.WriteLine("givenName: " + n.givenName);
        //            Console.WriteLine("middleName: " + n.middleName);
        //            Console.WriteLine("suffix: " + n.suffix);
        //        }
        //        Console.WriteLine("##### END OTHERNAME #####");

        //        Console.WriteLine("localId: " + c.localId);

        //        Console.WriteLine("##### BEGIN OTHERIDS #####");
        //        foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //        {
        //            Console.WriteLine("id: " + id.id);
        //            Console.WriteLine("type: " + id.type);
        //        }
        //        Console.WriteLine("##### END OTHERIDS #####");
        //        Console.WriteLine("##### BEGIN ADDRESS #####");
        //        Console.WriteLine("addressType: " + c.address.addressType);
        //        Console.WriteLine("city: " + c.address.city);
        //        Console.WriteLine("line1: " + c.address.line1);
        //        Console.WriteLine("line2: " + c.address.line2);
        //        Console.WriteLine("countryCode: " + c.address.countryCode);
        //        Console.WriteLine("postalCode: " + c.address.postalCode);
        //        Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //        Console.WriteLine("number: " + c.phoneNumber.number);
        //        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //        Console.WriteLine("##### END ADDRESS #####");
        //        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //        Console.WriteLine("number: " + c.phoneNumber.number);
        //        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //        Console.WriteLine("##### END PHONENUMBERS #####");
        //        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //        {
        //            Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //        }
        //        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //        Console.WriteLine("##### BEGIN EMAIL #####");
        //        Console.WriteLine("emailType: " + c.email.emailType);
        //        Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //        Console.WriteLine("##### END EMAIL #####");
        //        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //        foreach (XEmailType e in c.otherEmails.email)
        //        {
        //            Console.WriteLine("emailType: " + e.emailType);
        //            Console.WriteLine("emailAddress: " + e.emailAddress);
        //        }
        //        Console.WriteLine("##### END OTHEREMAILS #####");
        //        Console.WriteLine("sex: " + c.sex);
        //        Console.WriteLine("employerType: " + c.employerType);
        //        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //        {
        //            Console.WriteLine("studentRefId: " + csr.studentRefId);
        //            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //            Console.WriteLine("restrictions: " + csr.restrictions);
        //            Console.WriteLine("livesWith: " + csr.livesWith);
        //            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //            Console.WriteLine("contactSequence: " + csr.contactSequence);
        //        }
        //        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //        Console.WriteLine("========================================");
        //    }
        //}
        ////RETURN CONTACTS BY LEA
        //public static void XContacts_GetXContactsByXLea(XPress xPress)
        //{
        //    if (xPress.GetXContactsByXLea(LEA_REFID).Data != null)
        //    {
        //        foreach (XContactType c in xPress.GetXContactsByXLea(LEA_REFID).Data)
        //        {
        //            Console.WriteLine("refId: " + c.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + c.name.type);
        //            Console.WriteLine("prefix: " + c.name.prefix);
        //            Console.WriteLine("familyName: " + c.name.familyName);
        //            Console.WriteLine("givenName: " + c.name.givenName);
        //            Console.WriteLine("middleName: " + c.name.middleName);
        //            Console.WriteLine("suffix: " + c.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in c.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + c.localId);

        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + c.address.addressType);
        //            Console.WriteLine("city: " + c.address.city);
        //            Console.WriteLine("line1: " + c.address.line1);
        //            Console.WriteLine("line2: " + c.address.line2);
        //            Console.WriteLine("countryCode: " + c.address.countryCode);
        //            Console.WriteLine("postalCode: " + c.address.postalCode);
        //            Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + c.email.emailType);
        //            Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in c.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("sex: " + c.sex);
        //            Console.WriteLine("employerType: " + c.employerType);
        //            Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //            foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //            {
        //                Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                Console.WriteLine("restrictions: " + csr.restrictions);
        //                Console.WriteLine("livesWith: " + csr.livesWith);
        //                Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                Console.WriteLine("contactSequence: " + csr.contactSequence);
        //            }
        //            Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN CONTACTS BY SCHOOL
        //public static void XContacts_GetXContactsByXSchool(XPress xPress)
        //{
        //    if (xPress.GetXContactsByXSchool(refId).Data != null)
        //    {
        //        foreach (XContactType c in xPress.GetXContactsByXSchool(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + c.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + c.name.type);
        //            Console.WriteLine("prefix: " + c.name.prefix);
        //            Console.WriteLine("familyName: " + c.name.familyName);
        //            Console.WriteLine("givenName: " + c.name.givenName);
        //            Console.WriteLine("middleName: " + c.name.middleName);
        //            Console.WriteLine("suffix: " + c.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in c.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + c.localId);

        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + c.address.addressType);
        //            Console.WriteLine("city: " + c.address.city);
        //            Console.WriteLine("line1: " + c.address.line1);
        //            Console.WriteLine("line2: " + c.address.line2);
        //            Console.WriteLine("countryCode: " + c.address.countryCode);
        //            Console.WriteLine("postalCode: " + c.address.postalCode);
        //            Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + c.email.emailType);
        //            Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in c.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("sex: " + c.sex);
        //            Console.WriteLine("employerType: " + c.employerType);
        //            Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //            foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //            {
        //                Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                Console.WriteLine("restrictions: " + csr.restrictions);
        //                Console.WriteLine("livesWith: " + csr.livesWith);
        //                Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                Console.WriteLine("contactSequence: " + csr.contactSequence);
        //            }
        //            Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        ////RETURN CONTACTS BY STUDENT
        //public static void XContacts_GetXContactsByXStudent(XPress xPress)
        //{
        //    if (xPress.GetXContactsByXStudent(refId).Data != null)
        //    {
        //        foreach (XContactType c in xPress.GetXContactsByXStudent(refId).Data)
        //        {
        //            Console.WriteLine("refId: " + c.refId);
        //            Console.WriteLine("##### BEGIN NAME #####");
        //            Console.WriteLine("type: " + c.name.type);
        //            Console.WriteLine("prefix: " + c.name.prefix);
        //            Console.WriteLine("familyName: " + c.name.familyName);
        //            Console.WriteLine("givenName: " + c.name.givenName);
        //            Console.WriteLine("middleName: " + c.name.middleName);
        //            Console.WriteLine("suffix: " + c.name.suffix);
        //            Console.WriteLine("##### END NAME #####");
        //            Console.WriteLine("##### BEGIN OTHERNAME #####");
        //            foreach (XPersonNameType n in c.otherNames.name)
        //            {
        //                Console.WriteLine("type: " + n.type);
        //                Console.WriteLine("prefix: " + n.prefix);
        //                Console.WriteLine("familyName: " + n.familyName);
        //                Console.WriteLine("givenName: " + n.givenName);
        //                Console.WriteLine("middleName: " + n.middleName);
        //                Console.WriteLine("suffix: " + n.suffix);
        //            }
        //            Console.WriteLine("##### END OTHERNAME #####");

        //            Console.WriteLine("localId: " + c.localId);

        //            Console.WriteLine("##### BEGIN OTHERIDS #####");
        //            foreach (XOtherPersonIdType id in c.otherIds.otherId)
        //            {
        //                Console.WriteLine("id: " + id.id);
        //                Console.WriteLine("type: " + id.type);
        //            }
        //            Console.WriteLine("##### END OTHERIDS #####");
        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + c.address.addressType);
        //            Console.WriteLine("city: " + c.address.city);
        //            Console.WriteLine("line1: " + c.address.line1);
        //            Console.WriteLine("line2: " + c.address.line2);
        //            Console.WriteLine("countryCode: " + c.address.countryCode);
        //            Console.WriteLine("postalCode: " + c.address.postalCode);
        //            Console.WriteLine("stateProvince: " + c.address.stateProvince);
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBERS #####");
        //            Console.WriteLine("number: " + c.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
        //            foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("otherPhoneNumbers number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBERS #####");
        //            Console.WriteLine("##### BEGIN EMAIL #####");
        //            Console.WriteLine("emailType: " + c.email.emailType);
        //            Console.WriteLine("emailAddress: " + c.email.emailAddress);
        //            Console.WriteLine("##### END EMAIL #####");
        //            Console.WriteLine("##### BEGIN OTHEREMAILS #####");
        //            foreach (XEmailType e in c.otherEmails.email)
        //            {
        //                Console.WriteLine("emailType: " + e.emailType);
        //                Console.WriteLine("emailAddress: " + e.emailAddress);
        //            }
        //            Console.WriteLine("##### END OTHEREMAILS #####");
        //            Console.WriteLine("sex: " + c.sex);
        //            Console.WriteLine("employerType: " + c.employerType);
        //            Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
        //            foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
        //            {
        //                Console.WriteLine("studentRefId: " + csr.studentRefId);
        //                Console.WriteLine("relationshipCode: " + csr.relationshipCode);
        //                Console.WriteLine("restrictions: " + csr.restrictions);
        //                Console.WriteLine("livesWith: " + csr.livesWith);
        //                Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
        //                Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
        //                Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
        //                Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
        //                Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
        //                Console.WriteLine("contactSequence: " + csr.contactSequence);
        //            }
        //            Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
        //            Console.WriteLine("========================================");
        //        }
        //    }
        //}
        //#endregion
    }
}
