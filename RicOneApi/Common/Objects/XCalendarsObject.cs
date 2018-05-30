using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6
 * Since       2018-05-15
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// xCalendars Service Paths.
    /// </summary>
    class XCalendarsObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XCalendars Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XCalendarsObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all xCalendars.
        /// </summary>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendars()
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendars, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCalendars by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendars(int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendars, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCalendars with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendars, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCalendars with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendars, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCalendar value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendars(string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendars, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xCalendar value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendars, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xCalendar by refId.
        /// </summary>
        /// <param name="refId">RefId of xCalendar.</param>
        /// <returns>Single xCalendars type.</returns>
        internal ResponseSingle<XCalendarType> GetXCalendar(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xCalendar by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCalendar.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xCalendars type.</returns>
        internal ResponseSingle<XCalendarType> GetXCalendar(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xCalendars associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xCalendars type.</returns>
        internal ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXCalendarsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
        }
    }
}
