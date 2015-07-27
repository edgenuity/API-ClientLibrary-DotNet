using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.SifXpress;
using RicOneApi;

namespace RicOneApi.Api
{
    /// <summary>
    /// Static class built off of RICOne client to allow access to SIFxPress data model objects
    /// </summary>
    public class SifXpress
    {
        private string token;
        private RestClient restClient;
        private string baseApiUrl;

        public SifXpress(string token, string baseApiUrl, RestClient restClient)
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
        public List<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeaCollectionType>(request);
            
            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }

        /// <summary>
        /// Request all Leas
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public List<XLeaType> GetXLeas()
        {
            RestRequest request = new RestRequest("xLeas", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);
     
            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }

        /// <summary>
        /// Request single Leas by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XLeaType GetXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeaCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xLea.First();
        }

        /// <summary>
        /// Request single Leas by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XLeaType GetXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

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
        public List<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeaCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }
        /// <summary>
        /// Returns Leas associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XLeaType> GetXLeasByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

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
        public List<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeaCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }
        /// <summary>
        /// Returns Leas associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XLeaType> GetXLeasByXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

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
        public List<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XLeaCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xLeas.xLea;
        }
        /// <summary>
        /// Returns Leas associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XLeaType> GetXLeasByXContact(string refId)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

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
        public List<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Request all Schools
        /// </summary>
        /// <returns></returns>
        public List<XSchoolType> GetXSchools()
        {
            RestRequest request = new RestRequest("xSchools", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public XSchoolType GetXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchool.First();
        }
        /// <summary>
        /// Request single School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XSchoolType GetXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public List<XSchoolType> GetXSchoolsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchoolType> GetXSchoolsByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public List<XSchoolType> GetXSchoolsByXCalendar(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xCalendars/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchoolType> GetXSchoolsByXCalendar(string refId)
        {
            RestRequest request = new RestRequest("xCalendars/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public List<XSchoolType> GetXSchoolsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchoolType> GetXSchoolsByXCourse(string refId)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public List<XSchoolType> GetXSchoolsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchoolType> GetXSchoolsByXRoster(string refId)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public List<XSchoolType> GetXSchoolsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchoolType> GetXSchoolsByXStaff(string refId)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public List<XSchoolType> GetXSchoolsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchoolType> GetXSchoolsByXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public List<XSchoolType> GetXSchoolsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XSchoolCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xSchools.xSchool;
        }
        /// <summary>
        /// Returns Schools associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XSchoolType> GetXSchoolsByXContact(string refId)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

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
        public List<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xCalendars", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCalendarCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendars.xCalendar;
        }
        /// <summary>
        /// Request all Calendars
        /// </summary>
        /// <returns></returns>
        public List<XCalendarType> GetXCalendars()
        {
            RestRequest request = new RestRequest("xCalendars", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarCollectionType>(request);

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
        public XCalendarType GetXCalendar(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xCalendars/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCalendarCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendar.First();
        }
        /// <summary>
        /// Request single Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XCalendarType GetXCalendar(string refId)
        {
            RestRequest request = new RestRequest("xCalendars/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarCollectionType>(request);

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
        public List<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xCalendars", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCalendarCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xCalendars.xCalendar;
        }
        /// <summary>
        /// Returns Calendars associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XCalendarType> GetXCalendarsByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xCalendars", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarCollectionType>(request);

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
        public List<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCourseCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourses.xCourse;
        }
        /// <summary>
        /// Request all Courses
        /// </summary>
        /// <returns></returns>
        public List<XCourseType> GetXCourses()
        {
            RestRequest request = new RestRequest("xCourses", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourseCollectionType>(request);

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
        public XCourseType GetXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCourseCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourse.First();
        }
        /// <summary>
        /// Request single Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XCourseType GetXCourse(string refId)
        {
            RestRequest request = new RestRequest("xCourses/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourseCollectionType>(request);

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
        public List<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XCourseCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xCourses.xCourse;
        }
        /// <summary>
        /// Returns Courses associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XCourseType> GetXCoursesByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourseCollectionType>(request);

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
        public List<XRosterType> GetXRosters(int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xRosters", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRosterCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Request all Rosters
        /// </summary>
        /// <returns></returns>
        public List<XRosterType> GetXRosters()
        {
            RestRequest request = new RestRequest("xRosters", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

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
        public XRosterType GetXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
        RestRequest request = new RestRequest("xRosters/{refId}", Method.GET);
        request.AddParameter("refId", refId, ParameterType.UrlSegment);
        request.AddHeader("Accept", "application/json");

        request.AddParameter("navigationPage", navigationPage);
        request.AddParameter("navigationPageSize", navigationPageSize);

        var response = restClient.Execute<XRosterCollectionType>(request);

        Util.ResponseHandler(response);

        return response.Data.xRoster.First();
        }
        /// <summary>
        /// Request single Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XRosterType GetXRoster(string refId)
        {
        RestRequest request = new RestRequest("xRosters/{refId}", Method.GET);
        request.AddParameter("refId", refId, ParameterType.UrlSegment);
        request.AddHeader("Accept", "application/json");

        var response = restClient.Execute<XRosterCollectionType>(request);

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
        public List<XRosterType> GetXRostersByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRosterCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRosterType> GetXRostersByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

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
        public List<XRosterType> GetXRostersByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRosterCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRosterType> GetXRostersByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

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
        public List<XRosterType> GetXRostersByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRosterCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRosterType> GetXRostersByXCourse(string refId)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

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
        public List<XRosterType> GetXRostersByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRosterCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRosterType> GetXRostersByXStaff(string refId)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

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
        public List<XRosterType> GetXRostersByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XRosterCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xRosters.xRoster;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XRosterType> GetXRostersByXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

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
        public List<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Request all Staffs
        /// </summary>
        /// <returns></returns>
        public List<XStaffType> GetXStaffs()
        {
            RestRequest request = new RestRequest("xStaffs", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

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
        public XStaffType GetXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaff.First();
        }
        /// <summary>
        /// Request single Staffs by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XStaffType GetXStaff(string refId)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

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
        public List<XStaffType> GetXStaffsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStaffType> GetXStaffsByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

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
        public List<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStaffType> GetXStaffsByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

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
        public List<XStaffType> GetXStaffsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStaffType> GetXStaffsByXCourse(string refId)
        {
            RestRequest request = new RestRequest("xCourses/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

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
        public List<XStaffType> GetXStaffsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStaffCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStaffs.xStaff;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStaffType> GetXStaffsByXRoster(string refId)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

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
        public List<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Request all Students
        /// </summary>
        /// <returns></returns>
        public List<XStudentType> GetXStudents()
        {
            RestRequest request = new RestRequest("xStudents", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

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
        public XStudentType GetXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudent.First();
        }
        /// <summary>
        /// Request single Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XStudentType GetXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

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
        public List<XStudentType> GetXStudentsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudentType> GetXStudentsByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

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
        public List<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudentType> GetXStudentsByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

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
        public List<XStudentType> GetXStudentsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudentType> GetXStudentsByXRoster(string refId)
        {
            RestRequest request = new RestRequest("xRosters/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

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
        public List<XStudentType> GetXStudentsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudentType> GetXStudentsByXStaff(string refId)
        {
            RestRequest request = new RestRequest("xStaffs/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

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
        public List<XStudentType> GetXStudentsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XStudentCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xStudents.xStudent;
        }
        /// <summary>
        /// Returns Students associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XStudentType> GetXStudentsByXContact(string refId)
        {
            RestRequest request = new RestRequest("xContacts/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

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
        public List<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Request all Contacts
        /// </summary>
        /// <returns></returns>
        public List<XContactType> GetXContacts()
        {
            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

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
        public XContactType GetXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xContact.First();
        }
        /// <summary>
        /// Request single Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public XContactType GetXContact(string refId)
        {
            RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

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
        public List<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XContactType> GetXContactsByXLea(string refId)
        {
            RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

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
        public List<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Returns Contacts associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XContactType> GetXContactsByXSchool(string refId)
        {
            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

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
        public List<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", navigationPage);
            request.AddParameter("navigationPageSize", navigationPageSize);

            var response = restClient.Execute<XContactCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public List<XContactType> GetXContactsByXStudent(string refId)
        {
            RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            Util.ResponseHandler(response);

            return response.Data.xContacts.xContact;
        }

        #endregion

        #region navigationLastPage

        /// <summary>
        /// Enumerator used to retrieve service path object for max page size
        /// </summary>
        public enum ServicePath
        {
            GetXLeas = 1,
            GetXLeasByXSchool = 2,
            GetXLeasByXStudent = 3,
            GetXLeasByXContact = 4,
            GetXSchools = 5,
            GetXSchoolsByXLea = 6,
            GetXSchoolsByXCalendar = 7,
            GetXSchoolsByXCourse = 8,
            GetXSchoolsByXRoster = 9,
            GetXSchoolsByXStaff = 10,
            GetXSchoolsByXStudent = 11,
            GetXSchoolsByXContact = 12,
            GetXCalendars = 13,
            GetXCalendarsByXSchool = 14,
            GetXCourses = 15,
            GetXCoursesByXLea = 16,
            GetXRosters = 17,
            GetXRostersByXLea = 18,
            GetXRostersByXSchool = 19,
            GetXRostersByXCourse = 20,
            GetXRostersByXStaff = 21,
            GetXRostersByXStudent = 22,
            GetXStaffs = 23,
            GetXStaffsByXLea = 24,
            GetXStaffsByXSchool = 25,
            GetXStaffsByXCourse = 26,
            GetXStaffsByXRoster = 27,
            GetXStudents = 28,
            GetXStudentsByXLea = 29,
            GetXStudentsByXSchool = 30,
            GetXStudentsByXRoster = 31,
            GetXStudentsByXStaff = 32,
            GetXStudentsByXContact = 33,
            GetXContacts = 34,
            GetXContactsByXLea = 35,
            GetXContactsByXSchool = 36,
            GetXContactsByXStudent = 37
        }

        public ServicePath myServicePath { get; set; }
        /// <summary>
        /// Max page value for specified service path object
        /// </summary>
        /// <param name="navigationPageSize"></param>
        /// <param name="p"></param>
        /// <param name="refId"></param>
        /// <returns></returns>
        public int GetLastPage(int navigationPageSize, ServicePath p, string refId)
        {
            string path = "";

            if (p == ServicePath.GetXLeas)
            {
                path = "xLeas";
            }
            else if (p == ServicePath.GetXLeasByXSchool)
            {
                path = "xSchools/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXStudent)
            {
                path = "xStudents/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXContact)
            {
                path = "xContacts/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXSchools)
            {
                path = "xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXLea)
            {
                path = "xLeas/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXCalendar)
            {
                path = "xCalendars/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXCourse)
            {
                path = "xCourses/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXRoster)
            {
                path = "xRosters/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXStaff)
            {
                path = "xStaffs/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXStudent)
            {
                path = "xStudents/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXContact)
            {
                path = "xContacts/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXCalendars)
            {
                path = "xCalendars";
            }
            else if (p == ServicePath.GetXCalendarsByXSchool)
            {
                path = "xSchools/{refId}/xCalendars";
            }
            else if (p == ServicePath.GetXCourses)
            {
                path = "xCourses";
            }
            else if (p == ServicePath.GetXCoursesByXLea)
            {
                path = "xLeas/{refId}/xCourses";
            }
            else if (p == ServicePath.GetXRosters)
            {
                path = "xRosters";
            }
            else if (p == ServicePath.GetXRostersByXLea)
            {
                path = "xLeas/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXSchool)
            {
                path = "xSchools/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXCourse)
            {
                path = "xCourses/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXStaff)
            {
                path = "xStaffs/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXStudent)
            {
                path = "xStudents/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXStaffs)
            {
                path = "xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXLea)
            {
                path = "xLeas/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXSchool)
            {
                path = "xSchools/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXCourse)
            {
                path = "xCourses/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXRoster)
            {
                path = "xRosters/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStudents)
            {
                path = "xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXLea)
            {
                path = "xLeas/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXSchool)
            {
                path = "xSchools/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXRoster)
            {
                path = "xRosters/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXStaff)
            {
                path = "xStaffs/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXContact)
            {
                path = "xContacts/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXContacts)
            {
                path = "xContacts";
            }
            else if (p == ServicePath.GetXContactsByXLea)
            {
                path = "xLeas/{refId}/xContacts";
            }
            else if (p == ServicePath.GetXContactsByXSchool)
            {
                path = "xSchools/{refId}/xContacts";
            }
            else if (p == ServicePath.GetXContactsByXStudent)
            {
                path = "xStudents/{refId}/xContacts";
            }

            RestRequest request = new RestRequest(path, Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddParameter("navigationPage", 1);
            request.AddParameter("navigationPageSize", navigationPageSize);
            
            var response = restClient.Execute(request);

            int navigationLastPage = Int32.Parse(response.Headers.ToList()
            .Find(x => x.Name == "navigationLastPage")
            .Value.ToString());

            Util.ResponseHandler(response);

            return navigationLastPage;
        }
        /// <summary>
        /// Max page value for specified service path object
        /// </summary>
        /// <param name="navigationPageSize"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public int GetLastPage(int navigationPageSize, ServicePath p)
        {
            string path = "";

            if (p == ServicePath.GetXLeas)
            {
                path = "xLeas";
            }
            else if (p == ServicePath.GetXLeasByXSchool)
            {
                path = "xSchools/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXStudent)
            {
                path = "xStudents/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXContact)
            {
                path = "xContacts/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXSchools)
            {
                path = "xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXLea)
            {
                path = "xLeas/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXCalendar)
            {
                path = "xCalendars/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXCourse)
            {
                path = "xCourses/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXRoster)
            {
                path = "xRosters/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXStaff)
            {
                path = "xStaffs/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXStudent)
            {
                path = "xStudents/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXContact)
            {
                path = "xContacts/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXCalendars)
            {
                path = "xCalendars";
            }
            else if (p == ServicePath.GetXCalendarsByXSchool)
            {
                path = "xSchools/{refId}/xCalendars";
            }
            else if (p == ServicePath.GetXCourses)
            {
                path = "xCourses";
            }
            else if (p == ServicePath.GetXCoursesByXLea)
            {
                path = "xLeas/{refId}/xCourses";
            }
            else if (p == ServicePath.GetXRosters)
            {
                path = "xRosters";
            }
            else if (p == ServicePath.GetXRostersByXLea)
            {
                path = "xLeas/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXSchool)
            {
                path = "xSchools/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXCourse)
            {
                path = "xCourses/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXStaff)
            {
                path = "xStaffs/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXStudent)
            {
                path = "xStudents/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXStaffs)
            {
                path = "xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXLea)
            {
                path = "xLeas/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXSchool)
            {
                path = "xSchools/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXCourse)
            {
                path = "xCourses/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXRoster)
            {
                path = "xRosters/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStudents)
            {
                path = "xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXLea)
            {
                path = "xLeas/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXSchool)
            {
                path = "xSchools/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXRoster)
            {
                path = "xRosters/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXStaff)
            {
                path = "xStaffs/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXContact)
            {
                path = "xContacts/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXContacts)
            {
                path = "xContacts";
            }
            else if (p == ServicePath.GetXContactsByXLea)
            {
                path = "xLeas/{refId}/xContacts";
            }
            else if (p == ServicePath.GetXContactsByXSchool)
            {
                path = "xSchools/{refId}/xContacts";
            }
            else if (p == ServicePath.GetXContactsByXStudent)
            {
                path = "xStudents/{refId}/xContacts";
            }

            RestRequest request = new RestRequest(path, Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("navigationPage", 1);
            request.AddParameter("navigationPageSize", navigationPageSize);
            
            var response = restClient.Execute(request);

            int navigationLastPage = Int32.Parse(response.Headers.ToList()
            .Find(x => x.Name == "navigationLastPage")
            .Value.ToString());

            Util.ResponseHandler(response);

            return navigationLastPage;
        }

        #endregion
    }
}
