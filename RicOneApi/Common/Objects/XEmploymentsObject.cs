using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.8.0
 * Since       2019-11-15
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// xEmployments Service Paths.
    /// </summary>
    class XEmploymentsObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XEmployments Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XEmploymentsObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all xEmployments.
        /// </summary>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmployments()
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmployments, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmployments(int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmployments, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmployments(int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmployments, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmployments(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmployments, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmployments(string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmployments, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmployments(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmployments, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xEmployment by refId.
        /// </summary>
        /// <param name="refId">RefId of xEmployment.</param>
        /// <returns>Single xEmployments type.</returns>
        internal ResponseSingle<XEmploymentType> GetXEmployment(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xEmployment by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xEmployment.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xEmployments type.</returns>
        internal ResponseSingle<XEmploymentType> GetXEmployment(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xEmployments associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXLea(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xEmployments associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXLea(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xEmployments associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xEmployments associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments value changes from a given point by a specific xLea.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXLea(string refId, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments value changes from a given point by a specific xLea with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXLea(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xEmployments associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXSchool(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xEmployments associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXSchool(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xEmployments associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xEmployments associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments value changes from a given point by a specific xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXSchool(string refId, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xEmployments value changes from a given point by a specific xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xEmployments type.</returns>
        internal ResponseMulti<XEmploymentType> GetXEmploymentsByXSchool(string refId, int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXEmploymentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XEmploymentType, XEmploymentCollectionType>(rc, rp);
        }
    }
}
