using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RicOneAPI.Models.Authentication;
using RicOneAPI.Models.SIFxPress;
using RicOneAPI;

namespace RicOneAPI.Api
{
    /// <summary>
    /// Static class built off of RICOne client to allow access to SIFxPress data model objects
    /// </summary>
    public class SIFxPress
    {
        private string token;
        private RestClient restClient;
        private string baseApiUrl;

        public SIFxPress(string token, string baseApiUrl, RestClient restClient)
        {
            this.token = token;
            this.baseApiUrl = baseApiUrl;
            this.restClient = restClient;
        }

        # region xLeas
        /// <summary>
        /// Request all Leas
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XLea> GetXLeas(string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeasRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }

        /// <summary>
        /// Request all Leas
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XLea> GetXLeas()
        {
            RestRequest request = new RestRequest("xLeas", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeasRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }


        /// <summary>
        /// Request single Leas by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XLea GetXLea(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeas>(request);

            Util.ResponseHandler(response);

            return response.Data.xLea.First();
        }

        /// <summary>
        /// Request single Leas by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XLea GetXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeas>(request);

            Util.ResponseHandler(response);

            return response.Data.xLea.First();
        }
        /// <summary>
        /// Returns Leas associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XLea> GetXLeasByXSchool(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeasRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }
        /// <summary>
        /// Returns Leas associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XLea> GetXLeasByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeasRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }
        /// <summary>
        /// Returns Leas associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XLea> GetXLeasByXStudent(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeasRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }
        /// <summary>
        /// Returns Leas associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XLea> GetXLeasByXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeasRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }
        /// <summary>
        /// Returns Leas associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XLea> GetXLeasByXContact(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeasRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }
        /// <summary>
        /// Returns Leas associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XLea> GetXLeasByXContact(string refId)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeasRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }

        #endregion

        #region xSchools
        /// <summary>
        /// Request all Schools
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchools(string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Request all Schools
        /// </summary>
        /// <returns></returns>
        public List<XSchool> GetXSchools()
        {
            RestRequest request = new RestRequest("xSchools", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Request single School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public XSchool GetXSchool(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchools>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchool.First();
        }
        /// <summary>
        /// Request single School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XSchool GetXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchools>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchool.First();
        }
        /// <summary>
        /// Returns Schools associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXLea(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXCalendar(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xCalendars/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXCalendar(string refId)
        {
            RestRequest request = new RestRequest("xCalendars/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXCourse(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXCourse(string refId)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXRoster(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXRoster(string refId)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXStaff(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXStaff(string refId)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
      
        /// <summary>
        /// Returns Schools associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXStudent(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXContact(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchool> GetXSchoolsByXContact(string refId)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }

        #endregion
        
        #region xCalendars
        /// <summary>
        /// Request all Calendars
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XCalendar> GetXCalendars(string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xCalendars", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCalendarsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendars.xCalendar;
        }
        /// <summary>
        /// Request all Calendars
        /// </summary>
        /// <returns></returns>
        public List<XCalendar> GetXCalendars()
        {
            RestRequest request = new RestRequest("xCalendars", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendars.xCalendar;
        }
        /// <summary>
        /// Request single Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public XCalendar GetXCalendar(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xCalendars/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCalendars>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendar.First();
        }
        /// <summary>
        /// Request single Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XCalendar GetXCalendar(string refId)
        {
            RestRequest request = new RestRequest("xCalendars/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendars>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendar.First();
        }
        /// <summary>
        /// Returns Calendars associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XCalendar> GetXCalendarsByXSchool(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xCalendars", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCalendarsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendars.xCalendar;
        }
        /// <summary>
        /// Returns Calendars associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XCalendar> GetXCalendarsByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xCalendars", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendars.xCalendar;
        }
        #endregion

        #region xCourses
        /// <summary>
        /// Request all Courses
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XCourse> GetXCourses(string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCoursesRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourses.xCourse;
        }
        /// <summary>
        /// Request all Courses
        /// </summary>
        /// <returns></returns>
        public List<XCourse> GetXCourses()
        {
            RestRequest request = new RestRequest("xCourses", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCoursesRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourses.xCourse;
        }

        /// <summary>
        /// Request single Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public XCourse GetXCourse(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCourses>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourse.First();
        }
        /// <summary>
        /// Request single Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XCourse GetXCourse(string refId)
        {
            RestRequest request = new RestRequest("xCourses/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourses>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourse.First();
        }
        /// <summary>
        /// Returns Courses associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XCourse> GetXCoursesByXLea(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCoursesRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourses.xCourse;
        }
        /// <summary>
        /// Returns Courses associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XCourse> GetXCoursesByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCoursesRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourses.xCourse;
        }

        #endregion

        #region xRosters
        /// <summary>
        /// Request all Rosters
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XRoster> GetXRosters(string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xRosters", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Request all Rosters
        /// </summary>
        /// <returns></returns>
        public List<XRoster> GetXRosters()
        {
            RestRequest request = new RestRequest("xRosters", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Request single Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public XRoster GetXRoster(string refId, string navigationPage, string navigationPageSize)
        {
        RestRequest request = new RestRequest("xRosters/{refId}", Method.GET);
        request.AddParameter("refId", refId, ParameterType.UrlSegment);
        request.AddHeader("Accept", "application/json");

        request.AddParameter("navigationPage", navigationPage);
        request.AddParameter("navigationPageSize", navigationPageSize);

        var response = restClient.Execute<XRosters>(request);

        Util.ResponseHandler(response);

        return response.Data.xRoster.First();
        }
        /// <summary>
        /// Request single Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XRoster GetXRoster(string refId)
        {
        RestRequest request = new RestRequest("xRosters/{refId}", Method.GET);
        request.AddParameter("refId", refId, ParameterType.UrlSegment);
        request.AddHeader("Accept", "application/json");

        var response = restClient.Execute<XRosters>(request);

        Util.ResponseHandler(response);

        return response.Data.xRoster.First();
        }
        /// <summary>
        /// Returns Rosters associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXLea(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXSchool(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXCourse(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXCourse(string refId)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXStaff(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXStaff(string refId)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXStudent(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRoster> GetXRostersByXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRostersRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }

        #endregion

        #region xStaffs
        /// <summary>
        /// Request all Staffs
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffs(string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Request all Staffs
        /// </summary>
        /// <returns></returns>
        public List<XStaff> GetXStaffs()
        {
            RestRequest request = new RestRequest("xStaffs", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Request single Staffs by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public XStaff GetXStaff(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffs>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaff.First();
        }
        /// <summary>
        /// Request single Staffs by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XStaff GetXStaff(string refId)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffs>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaff.First();
        }
        /// <summary>
        /// Returns Staffs associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffsByXLea(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffsByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffsByXSchool(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffsByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffsByXCourse(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffsByXCourse(string refId)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffsByXRoster(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStaff> GetXStaffsByXRoster(string refId)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }

        #endregion

        #region xStudents
        /// <summary>
        /// Request all Students
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudents(string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Request all Students
        /// </summary>
        /// <returns></returns>
        public List<XStudent> GetXStudents()
        {
            RestRequest request = new RestRequest("xStudents", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Request single Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public XStudent GetXStudent(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudents>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudent.First();
        }
        /// <summary>
        /// Request single Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XStudent GetXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudents>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudent.First();
        }
        /// <summary>
        /// Returns Students associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXLea(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXSchool(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXRoster(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXRoster(string refId)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXStaff(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXStaff(string refId)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXContact(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudent> GetXStudentsByXContact(string refId)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }

        #endregion xStudents

        #region xContacts
        /// <summary>
        /// Request all Contacts
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XContact> GetXContacts(string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Request all Contacts
        /// </summary>
        /// <returns></returns>
        public List<XContact> GetXContacts()
        {
            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Request single Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public XContact GetXContact(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContacts>(request);

            Util.ResponseHandler(response);

            return response.Data.xContact.First();
        }
        /// <summary>
        /// Request single Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XContact GetXContact(string refId)
        {
            RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContacts>(request);

            Util.ResponseHandler(response);

            return response.Data.xContact.First();
        }
        /// <summary>
        /// Returns Contacts associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XContact> GetXContactsByXLea(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XContact> GetXContactsByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Returns Contacts associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XContact> GetXContactsByXSchool(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Returns Contacts associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XContact> GetXContactsByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XContact> GetXContactsByXStudent(string refId, string navigationPage, string navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XContact> GetXContactsByXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactsRoot>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }

        #endregion
    }
}
