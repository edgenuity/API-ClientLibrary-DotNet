using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-15
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// xSchools Service Paths.
    /// </summary>
    class XSchoolsObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XSchools Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XSchoolsObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all xSchools.
        /// </summary>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchools()
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchools, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xSchools by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchools(int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchools, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xSchools with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchools, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xSchools with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchools, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchools(string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchools, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xSchools value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchools, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>Single xSchools type.</returns>
        internal ResponseSingle<XSchoolType> GetXSchool(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xSchools type.</returns>
        internal ResponseSingle<XSchoolType> GetXSchool(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xSchool by BEDS code or Local Id.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <returns>Single xSchools type.</returns>
        internal ResponseSingle<XSchoolType> GetXSchool(string idType, string id)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(idType, id);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolById, rh, rqp);
            return rr.MakeSingleRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xSchool by BEDS code or Local Id by school year.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xSchools type.</returns>
        internal ResponseSingle<XSchoolType> GetXSchool(string idType, string id, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(idType, id, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolById, rh, rqp);
            return rr.MakeSingleRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCalendar by refId.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXCalendar, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCalendar by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXCalendar, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCalendar by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXCalendar, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCalendar by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xCalendars.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXCalendar, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCourse by refId.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXCourse, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCourse by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXCourse, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCourse by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXCourse, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xCourse by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXCourse, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xRoster by refId by school year. 
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xRoster by refId with paging by school year. 
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStaff by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStaff by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStudent by refId by school year. 
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStudent by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xStudent by refId with paging by school year. 
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xContact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xContact by refId by school year. 
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xContact by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xSchools associated to a specific xContact by refId with paging by school year. 
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xSchools type.</returns>
        internal ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXSchoolsByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
        }
    }
}
