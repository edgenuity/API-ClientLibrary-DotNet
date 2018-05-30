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
    /// xContacts Service Paths.
    /// </summary>
    class XContactsObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XContacts Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XContactsObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all xContacts.
        /// </summary>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContacts()
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContacts, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xContacts by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContacts(int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContacts, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xContacts with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContacts, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xContacts with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContacts, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContacts(string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContacts, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xContacts value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContacts, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xContact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <returns>Single xContacts type.</returns>
        internal ResponseSingle<XContactType> GetXContact(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xContact by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xContacts type.</returns>
        internal ResponseSingle<XContactType> GetXContact(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXLea(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXSchool(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXStudent(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xStudent by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xContacts associated to a specific xStudent by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudent.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xContacts type.</returns>
        internal ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        }
    }
}
