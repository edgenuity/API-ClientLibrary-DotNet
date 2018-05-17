/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.5.1
 * Since       2017-01-27
 * Filename    XPress.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using RicOneApi;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using RicOneApi.Common.Objects;

namespace RicOneApi.Api
{
    /// <summary>
    /// Static class that allows access to the xPress data model objects.
    /// </summary>
    public class XPress
    {
        private readonly XLeasObject xLeasObject;
        private readonly XSchoolsObject xSchoolsObject;
        private readonly XCalendarsObject xCalendarsObject;
        private readonly XCoursesObject xCoursesObject;
        private readonly XRostersObject xRostersObject;
        private readonly XStaffsObject xStaffsObject;
        private readonly XStudentsObject xStudentsObject;
        private readonly XContactsObject xContactsObject;

        public XPress(string baseApiUrl)
        {
            RestClient restClient = new RestClient(baseApiUrl);
            xLeasObject = new XLeasObject(restClient, baseApiUrl);
            //this.baseApiUrl = baseApiUrl;
            DecodedToken dt = new DecodedToken(Authenticator.Instance.GetToken());

            if (Util.ConvertUnixTime(dt.GetDecodedToken().exp) <= DateTime.Now)
            {
                Authenticator.Instance.RefreshToken();
                restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(Authenticator.Instance.GetToken(), "Bearer");
            }
            else
            {
                restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(Authenticator.Instance.GetToken(), "Bearer");
            }
        }

        # region xLeas
        /// <summary>
        /// Request all xLeas.
        /// </summary>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeas()
        {
            return xLeasObject.GetXLeas();
        }
        
        /// <summary>
        /// Request all xLeas by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeas(int? schoolYear)
        {
            return xLeasObject.GetXLeas(schoolYear);
        }
        
        /// <summary>
        /// Request all xLeas with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeas(navigationPage, navigationPageSize);
        }
       
        /// <summary>
        /// Request all xLeas with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeas(navigationPage, navigationPageSize, schoolYear);
        }
        
        /// <summary>
        /// Request all xLeas value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeas(string opaqueMarker)
        {
            return xLeasObject.GetXLeas(opaqueMarker);
        }
       
        /// <summary>
        /// Request all xLeas value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xLeasObject.GetXLeas(navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request single xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <returns>Single xLeas type.</returns>
        public ResponseSingle<XLeaType> GetXLea(string refId)
        {
            return xLeasObject.GetXLea(refId);
        }

        /// <summary>
        /// Request single xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xLeas type.</returns>
        public ResponseSingle<XLeaType> GetXLea(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLea(refId, schoolYear);
        }

        /// <summary>
        /// Request single xLea by BEDS code or Local Id.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <returns>Single xLeas type.</returns>
        public ResponseSingle<XLeaType> GetXLea(string idType, string id)
        {
            return xLeasObject.GetXLea(idType, id);
        }

        /// <summary>
        /// Request single xLea by BEDS code or Local Id by school year.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xLeas type.</returns>
        public ResponseSingle<XLeaType> GetXLea(string idType, string id, int? schoolYear)
        {
            return xLeasObject.GetXLea(idType, id, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId)
        {
            return xLeasObject.GetXLeasByXSchool(refId);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXSchool(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId)
        {
            return xLeasObject.GetXLeasByXRoster(refId);
        }

        /// <summary>
        /// Request xLeas associated to a specific xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXRoster(refId, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXRoster(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xLeas associated to a specific xRoster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXRoster(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId)
        {
            return xLeasObject.GetXLeasByXStaff(refId);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXStaff(refId, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStaff by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXStaff(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStaff by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXStaff(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId)
        {
            return xLeasObject.GetXLeasByXStudent(refId);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXStudent(refId, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStudent by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param></param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXStudent(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStudent by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXStudent(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xContact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId)
        {
            return xLeasObject.GetXLeasByXContact(refId);
        }

        /// <summary>
        /// Request xLeas associated to a specific xContact by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXContact(refId, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xContact by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXContact(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xLeas associated to a specific xContact by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXContact(refId, navigationPage, navigationPageSize, schoolYear);
        }
        #endregion

        #region xSchools
        /// <summary>
        /// Request all xSchools.
        /// </summary>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchools()
        {
            return xSchoolsObject.GetXSchools();
        }

        /// <summary>
        /// Request all xSchools by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchools(int? schoolYear)
        {
            return xSchoolsObject.GetXSchools(schoolYear);
        }

        /// <summary>
        /// Request all xSchools with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize)
        {
            return xSchoolsObject.GetXSchools(navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request all xSchools with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xSchoolsObject.GetXSchools(navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchools(string opaqueMarker)
        {
            return xSchoolsObject.GetXSchools(opaqueMarker);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchools(navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request single xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>Single xSchools type.</returns>
        public ResponseSingle<XSchoolType> GetXSchool(string refId)
        {
            return xSchoolsObject.GetXSchool(refId);
        }

        /// <summary>
        /// Request single xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xSchools type.</returns>
        public ResponseSingle<XSchoolType> GetXSchool(string refId, int? schoolYear)
        {
            return xSchoolsObject.GetXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request single xSchool by BEDS code or Local Id.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <returns>Single xSchools type.</returns>
        public ResponseSingle<XSchoolType> GetXSchool(string idType, string id)
        {
            return xSchoolsObject.GetXSchool(idType, id);
        }

        /// <summary>
        /// Request single xSchool by BEDS code or Local Id by school year.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xSchools type.</returns>
        public ResponseSingle<XSchoolType> GetXSchool(string idType, string id, int? schoolYear)
        {
            return xSchoolsObject.GetXSchool(idType, id, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId)
        {
            return xSchoolsObject.GetXSchoolsByXLea(refId);
        }

        /// <summary>
        /// Request xSchools associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXLea(refId, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xSchoolsObject.GetXSchoolsByXLea(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xSchools associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXLea(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCalendar by refId.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId)
        {
            return xSchoolsObject.GetXSchoolsByXCalendar(refId);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCalendar by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXCalendar(refId, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCalendar by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xSchoolsObject.GetXSchoolsByXCalendar(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCalendar by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXCalendar(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCourse by refId.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId)
        {
            return xSchoolsObject.GetXSchoolsByXCourse(refId);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCourse by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXCourse(refId, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCourse by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xSchoolsObject.GetXSchoolsByXCourse(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCourse by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXCourse(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId)
        {
            return xSchoolsObject.GetXSchoolsByXRoster(refId);
        }

        /// <summary>
        /// Request xSchools associated to a specific xRoster by refId by school year. 
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXRoster(refId, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xSchoolsObject.GetXSchoolsByXRoster(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xSchools associated to a specific xRoster by refId with paging by school year. 
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXRoster(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId)
        {
            return xSchoolsObject.GetXSchoolsByXStaff(refId);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXStaff(refId, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStaff by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xSchoolsObject.GetXSchoolsByXStaff(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStaff by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXStaff(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId)
        {
            return xSchoolsObject.GetXSchoolsByXStudent(refId);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStudent by refId by school year. 
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXStudent(refId, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStudent by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xSchoolsObject.GetXSchoolsByXStudent(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStudent by refId with paging by school year. 
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXStudent(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xContact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId)
        {
            return xSchoolsObject.GetXSchoolsByXContact(refId);
        }

        /// <summary>
        /// Request xSchools associated to a specific xContact by refId by school year. 
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXContact(refId, schoolYear);
        }

        /// <summary>
        /// Request xSchools associated to a specific xContact by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xSchoolsObject.GetXSchoolsByXContact(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xSchools associated to a specific xContact by refId with paging by school year. 
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xSchoolsObject.GetXSchoolsByXContact(refId, navigationPage, navigationPageSize, schoolYear);
        }
        #endregion

        #region xCalendars
        /// <summary>
        /// Request all xCalendars.
        /// </summary>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendars()
        {
            return xCalendarsObject.GetXCalendars();
        }

        /// <summary>
        /// Request all xCalendars by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendars(int? schoolYear)
        {
            return xCalendarsObject.GetXCalendars(schoolYear);
        }

        /// <summary>
        /// Request all xCalendars with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize)
        {
            return xCalendarsObject.GetXCalendars(navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request all xCalendars with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCalendarsObject.GetXCalendars(navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xCalendar value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendars(string opaqueMarker)
        {
            return xCalendarsObject.GetXCalendars(opaqueMarker);
        }

        /// <summary>
        /// Request all xCalendar value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xCalendarsObject.GetXCalendars(navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request single xCalendar by refId.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <returns>Single xCalendars type.</returns>
        public ResponseSingle<XCalendarType> GetXCalendar(string refId)
        {
            return xCalendarsObject.GetXCalendar(refId);
        }

        /// <summary>
        /// Request single xCalendar by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xCalendars type.</returns>
        public ResponseSingle<XCalendarType> GetXCalendar(string refId, int? schoolYear)
        {
            return xCalendarsObject.GetXCalendar(refId, schoolYear);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId)
        {
            return xCalendarsObject.GetXCalendarsByXLea(refId);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? schoolYear)
        {
            return xCalendarsObject.GetXCalendarsByXLea(refId, schoolYear);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xCalendarsObject.GetXCalendarsByXLea(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCalendarsObject.GetXCalendarsByXLea(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? schoolYear)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }
        #endregion

        #region xCourses
        /// <summary>
        /// Request all xCourses.
        /// </summary>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCourses()
        {
            return xCoursesObject.GetXCourses();
        }

        /// <summary>
        /// Request all xCourses by school year.
        /// </summary>
        /// <param name="shcoolYear"></param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCourses(int? shcoolYear)
        {
            return xCoursesObject.GetXCourses(shcoolYear);
        }

        /// <summary>
        /// Request all xCourses with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize)
        {
            return xCoursesObject.GetXCourses(navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request all xCourses with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCoursesObject.GetXCourses(navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xCourse value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCourses(string opaqueMarker)
        {
            return xCoursesObject.GetXCourses(opaqueMarker);
        }

        /// <summary>
        /// Request all xCourse value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xCoursesObject.GetXCourses(navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request single xCourse by refId.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <returns>Single xCourses type.</returns>
        public ResponseSingle<XCourseType> GetXCourse(string refId)
        {
            return xCoursesObject.GetXCourse(refId);
        }

        /// <summary>
        /// Request single xCourse by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xCourses type.</returns>
        public ResponseSingle<XCourseType> GetXCourse(string refId, int? schoolYear)
        {
            return xCoursesObject.GetXCourse(refId, schoolYear);
        }

        /// <summary>
        /// Request xCourses associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId)
        {
            return xCoursesObject.GetXCoursesByXLea(refId);
        }

        /// <summary>
        /// Request xCourses associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? schoolYear)
        {
            return xCoursesObject.GetXCoursesByXLea(refId, schoolYear);
        }

        /// <summary>
        /// Request xCourses associated to a specific xLea by refId wtih paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xCoursesObject.GetXCoursesByXLea(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xCourses associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCoursesObject.GetXCoursesByXLea(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? schoolYear)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xCourses associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId)
        {
            return xCoursesObject.GetXCoursesByXRoster(refId);
        }

        /// <summary>
        /// Request xCourses associated to a specific xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? schoolYear)
        {
            return xCoursesObject.GetXCoursesByXRoster(refId, schoolYear);
        }

        /// <summary>
        /// Request xCourses associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xCoursesObject.GetXCoursesByXRoster(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xCourses associated to a specific xRoster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCoursesObject.GetXCoursesByXRoster(refId, navigationPage, navigationPageSize, schoolYear);
        }

        #endregion

        #region xRosters
        /// <summary>
        /// Request all xRosters.
        /// </summary>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRosters()
        {
            return xRostersObject.GetXRosters();
        }

        /// <summary>
        /// Request all xRosters by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRosters(int? schoolYear)
        {
            return xRostersObject.GetXRosters(schoolYear);
        }

        /// <summary>
        /// Request all xRosters with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRosters(int? navigationPage, int? navigationPageSize)
        {
            return xRostersObject.GetXRosters(navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request all xRosters with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRosters(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xRostersObject.GetXRosters(navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xRoster value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRosters(string opaqueMarker)
        {
            return xRostersObject.GetXRosters(opaqueMarker);
        }

        /// <summary>
        /// Request all xRoster value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRosters(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xRostersObject.GetXRosters(navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request single xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>Single xRosters type.</returns>
        public ResponseSingle<XRosterType> GetXRoster(string refId)
        {
            return xRostersObject.GetXRoster(refId);
        }

        /// <summary>
        /// Request single xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xRosters type</returns>
        public ResponseSingle<XRosterType> GetXRoster(string refId, int? schoolYear)
        {
            return xRostersObject.GetXRoster(refId, schoolYear);
        }


        /// <summary>
        /// Request xRosters associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXLea(string refId)
        {
            return xRostersObject.GetXRostersByXLea(refId);
        }

        /// <summary>
        /// Request xRosters associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXLea(string refId, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXLea(refId, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xRostersObject.GetXRostersByXLea(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xRosters associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXLea(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId)
        {
            return xRostersObject.GetXRostersByXSchool(refId);
        }

        /// <summary>
        /// Request xRosters associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xRostersObject.GetXRostersByXSchool(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xRosters associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xCourse by refId.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId)
        {
            return xRostersObject.GetXRostersByXCourse(refId);
        }

        /// <summary>
        /// Request xRosters associated to a specific xCourse by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXCourse(refId, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xCourse by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xRostersObject.GetXRostersByXCourse(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xRosters associated to a specific xCourse by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXCourse(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId)
        {
            return xRostersObject.GetXRostersByXStaff(refId);
        }

        /// <summary>
        /// Request xRosters associated to a specific xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXStaff(refId, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xStaff by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xRostersObject.GetXRostersByXStaff(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xRosters associated to a specific xStaff by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXStaff(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId)
        {
            return xRostersObject.GetXRostersByXStudent(refId);
        }

        /// <summary>
        /// Request xRosters associated to a specific xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXStudent(refId, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xStudent by refId wtih paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xRostersObject.GetXRostersByXStudent(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xRosters associated to a specific xStudent by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXStudent(refId, navigationPage, navigationPageSize, schoolYear);
        }

        #endregion

        #region xStaffs
        /// <summary>
        /// Request all xStaffs.
        /// </summary>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffs()
        {
            return xStaffsObject.GetXStaffs();
        }

        /// <summary>
        /// Request all xStaffs by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffs(int? schoolYear)
        {
            return xStaffsObject.GetXStaffs(schoolYear);
        }

        /// <summary>
        /// Request all xStaffs with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize)
        {
            return xStaffsObject.GetXStaffs(navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request all xStaffs with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStaffsObject.GetXStaffs(navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffs(string opaqueMarker)
        {
            return xStaffsObject.GetXStaffs(opaqueMarker);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffs(navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request single xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>Single xStaffs type.</returns>
        public ResponseSingle<XStaffType> GetXStaff(string refId)
        {
            return xStaffsObject.GetXStaff(refId);
        }

        /// <summary>
        /// Request single xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xStaffs type.</returns>
        public ResponseSingle<XStaffType> GetXStaff(string refId, int? schoolYear)
        {
            return xStaffsObject.GetXStaff(refId, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId)
        {
            return xStaffsObject.GetXStaffsByXLea(refId);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXLea(refId, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStaffsObject.GetXStaffsByXLea(refId, navigationPage, navigationPageSize);

        }

        /// <summary>
        /// Request xStaffs associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXLea(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xCourse by refId.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId)
        {
            return xStaffsObject.GetXStaffsByXCourse(refId);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xCourse by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXCourse(refId, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xCourse by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStaffsObject.GetXStaffsByXCourse(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xCourse by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXCourse(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId)
        {
            return xStaffsObject.GetXStaffsByXRoster(refId);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXRoster(refId);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStaffsObject.GetXStaffsByXRoster(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xRoster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXRoster(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId)
        {
            return xStaffsObject.GetXStaffsByXStudent(refId);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXStudent(refId, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xStudent by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStaffsObject.GetXStaffsByXStudent(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xStudent by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXStudent(refId, navigationPage, navigationPageSize, schoolYear);
        }

        #endregion

        #region xStudents
        /// <summary>
        /// Request all xStudents.
        /// </summary>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudents()
        {
            return xStudentsObject.GetXStudents();
        }

        /// <summary>
        /// Request all xStudents by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudents(int? schoolYear)
        {
            return xStudentsObject.GetXStudents(schoolYear);
        }

        /// <summary>
        /// Request all xStudents with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize)
        {
            return xStudentsObject.GetXStudents(navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request all xStudents with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStudentsObject.GetXStudents(navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudents(string opaqueMarker)
        {
            return xStudentsObject.GetXStudents(opaqueMarker);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStudentsObject.GetXStudents(navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request single xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>Single xStudents type.</returns>
        public ResponseSingle<XStudentType> GetXStudent(string refId)
        {
            return xStudentsObject.GetXStudent(refId);
        }

        /// <summary>
        /// Request single xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xStudents type.</returns>
        public ResponseSingle<XStudentType> GetXStudent(string refId, int? schoolYear)
        {
            return xStudentsObject.GetXStudent(refId, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId)
        {
            return xStudentsObject.GetXStudentsByXLea(refId);
        }

        /// <summary>
        /// Request xStudents associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXLea(refId, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStudentsObject.GetXStudentsByXLea(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStudents associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXLea(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId)
        {
            return xStudentsObject.GetXStudentsByXRoster(refId);
        }

        /// <summary>
        /// Request xStudents associated to a specific xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXRoster(refId, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStudentsObject.GetXStudentsByXRoster(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStudents associated to a specific xRoster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXRoster(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId)
        {
            return xStudentsObject.GetXStudentsByXStaff(refId);
        }

        /// <summary>
        /// Request xStudents associated to a specific xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXStaff(refId, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xStaff by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStudentsObject.GetXStudentsByXStaff(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStudents associated to a specific xStaff by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXStaff(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xContact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId)
        {
            return xStudentsObject.GetXStudentsByXContact(refId);
        }

        /// <summary>
        /// Request xStudents associated to a specific xContact by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXContact(refId, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xContact by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xStudentsObject.GetXStudentsByXContact(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xStudents associated to a specific xContact by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXContact(refId, navigationPage, navigationPageSize, schoolYear);
        }

        #endregion xStudents

        #region xContacts
        /// <summary>
        /// Request all Contacts
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// All Contact value changes from a given point
        /// </summary>
        /// <param name="opaqueMarker"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContacts(string opaqueMarker)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddQueryParameter("changesSinceMarker", opaqueMarker);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request all Contacts
        /// </summary>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContacts()
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseSingle<XContactType> GetXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XContactType> output = new ResponseSingle<XContactType>();

            RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContact.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XContactType> GetXContact(string refId)
        {
            ResponseSingle<XContactType> output = new ResponseSingle<XContactType>();

            RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContact.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Lea by BEDS code or Local Id. Header IdType value can be set to beds or local
        /// </summary>
        /// <param name="idType"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string idType, string id)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xLeas/{id}/xContacts", Method.GET);
            request.AddParameter("id", id, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific School by BEDS code or Local Id. Header IdType value can be set to beds or local
        /// </summary>
        /// <param name="idType"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string idType, string id)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{id}/xContacts", Method.GET);
            request.AddParameter("id", id, ParameterType.UrlSegment);
            request.AddHeader("IdType", idType);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
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
            GetXContactsByXStudent = 37,
            GetXLeasByXRoster = 38,
            GetXLeasByXStaff = 39,
            GetXCalendarsByXLea = 40,
            GetXCoursesByXSchool = 41,
            GetXCoursesByXRoster = 42,
            GetXStaffsByXStudent = 43
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
            int navigationLastPage = 0;

            switch (p)
            {
                case ServicePath.GetXLeas:
                    path = "xLeas";
                    break;
                case ServicePath.GetXLeasByXSchool:
                    path = "xSchools/{refId}/xLeas";
                    break;
                case ServicePath.GetXLeasByXRoster:
                    path = "xRosters/{refId}/xLeas";
                    break;
                case ServicePath.GetXLeasByXStaff:
                    path = "xStaffs/{refId}/xLeas";
                    break;
                case ServicePath.GetXLeasByXStudent:
                    path = "xStudents/{refId}/xLeas";
                    break;
                case ServicePath.GetXLeasByXContact:
                    path = "xContacts/{refId}/xLeas";
                    break;
                case ServicePath.GetXSchools:
                    path = "xSchools";
                    break;
                case ServicePath.GetXSchoolsByXLea:
                    path = "xLeas/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXCalendar:
                    path = "xCalendars/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXCourse:
                    path = "xCourses/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXRoster:
                    path = "xRosters/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXStaff:
                    path = "xStaffs/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXStudent:
                    path = "xStudents/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXContact:
                    path = "xContacts/{refId}/xSchools";
                    break;
                case ServicePath.GetXCalendars:
                    path = "xCalendars";
                    break;
                case ServicePath.GetXCalendarsByXLea:
                    path = "xLeas/{refId}/xCalendars";
                    break;
                case ServicePath.GetXCalendarsByXSchool:
                    path = "xSchools/{refId}/xCalendars";
                    break;
                case ServicePath.GetXCourses:
                    path = "xCourses";
                    break;
                case ServicePath.GetXCoursesByXLea:
                    path = "xLeas/{refId}/xCourses";
                    break;
                case ServicePath.GetXCoursesByXSchool:
                    path = "xSchools/{refId}/xCourses";
                    break;
                case ServicePath.GetXCoursesByXRoster:
                    path = "xRosters/{refId}/xCourses";
                    break;
                case ServicePath.GetXRosters:
                    path = "xRosters";
                    break;
                case ServicePath.GetXRostersByXLea:
                    path = "xLeas/{refId}/xRosters";
                    break;
                case ServicePath.GetXRostersByXSchool:
                    path = "xSchools/{refId}/xRosters";
                    break;
                case ServicePath.GetXRostersByXCourse:
                    path = "xCourses/{refId}/xRosters";
                    break;
                case ServicePath.GetXRostersByXStaff:
                    path = "xStaffs/{refId}/xRosters";
                    break;
                case ServicePath.GetXRostersByXStudent:
                    path = "xStudents/{refId}/xRosters";
                    break;
                case ServicePath.GetXStaffs:
                    path = "xStaffs";
                    break;
                case ServicePath.GetXStaffsByXLea:
                    path = "xLeas/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStaffsByXSchool:
                    path = "xSchools/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStaffsByXCourse:
                    path = "xCourses/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStaffsByXRoster:
                    path = "xRosters/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStaffsByXStudent:
                    path = "xStudents/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStudents:
                    path = "xStudents";
                    break;
                case ServicePath.GetXStudentsByXLea:
                    path = "xLeas/{refId}/xStudents";
                    break;
                case ServicePath.GetXStudentsByXSchool:
                    path = "xSchools/{refId}/xStudents";
                    break;
                case ServicePath.GetXStudentsByXRoster:
                    path = "xRosters/{refId}/xStudents";
                    break;
                case ServicePath.GetXStudentsByXStaff:
                    path = "xStaffs/{refId}/xStudents";
                    break;
                case ServicePath.GetXStudentsByXContact:
                    path = "xContacts/{refId}/xStudents";
                    break;
                case ServicePath.GetXContacts:
                    path = "xContacts";
                    break;
                case ServicePath.GetXContactsByXLea:
                    path = "xLeas/{refId}/xContacts";
                    break;
                case ServicePath.GetXContactsByXSchool:
                    path = "xSchools/{refId}/xContacts";
                    break;
                case ServicePath.GetXContactsByXStudent:
                    path = "xStudents/{refId}/xContacts";
                    break;
            }

            RestRequest request = new RestRequest(path, Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("navigationPage", "1");
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute(request);

            try
            {
                navigationLastPage = Int32.Parse(response.Headers.ToList()
                .Find(x => x.Name.Equals("navigationLastPage", StringComparison.CurrentCultureIgnoreCase))
                .Value.ToString());
            }
            catch (NullReferenceException)
            {
                navigationLastPage = 0;
            }

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
            int navigationLastPage = 0;

            switch (p)
            {
                case ServicePath.GetXLeas:
                    path = "xLeas";
                    break;
                case ServicePath.GetXLeasByXSchool:
                    path = "xSchools/{refId}/xLeas";
                    break;
                case ServicePath.GetXLeasByXRoster:
                    path = "xRosters/{refId}/xLeas";
                    break;
                case ServicePath.GetXLeasByXStaff:
                    path = "xStaffs/{refId}/xLeas";
                    break;
                case ServicePath.GetXLeasByXStudent:
                    path = "xStudents/{refId}/xLeas";
                    break;
                case ServicePath.GetXLeasByXContact:
                    path = "xContacts/{refId}/xLeas";
                    break;
                case ServicePath.GetXSchools:
                    path = "xSchools";
                    break;
                case ServicePath.GetXSchoolsByXLea:
                    path = "xLeas/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXCalendar:
                    path = "xCalendars/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXCourse:
                    path = "xCourses/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXRoster:
                    path = "xRosters/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXStaff:
                    path = "xStaffs/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXStudent:
                    path = "xStudents/{refId}/xSchools";
                    break;
                case ServicePath.GetXSchoolsByXContact:
                    path = "xContacts/{refId}/xSchools";
                    break;
                case ServicePath.GetXCalendars:
                    path = "xCalendars";
                    break;
                case ServicePath.GetXCalendarsByXLea:
                    path = "xLeas/{refId}/xCalendars";
                    break;
                case ServicePath.GetXCalendarsByXSchool:
                    path = "xSchools/{refId}/xCalendars";
                    break;
                case ServicePath.GetXCourses:
                    path = "xCourses";
                    break;
                case ServicePath.GetXCoursesByXLea:
                    path = "xLeas/{refId}/xCourses";
                    break;
                case ServicePath.GetXCoursesByXSchool:
                    path = "xSchools/{refId}/xCourses";
                    break;
                case ServicePath.GetXCoursesByXRoster:
                    path = "xRosters/{refId}/xCourses";
                    break;
                case ServicePath.GetXRosters:
                    path = "xRosters";
                    break;
                case ServicePath.GetXRostersByXLea:
                    path = "xLeas/{refId}/xRosters";
                    break;
                case ServicePath.GetXRostersByXSchool:
                    path = "xSchools/{refId}/xRosters";
                    break;
                case ServicePath.GetXRostersByXCourse:
                    path = "xCourses/{refId}/xRosters";
                    break;
                case ServicePath.GetXRostersByXStaff:
                    path = "xStaffs/{refId}/xRosters";
                    break;
                case ServicePath.GetXRostersByXStudent:
                    path = "xStudents/{refId}/xRosters";
                    break;
                case ServicePath.GetXStaffs:
                    path = "xStaffs";
                    break;
                case ServicePath.GetXStaffsByXLea:
                    path = "xLeas/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStaffsByXSchool:
                    path = "xSchools/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStaffsByXCourse:
                    path = "xCourses/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStaffsByXRoster:
                    path = "xRosters/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStaffsByXStudent:
                    path = "xStudents/{refId}/xStaffs";
                    break;
                case ServicePath.GetXStudents:
                    path = "xStudents";
                    break;
                case ServicePath.GetXStudentsByXLea:
                    path = "xLeas/{refId}/xStudents";
                    break;
                case ServicePath.GetXStudentsByXSchool:
                    path = "xSchools/{refId}/xStudents";
                    break;
                case ServicePath.GetXStudentsByXRoster:
                    path = "xRosters/{refId}/xStudents";
                    break;
                case ServicePath.GetXStudentsByXStaff:
                    path = "xStaffs/{refId}/xStudents";
                    break;
                case ServicePath.GetXStudentsByXContact:
                    path = "xContacts/{refId}/xStudents";
                    break;
                case ServicePath.GetXContacts:
                    path = "xContacts";
                    break;
                case ServicePath.GetXContactsByXLea:
                    path = "xLeas/{refId}/xContacts";
                    break;
                case ServicePath.GetXContactsByXSchool:
                    path = "xSchools/{refId}/xContacts";
                    break;
                case ServicePath.GetXContactsByXStudent:
                    path = "xStudents/{refId}/xContacts";
                    break;
            }

            RestRequest request = new RestRequest(path, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", "1");
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute(request);

            try
            {
                navigationLastPage = Int32.Parse(response.Headers.ToList()
                .Find(x => x.Name.Equals("navigationLastPage", StringComparison.CurrentCultureIgnoreCase))
                .Value.ToString());
            }
            catch (NullReferenceException)
            {
                navigationLastPage = 0;
            }

            return navigationLastPage;
        }

        #endregion
        #region App Provisioning Info
        /// <summary>
        /// Create staff usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> CreateXStaffUsers(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("createUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Delete generated staff passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> DeleteXStaffUsers(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("deleteUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Return generated staff usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffUsers(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("getUsers", "true");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Return generated staff usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffUsers(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("getUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Create student usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> CreateXStudentUsers(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("createUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Delete generated student passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> DeleteXStudentUsers(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("deleteUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Return generated student usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentUsers(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("getUsers", "true");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Return generated student usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentUsers(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("getUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Create contact usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        private ResponseMulti<XContactType> CreateXContactUsers(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("createUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);
            Console.WriteLine(response.ResponseUri);
            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Delete generated contact passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>

        private ResponseMulti<XContactType> DeleteXContactUsers(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("deleteUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);
            Console.WriteLine(response.ResponseUri);
            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Return generated contact usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        private ResponseMulti<XContactType> GetXContactUsers(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("getUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);
            Console.WriteLine(response.ResponseUri);
            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        #endregion
    }
}
