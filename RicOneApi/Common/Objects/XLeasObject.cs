using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// xLeas Service Paths.
    /// </summary>
    class XLeasObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XLeas Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XLeasObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all xLeas.
        /// </summary>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeas()
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xLeas by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeas(int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xLeas with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xLeas with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xLeas value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeas(string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xLeas value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <returns>Single xLeas type.</returns>
        internal ResponseSingle<XLeaType> GetXLea(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeaByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xLeas type.</returns>
        internal ResponseSingle<XLeaType> GetXLea(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeaByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xLea by BEDS code or Local Id.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <returns>Single xLeas type.</returns>
        internal ResponseSingle<XLeaType> GetXLea(string idType, string id)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(idType, id);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeaById, rh, rqp);
            return rr.MakeSingleRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xLea by BEDS code or Local Id by school year.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xLeas type.</returns>
        internal ResponseSingle<XLeaType> GetXLea(string idType, string id, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(idType, id, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeaById, rh, rqp);
            return rr.MakeSingleRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXSchool(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXRoster(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xRoster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXStaff(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStaff by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStaff by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPage, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXStudent(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStudent by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param></param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xStudent by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xContact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXContact(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xContact by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xContact by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xLeas associated to a specific xContact by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xLeas type.</returns>
        internal ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }
    }
}
