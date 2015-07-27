using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.SifXpress;

namespace RicOneApi.Tests
{
    class Program
    { 
        #region Test Constants
        const string username = "Full_3";
        const string password = "Full_3";
        //const string providerId = "North East Regional Information Center - productio";
        const string providerId = "SCRIC - Test Data Provider 1";
        //static int navigationPage = 1;
        //static int navigationPageSize = 2;
        //static int navigationPageSize = 100;

        //Null:
        static string refId = null;
        //Lea:         
        //static string refId = "9BA8379D-9A9D-4D59-9202-E976CADF5526";
        //School:      
        //static string refId = "66667705-6C51-4C30-A22A-77CEA0FBCF53";
        //Calendar:
        //static string refId = "B0FD06FD-5F35-4D96-B2EA-AA96CD2D0F38";
        //Course:
        //static string refId = "C9DEA47A-DB79-4912-B5F4-03EB50C2A99F";
        //Roster:
        //static string refId = "4BDC482E-B0CA-4D36-B5EC-607E06D08727";
        //Staff:
        //static string refId = "61126B90-2AF9-4176-9377-005686D1B855";
        //Student:
        //static string refId = "0AC93DFD-DC1C-48A4-9D37-000210E4C952";
        //static string refId = "D47B7B88-CE17-44FB-B94F-0000E5BA0532";
        //Contact:
        //static string refId = "9a7345c7-72bd-4672-aee2-001876903ad8";
        //static string refId = "128592BC-691D-4ED0-9493-0007D6966142";
        #endregion

        static void Main(string[] args)
        {
            Authenticator auth = new Authenticator(username, password);
            //Get endpoints by provider
            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                RicOneApiClient ricOne = new RicOneApiClient(e);
                
                #region xLeas
                //XLeas_GetXLeas(ricOne);
                //XLeas_GetXLea(ricOne);
                //XLeas_GetXLeasByXSchool(ricOne);
                //XLeas_GetXLeasByXStudent(ricOne);
                //XLeas_GetXLeasByXContact(ricOne);
                #endregion

                #region xSchools
                //XSchools_GetXSchools(ricOne);
                //XSchools_GetXSchool(ricOne);
                //XSchools_GetXSchoolsByXLea(ricOne);
                //XSchools_GetXSchoolsByXCalendar(ricOne);
                //XSchools_GetXSchoolsByXCourse(ricOne);
                //XSchools_GetXSchoolsByXRoster(ricOne);
                //XSchools_GetXSchoolsByXStaff(ricOne);
                //XSchools_GetXSchoolsByXStudent(ricOne);
                //XSchools_GetXSchoolsByXContact(ricOne);
                #endregion

                #region xCalendars

                //XCalendars_GetXCalendars(ricOne);
                //XCalendars_GetXCalendar(ricOne);
                //XCalendars_GetXCalendarsByXSchool(ricOne);

                #endregion

                #region xCourses

                //XCourses_GetXCourses(ricOne);
                //XCourses_GetXCourse(ricOne);
                //XCourses_GetXCoursesByXLea(ricOne);

                #endregion

                #region xRosters

                //XRosters_GetXRosters(ricOne);
                //XRosters_GetXRoster(ricOne);
                //XRosters_GetXRostersByXLea(ricOne);
                //XRosters_GetXRostersByXSchool(ricOne);
                //XRosters_GetXRostersByXCourse(ricOne);
                //XRosters_GetXRostersByXStaff(ricOne);
                //XRosters_GetXRostersByXStudent(ricOne);

                #endregion

                #region xStaffs
                //XStaffs_GetXStaffs(ricOne);
                //XStaffs_GetXStaff(ricOne);
                //XStaffs_GetXStaffsByXLea(ricOne);
                //XStaffs_GetXStaffsByXSchool(ricOne);
                //XStaffs_GetXStaffsByXCourse(ricOne);
                //XStaffs_GetXStaffsByXRoster(ricOne);
                #endregion

                #region xStudents
                //XStudents_GetXStudents(ricOne);
                //XStudents_GetXStudent(ricOne);
                //XStudents_GetXStudentsByXLea(ricOne);
                //XStudents_GetXStudentsByXSchool(ricOne);
                //XStudents_GetXStudentsByXRoster(ricOne);
                //XStudents_GetXStudentsByXStaff(ricOne);
                //XStudents_GetXStudentsByXContact(ricOne);
                #endregion

                #region xContacts
                //XContacts_GetXContacts(ricOne);
                //XContacts_GetXContact(ricOne);
                //XContacts_GetXContactsByXLea(ricOne);
                //XContacts_GetXContactsByXSchool(ricOne);
                //XContacts_GetXContactsByXStudent(ricOne);
                #endregion

                #region navigationLastPage
                
                #region xLeas
                //XLeas_GetXLeasLastPage(ricOne);
                //XLeas_GetXLeasByXSchoolLastPage(ricOne);
                //XLeas_GetXLeasByXStudentLastPage(ricOne);
                //XLeas_GetXLeasByXContactLastPage(ricOne);
                #endregion

                #region xSchools
                //XSchools_GetXSchoolsLastPage(ricOne);
                //XSchools_GetXSchoolsByXLeaLastPage(ricOne);
                //XSchools_GetXSchoolsByXCalendarLastPage(ricOne);
                //XSchools_GetXSchoolsByXCourseLastPage(ricOne);
                //XSchools_GetXSchoolsByXRosterLastPage(ricOne);
                //XSchools_GetXSchoolsByXStaffLastPage(ricOne);
                //XSchools_GetXSchoolsByXStudentLastPage(ricOne);
                //XSchools_GetXSchoolsByXContactLastPage(ricOne);
                #endregion

                #region xCalendars
                //XCalendars_GetXCalendarsLastPage(ricOne);
                //XCalendars_GetXCalendarsByXSchoolLastPage(ricOne);
                #endregion

                #region xCourses
                //XCourses_GetXCoursesLastPage(ricOne);
                //XCourses_GetXCoursesByXLeaLastPage(ricOne);
                #endregion

                #region xRosters
                //XRosters_GetXRostersLastPage(ricOne);
                //XRosters_GetXRostersByXLeaLastPage(ricOne);
                //XRosters_GetXRostersByXSchoolLastPage(ricOne);
                //XRosters_GetXRostersByXCourseLastPage(ricOne);
                //XRosters_GetXRostersByXStaffLastPage(ricOne);
                //XRosters_GetXRostersByXStudentLastPage(ricOne);
                #endregion

                #region xStaffs
                //XStaffs_GetXStaffsLastPage(ricOne);
                //XStaffs_GetXStaffsByXLeaLastPage(ricOne);
                //XStaffs_GetXStaffsByXSchoolLastPage(ricOne);
                //XStaffs_GetXStaffsByXCourseLastPage(ricOne);
                //XStaffs_GetXStaffsByXRosterLastPage(ricOne);
                #endregion

                #region xStudents
                //XStudents_GetXStudentsLastPage(ricOne);
                //XStudents_GetXStudentsByXLeaLastPage(ricOne);
                //XStudents_GetXStudentsByXSchoolLastPage(ricOne);
                //XStudents_GetXStudentsByXRosterLastPage(ricOne);
                //XStudents_GetXStudentsByXStaffLastPage(ricOne);
                //XStudents_GetXStudentsByXContactLastPage(ricOne);
                #endregion

                #region xContacts
                //XContacts_GetXContactsLastPage(ricOne);
                //XContacts_GetXContactsByXLeaLastPage(ricOne);
                //XContacts_GetXContactsByXSchoolLastPage(ricOne);
                //XContacts_GetXContactsByXStudentLastPage(ricOne);
                #endregion
                #endregion


            }

            Console.ReadLine();
        }

        #region xLeas

        //RETURN ALL LEAS
        public static void XLeas_GetXLeas(RicOneApiClient ricOne)
        {
            foreach (XLeaType lea in ricOne.sifXpress.GetXLeas())
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
        //RETURN SINGLE LEA
        public static void XLeas_GetXLea(RicOneApiClient ricOne)
        {
            XLeaType lea = ricOne.sifXpress.GetXLea(refId);

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
        //RETURN LEAS BY SCHOOL
        public static void XLeas_GetXLeasByXSchool(RicOneApiClient ricOne)
        {
            foreach (XLeaType lea in ricOne.sifXpress.GetXLeasByXSchool(refId))
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
        //RETURN LEAS BY STUDENT
        public static void XLeas_GetXLeasByXStudent(RicOneApiClient ricOne)
        {
            foreach (XLeaType lea in ricOne.sifXpress.GetXLeasByXStudent(refId))
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
        //RETURN LEAS BY CONTACT
        public static void XLeas_GetXLeasByXContact(RicOneApiClient ricOne)
        {
            foreach (XLeaType lea in ricOne.sifXpress.GetXLeasByXContact(refId))
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
        
        #endregion

        #region xSchools
        //RETURN ALL SCHOOLS
        public static void XSchools_GetXSchools(RicOneApiClient ricOne)
        {
            foreach (XSchoolType school in ricOne.sifXpress.GetXSchools())
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
                Console.WriteLine("##### BEGIN YEARGROUPS #####");
                foreach (String yg in school.yearGroups.yearGroup)
                {
                    Console.WriteLine("yearGroup: " + yg);
                }
                Console.WriteLine("##### END YEARGROUPS #####");
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
        }
        //RETURN SINGLE SCHOOL
        public static void XSchools_GetXSchool(RicOneApiClient ricOne)
        {
            XSchoolType school = ricOne.sifXpress.GetXSchool(refId);

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
            Console.WriteLine("##### BEGIN YEARGROUPS #####");
            foreach (String yg in school.yearGroups.yearGroup)
            {
                Console.WriteLine("yearGroup: " + yg);
            }
            Console.WriteLine("##### END YEARGROUPS #####");
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
        //RETURN SCHOOLS BY LEA
        public static void XSchools_GetXSchoolsByXLea(RicOneApiClient ricOne)
        {
            foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXLea(refId))
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
                Console.WriteLine("##### BEGIN YEARGROUPS #####");
                foreach (String yg in school.yearGroups.yearGroup)
                {
                    Console.WriteLine("yearGroup: " + yg);
                }
                Console.WriteLine("##### END YEARGROUPS #####");
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
        }
        //RETURN SCHOOLS BY CALENDAR
        public static void XSchools_GetXSchoolsByXCalendar(RicOneApiClient ricOne)
        {
            foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXCalendar(refId))
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
                Console.WriteLine("##### BEGIN YEARGROUPS #####");
                foreach (String yg in school.yearGroups.yearGroup)
                {
                    Console.WriteLine("yearGroup: " + yg);
                }
                Console.WriteLine("##### END YEARGROUPS #####");
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
        }
        //RETURN SCHOOLS BY COURSE
        public static void XSchools_GetXSchoolsByXCourse(RicOneApiClient ricOne)
        {
            foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXCourse(refId))
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
                Console.WriteLine("##### BEGIN YEARGROUPS #####");
                foreach (String yg in school.yearGroups.yearGroup)
                {
                    Console.WriteLine("yearGroup: " + yg);
                }
                Console.WriteLine("##### END YEARGROUPS #####");
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
         }
        //RETURN SCHOOLS BY ROSTER
        public static void XSchools_GetXSchoolsByXRoster(RicOneApiClient ricOne)
         {
             foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXRoster(refId))
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
                 Console.WriteLine("##### BEGIN YEARGROUPS #####");
                 foreach (String yg in school.yearGroups.yearGroup)
                 {
                     Console.WriteLine("yearGroup: " + yg);
                 }
                 Console.WriteLine("##### END YEARGROUPS #####");
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
         }
        //RETURN SCHOOLS BY STAFF
        public static void XSchools_GetXSchoolsByXStaff(RicOneApiClient ricOne)
        {
            foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXStaff(refId))
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
                Console.WriteLine("##### BEGIN YEARGROUPS #####");
                foreach (String yg in school.yearGroups.yearGroup)
                {
                    Console.WriteLine("yearGroup: " + yg);
                }
                Console.WriteLine("##### END YEARGROUPS #####");
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
        }
        //RETURN SCHOOLS BY STUDENT
        public static void XSchools_GetXSchoolsByXStudent(RicOneApiClient ricOne)
        {
            foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXStudent(refId))
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
                Console.WriteLine("##### BEGIN YEARGROUPS #####");
                foreach (String yg in school.yearGroups.yearGroup)
                {
                    Console.WriteLine("yearGroup: " + yg);
                }
                Console.WriteLine("##### END YEARGROUPS #####");
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
        }
        //RETURN SCHOOLS BY CONTACT
        public static void XSchools_GetXSchoolsByXContact(RicOneApiClient ricOne)
        {
            foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXContact(refId))
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
                Console.WriteLine("##### BEGIN YEARGROUPS #####");
                foreach (String yg in school.yearGroups.yearGroup)
                {
                    Console.WriteLine("yearGroup: " + yg);
                }
                Console.WriteLine("##### END YEARGROUPS #####");
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
        }
        #endregion

        #region xCalendars
        //RETURN ALL CALENDARS
        public static void XCalendars_GetXCalendars(RicOneApiClient ricOne)
        {
            foreach (XCalendarType calendar in ricOne.sifXpress.GetXCalendars())
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
        }
        //RETURN SINGLE CALENDAR
        public static void XCalendars_GetXCalendar(RicOneApiClient ricOne)
        {
            XCalendarType calendar = ricOne.sifXpress.GetXCalendar(refId);

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
        //RETURN CALENDARS BY SCHOOL
        public static void XCalendars_GetXCalendarsByXSchool(RicOneApiClient ricOne)
        {
            foreach (XCalendarType calendar in ricOne.sifXpress.GetXCalendarsByXSchool(refId))
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
        }
        #endregion

        #region xCourses
        //RETURN ALL COURSES
        public static void XCourses_GetXCourses(RicOneApiClient ricOne)
        {
            foreach(XCourseType course in ricOne.sifXpress.GetXCourses())
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
        }
        //RETURN SINGLE COURSE
        public static void XCourses_GetXCourse(RicOneApiClient ricOne)
        {
            XCourseType course = ricOne.sifXpress.GetXCourse(refId);
            
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
        //RETURN COURSES BY LEA
        public static void XCourses_GetXCoursesByXLea(RicOneApiClient ricOne)
        {
            foreach (XCourseType course in ricOne.sifXpress.GetXCoursesByXLea(refId))
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
        }
        #endregion

        #region xRosters
        //RETURN ALL ROSTERS
        public static void XRosters_GetXRosters(RicOneApiClient ricOne)
        {
            foreach(XRosterType r in ricOne.sifXpress.GetXRosters())
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
 
        }
        //RETURN SINGLE ROSTER
        public static void XRosters_GetXRoster(RicOneApiClient ricOne)
        {
            XRosterType r = ricOne.sifXpress.GetXRoster(refId);

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
        //RETURN ROSTERS BY LEA
        public static void XRosters_GetXRostersByXLea(RicOneApiClient ricOne)
        {
            foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXLea(refId))
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
        }
        //RETURN ROSTERS BY SCHOOL
        public static void XRosters_GetXRostersByXSchool(RicOneApiClient ricOne)
        {
            foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXSchool(refId))
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
        }
        //RETURN ROSTERS BY CROUSE
        public static void XRosters_GetXRostersByXCourse(RicOneApiClient ricOne)
        {
            foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXCourse(refId))
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
        }
        //RETURN ROSTERS BY STAFF
        public static void XRosters_GetXRostersByXStaff(RicOneApiClient ricOne)
        {
            foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXStaff(refId))
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
        }
        //RETURN ROSTERS BY STUDENT
        public static void XRosters_GetXRostersByXStudent(RicOneApiClient ricOne)
        {
            foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXStudent(refId))
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
        }

        #endregion

        #region xStaffs
        //RETURN ALL STAFFS
        public static void XStaffs_GetXStaffs(RicOneApiClient ricOne)
        {
            foreach (XStaffType s in ricOne.sifXpress.GetXStaffs())
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
                Console.WriteLine("loginId: " + s.loginId);
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
        }
        //RETURN SINGLE STAFF
        public static void XStaffs_GetXStaff(RicOneApiClient ricOne)
        {
            XStaffType s = ricOne.sifXpress.GetXStaff(refId);

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
            Console.WriteLine("loginId: " + s.loginId);
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
        //RETURN STAFFS BY LEA
        public static void XStaffs_GetXStaffsByXLea(RicOneApiClient ricOne)
        {
            foreach (XStaffType s in ricOne.sifXpress.GetXStaffsByXLea(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
        }
        //RETURN STAFFS BY SCHOOL
        public static void XStaffs_GetXStaffsByXSchool(RicOneApiClient ricOne)
        {
            foreach (XStaffType s in ricOne.sifXpress.GetXStaffsByXSchool(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
        }
        //RETURN STAFFS BY COURSE
        public static void XStaffs_GetXStaffsByXCourse(RicOneApiClient ricOne)
        {
            foreach (XStaffType s in ricOne.sifXpress.GetXStaffsByXCourse(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
        }
        //RETURN STAFFS BY ROSTER
        public static void XStaffs_GetXStaffsByXRoster(RicOneApiClient ricOne)
        {
            foreach (XStaffType s in ricOne.sifXpress.GetXStaffsByXRoster(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
        }
        #endregion

        #region xStudents
        //RETURN ALL STUDENTS
        public static void XStudents_GetXStudents(RicOneApiClient ricOne)
        {
            foreach (XStudentType s in ricOne.sifXpress.GetXStudents())
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
                Console.WriteLine("loginId: " + s.loginId);
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
                Console.WriteLine("exitDate: " + s.enrollment.exitDate);
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
                    Console.WriteLine("exitDate: " + e.exitDate);
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
                foreach(String contactRefid in s.studentContacts.contactPersonRefId)
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
                    Console.WriteLine(": " + c.loginId);
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
        }
        //RETURN SINGLE STUDENT
        public static void XStudents_GetXStudent(RicOneApiClient ricOne)
        {
            XStudentType s = ricOne.sifXpress.GetXStudent(refId);

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
            Console.WriteLine("loginId: " + s.loginId);
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
            Console.WriteLine("exitDate: " + s.enrollment.exitDate);
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
                Console.WriteLine("exitDate: " + e.exitDate);
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
                Console.WriteLine(": " + c.loginId);
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
        //RETURN STUDENTS BY LEA
        public static void XStudents_GetXStudentsByXLea(RicOneApiClient ricOne)
        {
            foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXLea(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
                Console.WriteLine("exitDate: " + s.enrollment.exitDate);
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
                    Console.WriteLine("exitDate: " + e.exitDate);
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
                    Console.WriteLine(": " + c.loginId);
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
        }
        //RETURN STUDENTS BY SCHOOL
        public static void XStudents_GetXStudentsByXSchool(RicOneApiClient ricOne) 
        {
            foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXSchool(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
                Console.WriteLine("exitDate: " + s.enrollment.exitDate);
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
                    Console.WriteLine("exitDate: " + e.exitDate);
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
                    Console.WriteLine(": " + c.loginId);
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
        }
        //RETURN STUDENTS BY ROSTER
        public static void XStudents_GetXStudentsByXRoster(RicOneApiClient ricOne)
        {
            foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXRoster(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
                Console.WriteLine("exitDate: " + s.enrollment.exitDate);
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
                    Console.WriteLine("exitDate: " + e.exitDate);
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
                    Console.WriteLine(": " + c.loginId);
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
        }
        //RETURN STUDENTS BY STAFF
        public static void XStudents_GetXStudentsByXStaff(RicOneApiClient ricOne)
        {
            foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXStaff(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
                Console.WriteLine("exitDate: " + s.enrollment.exitDate);
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
                    Console.WriteLine("exitDate: " + e.exitDate);
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
                    Console.WriteLine(": " + c.loginId);
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
        }
        //RETURN STUDENTS BY CONTACT
        public static void XStudents_GetXStudentsByXContact(RicOneApiClient ricOne)
        {
            foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXContact(refId))
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
                Console.WriteLine("loginId: " + s.loginId);
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
                Console.WriteLine("exitDate: " + s.enrollment.exitDate);
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
                    Console.WriteLine("exitDate: " + e.exitDate);
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
                    Console.WriteLine(": " + c.loginId);
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
        }
        #endregion

        #region xContacts
        //RETURN ALL CONTACTS
        public static void XContacts_GetXContacts(RicOneApiClient ricOne)
        {
            foreach (XContactType c in ricOne.sifXpress.GetXContacts())
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
                Console.WriteLine("loginId: " + c.loginId);
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
        }
        //RETURN SINGLE CONTACT
        public static void XContacts_GetXContact(RicOneApiClient ricOne)
        {
            XContactType c = ricOne.sifXpress.GetXContact(refId);

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
            Console.WriteLine("loginId: " + c.loginId);
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
        //RETURN CONTACTS BY LEA
        public static void XContacts_GetXContactsByXLea(RicOneApiClient ricOne)
        {
            foreach (XContactType c in ricOne.sifXpress.GetXContactsByXLea(refId))
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
                Console.WriteLine("loginId: " + c.loginId);
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
        }
        //RETURN CONTACTS BY SCHOOL
        public static void XContacts_GetXContactsByXSchool(RicOneApiClient ricOne)
        {
            foreach (XContactType c in ricOne.sifXpress.GetXContactsByXSchool(refId))
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
                Console.WriteLine("loginId: " + c.loginId);
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
        }
        //RETURN CONTACTS BY STUDENT
        public static void XContacts_GetXContactsByXStudent(RicOneApiClient ricOne)
        {
            foreach (XContactType c in ricOne.sifXpress.GetXContactsByXStudent(refId))
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
                Console.WriteLine("loginId: " + c.loginId);
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
        }
        #endregion

        #region navigationLastPage

        //#region xLeas

        ////RETURN ALL LEAS
        //public static void XLeas_GetXLeasLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXLeas); i++)
        //    {
        //        foreach (XLeaType lea in ricOne.sifXpress.GetXLeas(i, navigationPageSize))
        //        {
        //            Console.WriteLine("refId: " + lea.refId);
        //            Console.WriteLine("leaName: " + lea.leaName);
        //            Console.WriteLine("leaRefId: " + lea.leaRefId);
        //            Console.WriteLine("localId: " + lea.localId);
        //            Console.WriteLine("ncesId: " + lea.ncesId);
        //            Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + lea.address.addressType);
        //            Console.WriteLine("city: " + lea.address.city);
        //            Console.WriteLine("line1: " + lea.address.line1);
        //            Console.WriteLine("line2: " + lea.address.line2);
        //            Console.WriteLine("countryCode: " + lea.address.countryCode);
        //            Console.WriteLine("postalCode: " + lea.address.postalCode);
        //            Console.WriteLine("stateProvince: " + lea.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + lea.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN LEAS BY SCHOOL
        //public static void XLeas_GetXLeasByXSchoolLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXLeasByXSchool, refId); i++)
        //    {
        //        foreach (XLeaType lea in ricOne.sifXpress.GetXLeasByXSchool(refId, i, navigationPageSize))
        //        {
        //            Console.WriteLine("refId: " + lea.refId);
        //            Console.WriteLine("leaName: " + lea.leaName);
        //            Console.WriteLine("leaRefId: " + lea.leaRefId);
        //            Console.WriteLine("localId: " + lea.localId);
        //            Console.WriteLine("ncesId: " + lea.ncesId);
        //            Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + lea.address.addressType);
        //            Console.WriteLine("city: " + lea.address.city);
        //            Console.WriteLine("line1: " + lea.address.line1);
        //            Console.WriteLine("line2: " + lea.address.line2);
        //            Console.WriteLine("countryCode: " + lea.address.countryCode);
        //            Console.WriteLine("postalCode: " + lea.address.postalCode);
        //            Console.WriteLine("stateProvince: " + lea.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + lea.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }

        //}
        ////RETURN LEAS BY STUDENT
        //public static void XLeas_GetXLeasByXStudentLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXLeasByXStudent, refId); i++)
        //    {
        //        foreach (XLeaType lea in ricOne.sifXpress.GetXLeasByXStudent(refId, i, navigationPageSize))
        //        {
        //            Console.WriteLine("refId: " + lea.refId);
        //            Console.WriteLine("leaName: " + lea.leaName);
        //            Console.WriteLine("leaRefId: " + lea.leaRefId);
        //            Console.WriteLine("localId: " + lea.localId);
        //            Console.WriteLine("ncesId: " + lea.ncesId);
        //            Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + lea.address.addressType);
        //            Console.WriteLine("city: " + lea.address.city);
        //            Console.WriteLine("line1: " + lea.address.line1);
        //            Console.WriteLine("line2: " + lea.address.line2);
        //            Console.WriteLine("countryCode: " + lea.address.countryCode);
        //            Console.WriteLine("postalCode: " + lea.address.postalCode);
        //            Console.WriteLine("stateProvince: " + lea.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + lea.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }

        //}
        ////RETURN LEAS BY CONTACT
        //public static void XLeas_GetXLeasByXContactLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXLeas); i++)
        //    {
        //        foreach (XLeaType lea in ricOne.sifXpress.GetXLeas(i, navigationPageSize))
        //        {
        //            Console.WriteLine("refId: " + lea.refId);
        //            Console.WriteLine("leaName: " + lea.leaName);
        //            Console.WriteLine("leaRefId: " + lea.leaRefId);
        //            Console.WriteLine("localId: " + lea.localId);
        //            Console.WriteLine("ncesId: " + lea.ncesId);
        //            Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

        //            Console.WriteLine("##### BEGIN ADDRESS #####");
        //            Console.WriteLine("addressType: " + lea.address.addressType);
        //            Console.WriteLine("city: " + lea.address.city);
        //            Console.WriteLine("line1: " + lea.address.line1);
        //            Console.WriteLine("line2: " + lea.address.line2);
        //            Console.WriteLine("countryCode: " + lea.address.countryCode);
        //            Console.WriteLine("postalCode: " + lea.address.postalCode);
        //            Console.WriteLine("stateProvince: " + lea.address.stateProvince);
        //            Console.WriteLine("##### END ADDRESS #####");
        //            Console.WriteLine("##### BEGIN PHONENUMBER #####");
        //            Console.WriteLine("number: " + lea.phoneNumber.number);
        //            Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
        //            Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
        //            Console.WriteLine("##### END PHONENUMBER #####");
        //            Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
        //            foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
        //            {
        //                Console.WriteLine("number: " + p.number);
        //                Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
        //                Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
        //            }
        //            Console.WriteLine("##### END OTHERPHONENUMBER #####");
        //            Console.WriteLine("========================================");
        //        }
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }

        //}
        //#endregion

        //#region xSchools
        ////RETURN ALL SCHOOLS
        //public static void XSchools_GetXSchoolsLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXSchools); i++)
        //    {
        //        foreach (XSchoolType school in ricOne.sifXpress.GetXSchools(i, navigationPageSize))
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
        //            Console.WriteLine("##### BEGIN YEARGROUPS #####");
        //            foreach (String yg in school.yearGroups.yearGroup)
        //            {
        //                Console.WriteLine("yearGroup: " + yg);
        //            }
        //            Console.WriteLine("##### END YEARGROUPS #####");
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}

        ////RETURN SCHOOLS BY LEA
        //public static void XSchools_GetXSchoolsByXLeaLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXSchoolsByXLea, refId); i++)
        //    {
        //        foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXLea(refId, i, navigationPageSize))
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
        //            Console.WriteLine("##### BEGIN YEARGROUPS #####");
        //            foreach (String yg in school.yearGroups.yearGroup)
        //            {
        //                Console.WriteLine("yearGroup: " + yg);
        //            }
        //            Console.WriteLine("##### END YEARGROUPS #####");
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN SCHOOLS BY CALENDAR
        //public static void XSchools_GetXSchoolsByXCalendarLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXSchoolsByXCalendar, refId); i++)
        //    {
        //        foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXCalendar(refId, i, navigationPageSize))
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
        //            Console.WriteLine("##### BEGIN YEARGROUPS #####");
        //            foreach (String yg in school.yearGroups.yearGroup)
        //            {
        //                Console.WriteLine("yearGroup: " + yg);
        //            }
        //            Console.WriteLine("##### END YEARGROUPS #####");
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN SCHOOLS BY COURSE
        //public static void XSchools_GetXSchoolsByXCourseLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXSchoolsByXCourse, refId); i++)
        //    {
        //        foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXCourse(refId, i, navigationPageSize))
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
        //            Console.WriteLine("##### BEGIN YEARGROUPS #####");
        //            foreach (String yg in school.yearGroups.yearGroup)
        //            {
        //                Console.WriteLine("yearGroup: " + yg);
        //            }
        //            Console.WriteLine("##### END YEARGROUPS #####");
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN SCHOOLS BY ROSTER
        //public static void XSchools_GetXSchoolsByXRosterLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXSchoolsByXRoster, refId); i++)
        //    {
        //        foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXRoster(refId, i, navigationPageSize))
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
        //            Console.WriteLine("##### BEGIN YEARGROUPS #####");
        //            foreach (String yg in school.yearGroups.yearGroup)
        //            {
        //                Console.WriteLine("yearGroup: " + yg);
        //            }
        //            Console.WriteLine("##### END YEARGROUPS #####");
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN SCHOOLS BY STAFF
        //public static void XSchools_GetXSchoolsByXStaffLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXSchoolsByXStaff, refId); i++)
        //    {
        //        foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXStaff(refId, i, navigationPageSize))
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
        //            Console.WriteLine("##### BEGIN YEARGROUPS #####");
        //            foreach (String yg in school.yearGroups.yearGroup)
        //            {
        //                Console.WriteLine("yearGroup: " + yg);
        //            }
        //            Console.WriteLine("##### END YEARGROUPS #####");
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN SCHOOLS BY STUDENT
        //public static void XSchools_GetXSchoolsByXStudentLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXSchoolsByXStudent, refId); i++)
        //    {
        //        foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXStudent(refId, i, navigationPageSize))
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
        //            Console.WriteLine("##### BEGIN YEARGROUPS #####");
        //            foreach (String yg in school.yearGroups.yearGroup)
        //            {
        //                Console.WriteLine("yearGroup: " + yg);
        //            }
        //            Console.WriteLine("##### END YEARGROUPS #####");
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN SCHOOLS BY CONTACT
        //public static void XSchools_GetXSchoolsByXContactLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXSchoolsByXContact, refId); i++)
        //    {
        //        foreach (XSchoolType school in ricOne.sifXpress.GetXSchoolsByXContact(refId, i, navigationPageSize))
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
        //            Console.WriteLine("##### BEGIN YEARGROUPS #####");
        //            foreach (String yg in school.yearGroups.yearGroup)
        //            {
        //                Console.WriteLine("yearGroup: " + yg);
        //            }
        //            Console.WriteLine("##### END YEARGROUPS #####");
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        //#endregion

        //#region xCalendars
        ////RETURN ALL CALENDARS
        //public static void XCalendars_GetXCalendarsLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXCalendars); i++)
        //    {
        //        foreach (XCalendarType calendar in ricOne.sifXpress.GetXCalendars(i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}

        ////RETURN CALENDARS BY SCHOOL
        //public static void XCalendars_GetXCalendarsByXSchoolLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXCalendarsByXSchool, refId); i++)
        //    {
        //        foreach (XCalendarType calendar in ricOne.sifXpress.GetXCalendarsByXSchool(refId, i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        //#endregion

        //#region xCourses
        ////RETURN ALL COURSES
        //public static void XCourses_GetXCoursesLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXCourses); i++)
        //    {
        //        foreach (XCourseType course in ricOne.sifXpress.GetXCourses(i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}

        ////RETURN COURSES BY LEA
        //public static void XCourses_GetXCoursesByXLeaLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXCoursesByXLea, refId); i++)
        //    {
        //        foreach (XCourseType course in ricOne.sifXpress.GetXCoursesByXLea(refId, i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        //#endregion

        //#region xRosters
        ////RETURN ALL ROSTERS
        //public static void XRosters_GetXRostersLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXRosters); i++)
        //    {
        //        foreach (XRosterType r in ricOne.sifXpress.GetXRosters(i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}

        ////RETURN ROSTERS BY LEA
        //public static void XRosters_GetXRostersByXLeaLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXRostersByXLea, refId); i++)
        //    {
        //        foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXLea(refId, i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN ROSTERS BY SCHOOL
        //public static void XRosters_GetXRostersByXSchoolLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXRostersByXSchool, refId); i++)
        //    {
        //        foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXSchool(refId, i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN ROSTERS BY CROUSE
        //public static void XRosters_GetXRostersByXCourseLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXRostersByXCourse, refId); i++)
        //    {
        //        foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXCourse(refId, i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN ROSTERS BY STAFF
        //public static void XRosters_GetXRostersByXStaffLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXRostersByXStaff, refId); i++)
        //    {
        //        foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXStaff(refId, i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN ROSTERS BY STUDENT
        //public static void XRosters_GetXRostersByXStudentLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXRostersByXStudent, refId); i++)
        //    {
        //        foreach (XRosterType r in ricOne.sifXpress.GetXRostersByXStudent(refId, i, navigationPageSize))
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        //#endregion

        //#region xStaffs
        ////RETURN ALL STAFFS
        //public static void XStaffs_GetXStaffsLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStaffs); i++)
        //    {
        //        foreach (XStaffType s in ricOne.sifXpress.GetXStaffs(i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}

        ////RETURN STAFFS BY LEA
        //public static void XStaffs_GetXStaffsByXLeaLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStaffsByXLea, refId); i++)
        //    {
        //        foreach (XStaffType s in ricOne.sifXpress.GetXStaffsByXLea(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN STAFFS BY SCHOOL
        //public static void XStaffs_GetXStaffsByXSchoolLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStaffsByXSchool, refId); i++)
        //    {
        //        foreach (XStaffType s in ricOne.sifXpress.GetXStaffsByXSchool(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN STAFFS BY COURSE
        //public static void XStaffs_GetXStaffsByXCourseLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStaffsByXCourse, refId); i++)
        //    {
        //        foreach (XStaffType s in ricOne.sifXpress.GetXStaffsByXCourse(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN STAFFS BY ROSTER
        //public static void XStaffs_GetXStaffsByXRosterLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStaffsByXRoster, refId); i++)
        //    {
        //        foreach (XStaffType s in ricOne.sifXpress.GetXStaffsByXRoster(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        //#endregion

        //#region xStudents
        ////RETURN ALL STUDENTS
        //public static void XStudents_GetXStudentsLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStudents); i++)
        //    {
        //        foreach (XStudentType s in ricOne.sifXpress.GetXStudents(i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //                Console.WriteLine(": " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}

        ////RETURN STUDENTS BY LEA
        //public static void XStudents_GetXStudentsByXLeaLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStudentsByXLea, refId); i++)
        //    {
        //        foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXLea(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //                Console.WriteLine(": " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN STUDENTS BY SCHOOL
        //public static void XStudents_GetXStudentsByXSchoolLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStudentsByXSchool, refId); i++)
        //    {
        //        foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXSchool(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //                Console.WriteLine(": " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN STUDENTS BY ROSTER
        //public static void XStudents_GetXStudentsByXRosterLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStudentsByXRoster, refId); i++)
        //    {
        //        foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXRoster(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //                Console.WriteLine(": " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN STUDENTS BY STAFF
        //public static void XStudents_GetXStudentsByXStaffLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStudentsByXStaff, refId); i++)
        //    {
        //        foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXStaff(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //                Console.WriteLine(": " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN STUDENTS BY CONTACT
        //public static void XStudents_GetXStudentsByXContactLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXStudentsByXContact, refId); i++)
        //    {
        //        foreach (XStudentType s in ricOne.sifXpress.GetXStudentsByXContact(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + s.loginId);
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
        //                Console.WriteLine(": " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        //#endregion

        //#region xContacts
        ////RETURN ALL CONTACTS
        //public static void XContacts_GetXContactsLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXContacts); i++)
        //    {
        //        foreach (XContactType c in ricOne.sifXpress.GetXContacts(i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}

        ////RETURN CONTACTS BY LEA
        //public static void XContacts_GetXContactsByXLeaLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXContactsByXLea, refId); i++)
        //    {
        //        foreach (XContactType c in ricOne.sifXpress.GetXContactsByXLea(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN CONTACTS BY SCHOOL
        //public static void XContacts_GetXContactsByXSchoolLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXContactsByXSchool, refId); i++)
        //    {
        //        foreach (XContactType c in ricOne.sifXpress.GetXContactsByXSchool(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        ////RETURN CONTACTS BY STUDENT
        //public static void XContacts_GetXContactsByXStudentLastPage(RicOneApiClient ricOne)
        //{
        //    for (int i = 1; i <= ricOne.sifXpress.GetLastPage(navigationPageSize, SifXpress.ServicePath.GetXContactsByXStudent, refId); i++)
        //    {
        //        foreach (XContactType c in ricOne.sifXpress.GetXContactsByXStudent(refId, i, navigationPageSize))
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
        //            Console.WriteLine("loginId: " + c.loginId);
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
        //        Console.WriteLine("######## PAGE " + i + " ########");
        //    }
        //}
        //#endregion
        #endregion
    }
}
