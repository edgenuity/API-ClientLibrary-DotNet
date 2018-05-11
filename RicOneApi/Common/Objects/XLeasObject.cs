using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Common.Objects
{
    public class XLeasObject
    {
        private RestClient rc;
        private string baseApiUrl;

        public XLeasObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all Leas.
        /// </summary>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeas()
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all Leas by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeas(int? schoolYear)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all Leas with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all Leas with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all Lea value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeas(string opaqueMarker)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all Lea value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeas, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        
        /// <summary>
        /// Request single Lea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <returns>Single Lea.</returns>
        public ResponseSingle<XLeaType> GetXLea(string refId)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeaByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single Lea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLea.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single Lea.</returns>
        public ResponseSingle<XLeaType> GetXLea(string refId, int? schoolYear)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeaByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single Lea by BEDS code or Local Id.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <returns>Single Lea.</returns>
        public ResponseSingle<XLeaType> GetXLea(string idType, string id)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(idType, id);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeaById, id, rh, rqp);
            return rr.MakeSingleRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single Lea by BEDS code or Local Id by school year.
        /// </summary>
        /// <param name="idType">Header value can be set to beds or local.</param>
        /// <param name="id">BEDS or Local Id.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single Lea.</returns>
        public ResponseSingle<XLeaType> GetXLea(string idType, string id, int? schoolYear)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(idType, id, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeaById, id, rh, rqp);
            return rr.MakeSingleRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request Leas associated to a specific School by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request Leas associated to a specific School by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? schoolYear)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request Leas associated to a specific School by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request Leas associated to a specific School by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            Rest.RestResponse rr = new Rest.RestResponse();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXLeasByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request Leas associated to a specific Roster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Roster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? schoolYear)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Roster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
     
        }

        /// <summary>
        /// Request Leas associated to a specific Roster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Staff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Staff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? schoolYear)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Staff by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Staff by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Student by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Student by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? schoolYear)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Student by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param></param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Student by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Contact by refId.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Contact by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? schoolYear)
        {

        }

        /// <summary>
        /// Request Leas associated to a specific Contact by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
   
        }

        /// <summary>
        /// Request Leas associated to a specific Contact by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xContact.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>All Leas.</returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {

        }

    }
}
