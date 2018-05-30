using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6
 * Since       2018-05-22
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// AUPP Service Paths.
    /// </summary>
    class AUPPObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// AUPP Object Contstructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal AUPPObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request creation of xStaffs usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> CreateXStaffUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.CREATE);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }
        /// <summary>
        /// Request deletion of generated xStaffs passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> DeleteXStaffUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.DELETE);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request generated xStaffs usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.GET);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request generated xStaffs usernames and passwords by xSchool with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffUsers(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.GET);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request creation of xStudents usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> CreateXStudentUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.CREATE);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request deletion of generated xStudents passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> DeleteXStudentUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.DELETE);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request generated xStudents usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.GET);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request generated xStudents usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStudents type.</returns>
        internal ResponseMulti<XStudentType> GetXStudentUsers(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.GET);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        ///// <summary>
        ///// Request creation of xContacts usernames and passwords by xSchool.
        ///// </summary>
        ///// <param name="refId">RefId of xSchool.</param>
        ///// <returns>List of xContacts type.</returns>
        //private ResponseMulti<XContactType> CreateXContactUsers(string refId)
        //{
        //    RestReturn rr = new RestReturn();
        //    RestHeader rh = new RestHeader();
        //    RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.CREATE.Value);
        //    RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXSchool, refId, rh, rqp);
        //    return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        //}

        ///// <summary>
        ///// Request deletion of generated xContacts passwords by xSchool.
        ///// </summary>
        ///// <param name="refId">RefId of xSchool.</param>
        ///// <returns>List of xContacts type.</returns>

        //private ResponseMulti<XContactType> DeleteXContactUsers(string refId)
        //{
        //    RestReturn rr = new RestReturn();
        //    RestHeader rh = new RestHeader();
        //    RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.DELETE.Value);
        //    RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXSchool, refId, rh, rqp);
        //    return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        //}

        ///// <summary>
        ///// Request generated xContacts usernames and passwords by xSchool.
        ///// </summary>
        ///// <param name="refId">RefId of xSchool.</param>
        ///// <returns>List of xContacts type.</returns>
        //private ResponseMulti<XContactType> GetXContactUsers(string refId)
        //{
        //    RestReturn rr = new RestReturn();
        //    RestHeader rh = new RestHeader();
        //    RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.GET.Value);
        //    RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXSchool, refId, rh, rqp);
        //    return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
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
        //    RestReturn rr = new RestReturn();
        //    RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
        //    RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.GET.Value);
        //    RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXContactsByXSchool, refId, rh, rqp);
        //    return rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
        //}
    }
}
