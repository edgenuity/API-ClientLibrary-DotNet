using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;
using System;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7.0
 * Since       2019-01-03
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
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        internal void CreateXStaffUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.CREATE);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request deletion of generated xStaffs passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        internal void DeleteXStaffUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.DELETE);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request deletion of generated xStaffs usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        internal void DeleteXStaffUsernamesPasswords(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.DELETEUSERNAMESPASSWORDS);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
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
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        internal void CreateXStudentUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.CREATE);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request deletion of generated xStudents passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        internal void DeleteXStudentUsers(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.DELETE);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request deletion of generated xStudents usernames and passwords by xSchool.
        /// </summary>
        /// <param name="refId">RefId of xSchool.</param>
        [Obsolete("As of version 1.7, the process is handled automatically by the API.")]
        internal void DeleteXStudentUsernamesPasswords(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(AUPPEnum.DELETEUSERNAMESPASSWORDS);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStudentsByXSchool, refId, rh, rqp);
            rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
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
        /// Request generated xStudents usernames and passwords by xSchool with paging.
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
