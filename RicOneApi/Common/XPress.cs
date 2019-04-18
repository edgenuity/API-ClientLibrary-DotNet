using System;
using RestSharp;
using RicOneApi.Models.XPress;
using RicOneApi.Common.Objects;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7.0
 * Since       2019-04-18
 * Filename    XPress.cs
 */
namespace RicOneApi.Api
{
    /// <summary>
    /// Class that allows access to the xPress data model objects.
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
        private readonly GetLastPageObject getLastPageObject;
        private readonly AUPPObject aUPPObject;

        /// <summary>
        /// Class that allows access to the xPress data model objects.
        /// </summary>
        /// <param name="baseApiUrl">The base URL for an API endpoint.</param>
        public XPress(string baseApiUrl)
        {
            RestClient rc = new RestClient(baseApiUrl);
            rc.AddDefaultHeader("Content-Type", "application/json");
            xLeasObject = new XLeasObject(rc, baseApiUrl);
            xSchoolsObject = new XSchoolsObject(rc, baseApiUrl);
            xCalendarsObject = new XCalendarsObject(rc, baseApiUrl);
            xCoursesObject = new XCoursesObject(rc, baseApiUrl);
            xRostersObject = new XRostersObject(rc, baseApiUrl);
            xStaffsObject = new XStaffsObject(rc, baseApiUrl);
            xStudentsObject = new XStudentsObject(rc, baseApiUrl);
            xContactsObject = new XContactsObject(rc, baseApiUrl);
            getLastPageObject = new GetLastPageObject(rc, baseApiUrl);
            aUPPObject = new AUPPObject(rc, baseApiUrl);
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
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId)
        {
            return xLeasObject.GetXLeasByXSchool(refId);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
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
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xLeas value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXSchool(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xLeas value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXSchool(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xLeas value changes from a given point by a specific xRoster.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXRoster(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xLeas value changes from a given point by a specific xRoster with paging.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXRoster(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xLeas value changes from a given point by a specific xStaff.
        /// </summary>
        /// <param name="refId">RefId of xStaff.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXStaff(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xLeas value changes from a given point by a specific xStaff with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaff.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXStaff(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// <param name="refId">RefId of xStudents.</param>
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
        /// Request all xLeas value changes from a given point by a specific xStudent.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXStudent(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xLeas value changes from a given point by a specific xStudent with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXStudent(refId, navigationPage, navigationPageSize, opaqueMarker);
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

        /// <summary>
        /// Request all xLeas value changes from a given point by a specific xContact.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXContact(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xLeas value changes from a given point by a specific xContact with paging.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xLeasObject.GetXLeasByXContact(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
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
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>Single xSchools type.</returns>
        public ResponseSingle<XSchoolType> GetXSchool(string refId)
        {
            return xSchoolsObject.GetXSchool(refId);
        }

        /// <summary>
        /// Request single xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
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
        /// Request all xSchools value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXLea(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXLea(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xSchools value changes from a given point by a specific xCalendar.
        /// </summary>
        /// <param name="refId">RefId of xCalendar.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXCalendar(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point by a specific xCalendar with paging.
        /// </summary>
        /// <param name="refId">RefId of xCalendar.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXCalendar(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xSchools value changes from a given point by a specific xCourse.
        /// </summary>
        /// <param name="refId">RefId of xCourse.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXCourse(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point by a specific xCourse with paging.
        /// </summary>
        /// <param name="refId">RefId of xCourse.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXCourse(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xSchools value changes from a given point by a specific xRoster.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXRoster(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point by a specific xRoster with paging.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXRoster(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xSchools value changes from a given point by a specific xStaff.
        /// </summary>
        /// <param name="refId">RefId of xStaff.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>

        public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXStaff(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point by a specific xStaff with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaff.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXStaff(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xSchools value changes from a given point by a specific xStudent.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXStudent(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point by a specific xStudent with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXStudent(refId, navigationPage, navigationPageSize, opaqueMarker);
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

        /// <summary>
        /// Request all xSchools value changes from a given point by a specific xContact.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXContact(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point by a specific xContact with paging.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xSchoolsObject.GetXSchoolsByXContact(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xCalendars value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, string opaqueMarker)
        {
            return xCalendarsObject.GetXCalendarsByXLea(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xCalendars value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xCalendarsObject.GetXCalendarsByXLea(refId, navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? schoolYear)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
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
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xCalendars value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, string opaqueMarker)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xCalendars value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCalendars type.</returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xCalendarsObject.GetXCalendarsByXSchool(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xCourses value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, string opaqueMarker)
        {
            return xCoursesObject.GetXCoursesByXLea(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xCoursesObject.GetXCoursesByXLea(refId, navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? schoolYear)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
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
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, string opaqueMarker)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xCoursesObject.GetXCoursesByXSchool(refId, navigationPage, navigationPageSize, opaqueMarker);
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

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xRoster.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, string opaqueMarker)
        {
            return xCoursesObject.GetXCoursesByXRoster(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xRoster with paging.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xCoursesObject.GetXCoursesByXRoster(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xRosters value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXLea(string refId, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXLea(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xRosters value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXLea(refId, navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request xRosters associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId)
        {
            return xRostersObject.GetXRostersByXSchool(refId);
        }

        /// <summary>
        /// Request xRosters associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xRosters associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
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
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xRostersObject.GetXRostersByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xRosters value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXSchool(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xRosters value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXSchool(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xRosters value changes from a given point by a specific xCourse.
        /// </summary>
        /// <param name="refId">RefId of xCourse.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXCourse(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xRosters value changes from a given point by a specific xCourse with paging.
        /// </summary>
        /// <param name="refId">RefId of xCourse.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXCourse(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xRosters value changes from a given point by a specific xStaff.
        /// </summary>
        /// <param name="refId">RefId of xStaff.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXStaff(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xRosters value changes from a given point by a specific xStaff with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaff.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXStaff(refId, navigationPage, navigationPageSize, opaqueMarker);
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

        /// <summary>
        /// Request all xRosters value changes from a given point by a specific xStudent.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXStudent(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xRosters value changes from a given point by a specific xStudent with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xRosters type.</returns>
        public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xRostersObject.GetXRostersByXStudent(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request single xStaff by State or Local Id.
        /// </summary>
        /// <param name="idType">Header value can be set to state or local.</param>
        /// <param name="id">State or Local Id.</param>
        /// <returns>Single xStaffs type.</returns>
        public ResponseSingle<XStaffType> GetXStaff(string idType, string id)
        {
            return xStaffsObject.GetXStaff(idType, id);
        }

        /// <summary>
        /// Request single xStaff by State or Local Id by school year.
        /// </summary>
        /// <param name="idType">Header value can be set to state or local.</param>
        /// <param name="id">State or Local Id.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xStaffs type.</returns>
        public ResponseSingle<XStaffType> GetXStaff(string idType, string id, int? schoolYear)
        {
            return xStaffsObject.GetXStaff(idType, id, schoolYear);
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
        /// Request all xStaffs value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXLea(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXLea(refId, navigationPage, navigationPageSize, opaqueMarker);

        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
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
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXSchool(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xStaffs value changes from a given point by a specific xCourse.
        /// </summary>
        /// <param name="refId">RefId of xCourse.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXCourse(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point by a specific xCourse with paging.
        /// </summary>
        /// <param name="refId">RefId of xCourse.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXCourse(refId, navigationPage, navigationPageSize, opaqueMarker);
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
            return xStaffsObject.GetXStaffsByXRoster(refId, schoolYear);
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
        /// Request all xStaffs value changes from a given point by a specific xRoster.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXRoster(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point by a specific xRoster with paging.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXRoster(refId, navigationPage, navigationPageSize, opaqueMarker);
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

        /// <summary>
        /// Request all xStaffs value changes from a given point by a specific xStudent.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXStudent(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point by a specific xStudent with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStaffsObject.GetXStaffsByXStudent(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request single xStudent by State or Local Id.
        /// </summary>
        /// <param name="idType">Header value can be set to state or local.</param>
        /// <param name="id">State or Local Id.</param>
        /// <returns>Single xStudents type.</returns>
        public ResponseSingle<XStudentType> GetXStudent(string idType, string id)
        {
            return xStudentsObject.GetXStudent(idType, id);
        }

        /// <summary>
        /// Request single xStudent by State or Local Id by school year.
        /// </summary>
        /// <param name="idType">Header value can be set to state or local.</param>
        /// <param name="id">State or Local Id.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xStudents type.</returns>
        public ResponseSingle<XStudentType> GetXStudent(string idType, string id, int? schoolYear)
        {
            return xStudentsObject.GetXStudent(idType, id, schoolYear);
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
        /// Request all xStudents value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXLea(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXLea(refId, navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
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
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXSchool(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xStudents value changes from a given point by a specific xRoster.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXRoster(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point by a specific xRoster with paging.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXRoster(refId, navigationPage, navigationPageSize, opaqueMarker);
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
        /// Request all xStudents value changes from a given point by a specific xStaff.
        /// </summary>
        /// <param name="refId">RefId of xStaff.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXStaff(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point by a specific xStaff with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaff.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXStaff(refId, navigationPage, navigationPageSize, opaqueMarker);
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

        /// <summary>
        /// Request all xStudents value changes from a given point by a specific xContact.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXContact(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point by a specific xContact with paging.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xStudentsObject.GetXStudentsByXContact(refId, navigationPage, navigationPageSize, opaqueMarker);
        }

        #endregion xStudents

        #region xContacts
        /// <summary>
        /// Request all xContacts.
        /// </summary>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContacts()
        {
            return xContactsObject.GetXContacts();
        }

        /// <summary>
        /// Request all xContacts by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContacts(int? schoolYear)
        {
            return xContactsObject.GetXContacts(schoolYear);
        }

        /// <summary>
        /// Request all xContacts with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize)
        {
            return xContactsObject.GetXContacts(navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request all xContacts with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xContactsObject.GetXContacts(navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContacts(string opaqueMarker)
        {
            return xContactsObject.GetXContacts(opaqueMarker);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xContactsObject.GetXContacts(navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request single xContact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <returns>Single xContacts type.</returns>
        public ResponseSingle<XContactType> GetXContact(string refId)
        {
            return xContactsObject.GetXContact(refId);
        }

        /// <summary>
        /// Request single xContact by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xContacts type.</returns>
        public ResponseSingle<XContactType> GetXContact(string refId, int? schoolYear)
        {
            return xContactsObject.GetXContact(refId, schoolYear);
        }

        /// <summary>
        /// Request xContacts associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId)
        {
            return xContactsObject.GetXContactsByXLea(refId);
        }

        /// <summary>
        /// Request xContacts associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? schoolYear)
        {
            return xContactsObject.GetXContactsByXLea(refId, schoolYear);
        }

        /// <summary>
        /// Request xContacts associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xContactsObject.GetXContactsByXLea(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xContacts associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xContactsObject.GetXContactsByXLea(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId, string opaqueMarker)
        {
            return xContactsObject.GetXContactsByXLea(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xContactsObject.GetXContactsByXLea(refId, navigationPage, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Request xContacts associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId)
        {
            return xContactsObject.GetXContactsByXSchool(refId);
        }

        /// <summary>
        /// Request xContacts associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? schoolYear)
        {
            return xContactsObject.GetXContactsByXSchool(refId, schoolYear);
        }

        /// <summary>
        /// Request xContacts associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xContactsObject.GetXContactsByXSchool(refId, navigationPage, navigationPageSize);

        }

        /// <summary>
        /// Request xContacts associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xContactsObject.GetXContactsByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId, string opaqueMarker)
        {
            return xContactsObject.GetXContactsByXSchool(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xContactsObject.GetXContactsByXSchool(refId, navigationPage, navigationPageSize, opaqueMarker);

        }

        /// <summary>
        /// Request xContacts associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId)
        {
            return xContactsObject.GetXContactsByXStudent(refId);
        }

        /// <summary>
        /// Request xContacts associated to a specific xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? schoolYear)
        {
            return xContactsObject.GetXContactsByXStudent(refId, schoolYear);
        }

        /// <summary>
        /// Request xContacts associated to a specific xStudent by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xContactsObject.GetXContactsByXStudent(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request xContacts associated to a specific xStudent by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xContactsObject.GetXContactsByXStudent(refId, navigationPage, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point by a specific xStudent.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId, string opaqueMarker)
        {
            return xContactsObject.GetXContactsByXStudent(refId, opaqueMarker);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point by a specific xStudent with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xContactsObject.GetXContactsByXStudent(refId, navigationPage, navigationPageSize, opaqueMarker);
        }

        #endregion

        #region navigationLastPage
        /// <summary>
        /// Returns the max page value for specified service path object.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>Integer value.</returns>
        public int GetLastPage(ServicePath servicePath, int? navigationPageSize)
        {
            return getLastPageObject.GetLastPage(servicePath, navigationPageSize);
        }

        /// <summary>
        /// Returns the max page value for specified service path object by school year.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Integer value.</returns>
        public int GetLastPage(ServicePath servicePath, int? navigationPageSize, int? schoolYear)
        {
            return getLastPageObject.GetLastPage(servicePath, navigationPageSize, schoolYear);
        }

        /// <summary>
        /// Returns the max page value for specified service path object.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns></returns>
        public int GetLastPage(ServicePath servicePath, int? navigationPageSize, string opaqueMarker)
        {
            return getLastPageObject.GetLastPage(servicePath, navigationPageSize, opaqueMarker);
        }

        /// <summary>
        /// Returns the max page value for specified service path object.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="refId">RefId of xObject.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>Integer value.</returns>
        public int GetLastPage(ServicePath servicePath, string refId, int? navigationPageSize)
        {
            return getLastPageObject.GetLastPage(servicePath, refId, navigationPageSize);
        }

        /// <summary>
        /// Returns the max page value for specified service path object.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="refId">RefId of xObject.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Integer value.</returns>
        public int GetLastPage(ServicePath servicePath, string refId, int? navigationPageSize, int? schoolYear)
        {
            return getLastPageObject.GetLastPage(servicePath, refId, navigationPageSize, schoolYear);
        }

        #endregion

        #region App Provisioning Info
        /// <summary>
        /// Request creation of xStaffs usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        public void CreateXStaffUsers(string refId)
        {
            aUPPObject.CreateXStaffUsers(refId);
        }

        /// <summary>
        /// Request deletion of generated xStaffs passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        public void DeleteXStaffUsers(string refId)
        {
            aUPPObject.DeleteXStaffUsers(refId);
        }

        /// <summary>
        /// Request deletion of generated xStaffs usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        public void DeleteXStaffUsernamesPasswords(string refId)
        {
            aUPPObject.DeleteXStaffUsernamesPasswords(refId);
        }

        /// <summary>
        /// Request generated xStaffs usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffUsers(string refId)
        {
            return aUPPObject.GetXStaffUsers(refId);
        }

        /// <summary>
        /// Request generated xStaffs usernames and passwords by xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        public ResponseMulti<XStaffType> GetXStaffUsers(string refId, int? navigationPage, int? navigationPageSize)
        {
            return aUPPObject.GetXStaffUsers(refId, navigationPage, navigationPageSize);
        }

        /// <summary>
        /// Request creation of xStudents usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        public void CreateXStudentUsers(string refId)
        {
            aUPPObject.CreateXStudentUsers(refId);
        }

        /// <summary>
        /// Request deletion of generated xStudents passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        public void DeleteXStudentUsers(string refId)
        {
            aUPPObject.DeleteXStudentUsers(refId);
        }

        /// <summary>
        /// Request deletion of generated xStudents usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        public void DeleteXStudentUsernamesPasswords(string refId)
        {
            aUPPObject.DeleteXStudentUsernamesPasswords(refId);
        }

        /// <summary>
        /// Request generated xStudents usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentUsers(string refId)
        {
            return aUPPObject.GetXStudentUsers(refId);
        }

        /// <summary>
        /// Request generated xStudents usernames and passwords by xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        public ResponseMulti<XStudentType> GetXStudentUsers(string refId, int? navigationPage, int? navigationPageSize)
        {
            return aUPPObject.GetXStudentUsers(refId, navigationPage, navigationPageSize);
        }

        ///// <summary>
        ///// Request generated xContacts usernames and passwords by xSchool.
        ///// </summary>
        ///// <param name="refId">RefId of xSchool.</param>
        ///// <returns>List of xContacts type.</returns>
        //private ResponseMulti<XContactType> GetXContactUsers(string refId)
        //{
        //    return aUPPObject.GetXContactUsers(refId);
        //}

        ///// <summary>
        ///// Request generated xContacts usernames and passwords by xSchool with paging.
        ///// </summary>
        ///// <param name="refId">RefId of xSchool.</param>
        ///// <param name="navigationPage">Page to retrieve.</param>
        ///// <param name="navigationPageSize">Number of resources to retrieve.</param
        ///// <returns>List of xContacts type.</returns>
        //private ResponseMulti<XContactType> GetXContactUsers(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    return aUPPObject.GetXContactUsers(refId, navigationPage, navigationPageSize);
        //}
        #endregion
    }
}
