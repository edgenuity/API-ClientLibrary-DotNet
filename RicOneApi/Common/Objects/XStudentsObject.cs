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
    /// xStudents Service Paths.
    /// </summary>
    class XStudentsObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XStudents Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XStudentsObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all xStudents.
        /// </summary>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudents()
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudents, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStudents by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudents(int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudents, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStudents with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudents, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStudents with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudents, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudents(string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudents, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStudents value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudents, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>Single xStudents type.</returns>
        internal ResponseSingle<XStudentType> GetXStudent(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xStudents type.</returns>
        internal ResponseSingle<XStudentType> GetXStudent(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXLea(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xRoster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xStaff by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xStaff by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXStaff, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xContact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXContact(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xContact by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xContact by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStudents associated to a specific xContact by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xContacts.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXContact, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }
    }
}
