using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7.0
 * Since       2019-01-03
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// XCourses Service Paths.
    /// </summary>
    class XCoursesObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XCourses Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XCoursesObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all xCourses.
        /// </summary>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCourses()
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCourses, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses by school year.
        /// </summary>
        /// <param name="schoolYear"></param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCourses(int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCourses, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCourses, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCourses, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourse value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCourses(string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCourses, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourse value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCourses, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xCourse by refId.
        /// </summary>
        /// <param name="refId">RefId of xCourse.</param>
        /// <returns>Single xCourses type.</returns>
        internal ResponseSingle<XCourseType> GetXCourse(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCourseByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xCourse by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourse.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xCourses type.</returns>
        internal ResponseSingle<XCourseType> GetXCourse(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCourseByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXLea(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xLea by refId wtih paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCourses associated to a specific xRoster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xRoster.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCourses value changes from a given point by a specific xRoster with paging.
        /// </summary>
        /// <param name="refId">RefId of xRoster.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCourses type.</returns>
        internal ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCoursesByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
        }
    }
}
