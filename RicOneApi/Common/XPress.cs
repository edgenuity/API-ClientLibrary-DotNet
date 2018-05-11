/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.5.1
 * Since       2017-01-27
 * Filename    XPress.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using RicOneApi;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using RicOneApi.Common.Objects;

namespace RicOneApi.Api
{
    /// <summary>
    /// Static class built off of RICOne client to allow access to xPress data model objects
    /// </summary>
    public class XPress
    {
        private readonly XLeasObject xLeasObject;

        public XPress(string baseApiUrl)
        {
            RestClient restClient = new RestClient(baseApiUrl);
            xLeasObject = new XLeasObject(restClient, baseApiUrl);
            //this.baseApiUrl = baseApiUrl;
            DecodedToken dt = new DecodedToken(Authenticator.Instance.GetToken());

            if (Util.ConvertUnixTime(dt.GetDecodedToken().exp) <= DateTime.Now)
            {
                Authenticator.Instance.RefreshToken();
                restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(Authenticator.Instance.GetToken(), "Bearer");
            }
            else
            {
                restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(Authenticator.Instance.GetToken(), "Bearer");
            }
        }

        # region xLeas
        public ResponseMulti<XLeaType> GetXLeas()
        {
            return xLeasObject.GetXLeas();
        }
        public ResponseMulti<XLeaType> GetXLeas(int? schoolYear)
        {
            return xLeasObject.GetXLeas(schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeas(navigationPage, navigationPageSize);
        }
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeas(navigationPage, navigationPageSize, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeas(string opaqueMarker)
        {
            return xLeasObject.GetXLeas(opaqueMarker);
        }
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            return xLeasObject.GetXLeas(navigationPage, navigationPageSize, opaqueMarker);
        }
        public ResponseSingle<XLeaType> GetXLea(string refId)
        {
            return xLeasObject.GetXLea(refId);
        }
        public ResponseSingle<XLeaType> GetXLea(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLea(refId, schoolYear);
        }
        public ResponseSingle<XLeaType> GetXLea(string idType, string id)
        {
            return xLeasObject.GetXLea(idType, id);
        }
        public ResponseSingle<XLeaType> GetXLea(string idType, string id, int? schoolYear)
        {
            return xLeasObject.GetXLea(idType, id, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId)
        {
            return xLeasObject.GetXLeasByXSchool(refId);
        }
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXSchool(refId, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXSchool(refId, navigationPage, navigationPageSize);
        }
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXSchool(refId, navigationPage, navigationPageSize, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId)
        {
            return xLeasObject.GetXLeasByXRoster(refId);
        }
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXRoster(refId, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXRoster(refId, navigationPage, navigationPageSize);
        }
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXRoster(refId, navigationPage, navigationPageSize, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId)
        {
            return xLeasObject.GetXLeasByXStaff(refId);
        }
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXStaff(refId, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXStaff(refId, navigationPage, navigationPageSize);
        }
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXStaff(refId, navigationPage, navigationPageSize, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId)
        {
            return xLeasObject.GetXLeasByXStudent(refId);
        }
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXStudent(refId, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXStudent(refId, navigationPage, navigationPageSize);
        }
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXStudent(refId, navigationPage, navigationPageSize, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId)
        {
            return xLeasObject.GetXLeasByXContact(refId);
        }
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXContact(refId, schoolYear);
        }
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            return xLeasObject.GetXLeasByXContact(refId, navigationPage, navigationPageSize);
        }
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            return xLeasObject.GetXLeasByXContact(refId, navigationPage, navigationPageSize, schoolYear);
        }
        #endregion

        //#region xSchools
        ///// <summary>
        ///// Request all Schools
        ///// </summary>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xSchools", Method.GET);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// All School value changes from a given point
        ///// </summary>
        ///// <param name="opaqueMarker"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchools(string opaqueMarker)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xSchools", Method.GET);
        //    request.AddQueryParameter("changesSinceMarker", opaqueMarker);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request all Schools
        ///// </summary>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchools()
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xSchools", Method.GET);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseSingle<XSchoolType> GetXSchool(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseSingle<XSchoolType> output = new ResponseSingle<XSchoolType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchool.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseSingle<XSchoolType> GetXSchool(string refId)
        //{
        //    ResponseSingle<XSchoolType> output = new ResponseSingle<XSchoolType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchool.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request School by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseSingle<XSchoolType> GetXSchool(string idType, string id)
        //{
        //    ResponseSingle<XSchoolType> output = new ResponseSingle<XSchoolType>();

        //    RestRequest request = new RestRequest("xSchools/{id}", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchool.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Lea by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string idType, string id)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xLeas/{id}/xSchools", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Calendar by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xCalendars/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Calendar by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xCalendars/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Course by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xCourses/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Course by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xCourses/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Staff by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xStaffs/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Staff by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xStaffs/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Returns Schools associated to a specific Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Contact by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xContacts/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Schools associated to a specific Contact by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId)
        //{
        //    ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

        //    RestRequest request = new RestRequest("xContacts/{refId}/xSchools", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XSchoolCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xSchools.xSchool;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        //#endregion

        //#region xCalendars
        ///// <summary>
        ///// Request all Calendars
        ///// </summary>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xCalendars", Method.GET);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// All Calendar value changes from a given point
        ///// </summary>
        ///// <param name="opaqueMarker"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendars(string opaqueMarker)
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xCalendars", Method.GET);
        //    request.AddQueryParameter("changesSinceMarker", opaqueMarker);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request all Calendars
        ///// </summary>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendars()
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xCalendars", Method.GET);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Calendar by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseSingle<XCalendarType> GetXCalendar(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseSingle<XCalendarType> output = new ResponseSingle<XCalendarType>();

        //    RestRequest request = new RestRequest("xCalendars/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendar.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Calendar by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseSingle<XCalendarType> GetXCalendar(string refId)
        //{
        //    ResponseSingle<XCalendarType> output = new ResponseSingle<XCalendarType>();

        //    RestRequest request = new RestRequest("xCalendars/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendar.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Calendars associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xCalendars", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Calendars associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId)
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xCalendars", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Calendars associated to a specific Lea by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string idType, string id)
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xLeas/{id}/xCalendars", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Calendars associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xCalendars", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Calendars associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId)
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xCalendars", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Calendars associated to a specific School by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string idType, string id)
        //{
        //    ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

        //    RestRequest request = new RestRequest("xSchools/{id}/xCalendars", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCalendarCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCalendars.xCalendar;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        //#endregion

        //#region xCourses
        ///// <summary>
        ///// Request all Courses
        ///// </summary>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xCourses", Method.GET);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// All Coruse value changes from a given point
        ///// </summary>
        ///// <param name="opaqueMarker"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCourses(string opaqueMarker)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xCourses", Method.GET);
        //    request.AddQueryParameter("changesSinceMarker", opaqueMarker);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request all Courses
        ///// </summary>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCourses()
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xCourses", Method.GET);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Request single Course by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseSingle<XCourseType> GetXCourse(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseSingle<XCourseType> output = new ResponseSingle<XCourseType>();

        //    RestRequest request = new RestRequest("xCourses/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourse.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Course by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseSingle<XCourseType> GetXCourse(string refId)
        //{
        //    ResponseSingle<XCourseType> output = new ResponseSingle<XCourseType>();

        //    RestRequest request = new RestRequest("xCourses/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourse.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Courses associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xCourses", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Courses associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xCourses", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Courses associated to a specific Lea by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCoursesByXLea(string idType, string id)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xLeas/{id}/xCourses", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Courses associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xCourses", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Courses associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xCourses", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Courses associated to a specific School by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCoursesByXSchool(string idType, string id)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xSchools/{id}/xCourses", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Courses associated to a specific Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();


        //    RestRequest request = new RestRequest("xRosters/{refId}/xCourses", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Courses associated to a specific Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId)
        //{
        //    ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}/xCourses", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XCourseCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xCourses.xCourse;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        //#endregion

        //#region xRosters
        ///// <summary>
        ///// Request all Rosters
        ///// </summary>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRosters(int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xRosters", Method.GET);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// All Roster value changes from a given point
        ///// </summary>
        ///// <param name="opaqueMarker"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRosters(string opaqueMarker)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xRosters", Method.GET);
        //    request.AddQueryParameter("changesSinceMarker", opaqueMarker);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request all Rosters
        ///// </summary>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRosters()
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xRosters", Method.GET);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseSingle<XRosterType> GetXRoster(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseSingle<XRosterType> output = new ResponseSingle<XRosterType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRoster.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseSingle<XRosterType> GetXRoster(string refId)
        //{
        //    ResponseSingle<XRosterType> output = new ResponseSingle<XRosterType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRoster.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}   
        ///// <summary>
        ///// Returns Rosters associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXLea(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXLea(string refId)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific Lea by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXLea(string idType, string id)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xLeas/{id}/xRosters", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific School by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXSchool(string idType, string id)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xSchools/{id}/xRosters", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific Course by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xCourses/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific Course by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xCourses/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific Staff by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xStaffs/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific Staff by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xStaffs/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Rosters associated to a specific Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId)
        //{
        //    ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}/xRosters", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XRosterCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xRosters.xRoster;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        //#endregion

        //#region xStaffs
        ///// <summary>
        ///// Request all Staffs
        ///// </summary>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xStaffs", Method.GET);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// All Staff value changes from a given point
        ///// </summary>
        ///// <param name="opaqueMarker"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffs(string opaqueMarker)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xStaffs", Method.GET);
        //    request.AddQueryParameter("changesSinceMarker", opaqueMarker);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request all Staffs
        ///// </summary>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffs()
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xStaffs", Method.GET);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Staffs by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseSingle<XStaffType> GetXStaff(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseSingle<XStaffType> output = new ResponseSingle<XStaffType>();

        //    RestRequest request = new RestRequest("xStaffs/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaff.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Staffs by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseSingle<XStaffType> GetXStaff(string refId)
        //{
        //    ResponseSingle<XStaffType> output = new ResponseSingle<XStaffType>();

        //    RestRequest request = new RestRequest("xStaffs/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaff.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staff associated to a specific Lea by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXLea(string idType, string id)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xLeas/{id}/xStaffs", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staff associated to a specific School by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXSchool(string idType, string id)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xSchools/{id}/xStaffs", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific Course by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xCourses/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific Course by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xCourses/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Staffs associated to a specific Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        //#endregion

        //#region xStudents
        ///// <summary>
        ///// Request all Students
        ///// </summary>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xStudents", Method.GET);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        //public ResponseMulti<XStudentType> GetXStudents(string opaqueMarker)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xStudents", Method.GET);
        //    request.AddQueryParameter("changesSinceMarker", opaqueMarker);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request all Students
        ///// </summary>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudents()
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xStudents", Method.GET);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseSingle<XStudentType> GetXStudent(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseSingle<XStudentType> output = new ResponseSingle<XStudentType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudent.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseSingle<XStudentType> GetXStudent(string refId)
        //{
        //    ResponseSingle<XStudentType> output = new ResponseSingle<XStudentType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudent.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Lea by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXLea(string idType, string id)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xLeas/{id}/xStudents", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific School by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXSchool(string idType, string id)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xSchools/{id}/xStudents", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Roster by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xRosters/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Staff by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xStaffs/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Staff by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xStaffs/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Contact by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xContacts/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Students associated to a specific Contact by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xContacts/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        //#endregion xStudents

        //#region xContacts
        ///// <summary>
        ///// Request all Contacts
        ///// </summary>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xContacts", Method.GET);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// All Contact value changes from a given point
        ///// </summary>
        ///// <param name="opaqueMarker"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContacts(string opaqueMarker)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xContacts", Method.GET);
        //    request.AddQueryParameter("changesSinceMarker", opaqueMarker);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request all Contacts
        ///// </summary>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContacts()
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xContacts", Method.GET);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Contact by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseSingle<XContactType> GetXContact(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseSingle<XContactType> output = new ResponseSingle<XContactType>();

        //    RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContact.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Request single Contact by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseSingle<XContactType> GetXContact(string refId)
        //{
        //    ResponseSingle<XContactType> output = new ResponseSingle<XContactType>();

        //    RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContact.First();
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Contacts associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Contacts associated to a specific Lea by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContactsByXLea(string refId)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Contacts associated to a specific Lea by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContactsByXLea(string idType, string id)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xLeas/{id}/xContacts", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Contacts associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Contacts associated to a specific School by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContactsByXSchool(string refId)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Contacts associated to a specific School by BEDS code or Local Id. Header IdType value can be set to beds or local
        ///// </summary>
        ///// <param name="idType"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContactsByXSchool(string idType, string id)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xSchools/{id}/xContacts", Method.GET);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);
        //    request.AddHeader("IdType", idType);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Contacts associated to a specific Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns Contacts associated to a specific Student by refId
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XContactType> GetXContactsByXStudent(string refId)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        //#endregion

        //#region navigationLastPage

        ///// <summary>
        ///// Enumerator used to retrieve service path object for max page size
        ///// </summary>
        //public enum ServicePath
        //{
        //    GetXLeas = 1,
        //    GetXLeasByXSchool = 2,
        //    GetXLeasByXStudent = 3,
        //    GetXLeasByXContact = 4,
        //    GetXSchools = 5,
        //    GetXSchoolsByXLea = 6,
        //    GetXSchoolsByXCalendar = 7,
        //    GetXSchoolsByXCourse = 8,
        //    GetXSchoolsByXRoster = 9,
        //    GetXSchoolsByXStaff = 10,
        //    GetXSchoolsByXStudent = 11,
        //    GetXSchoolsByXContact = 12,
        //    GetXCalendars = 13,
        //    GetXCalendarsByXSchool = 14,
        //    GetXCourses = 15,
        //    GetXCoursesByXLea = 16,
        //    GetXRosters = 17,
        //    GetXRostersByXLea = 18,
        //    GetXRostersByXSchool = 19,
        //    GetXRostersByXCourse = 20,
        //    GetXRostersByXStaff = 21,
        //    GetXRostersByXStudent = 22,
        //    GetXStaffs = 23,
        //    GetXStaffsByXLea = 24,
        //    GetXStaffsByXSchool = 25,
        //    GetXStaffsByXCourse = 26,
        //    GetXStaffsByXRoster = 27,
        //    GetXStudents = 28,
        //    GetXStudentsByXLea = 29,
        //    GetXStudentsByXSchool = 30,
        //    GetXStudentsByXRoster = 31,
        //    GetXStudentsByXStaff = 32,
        //    GetXStudentsByXContact = 33,
        //    GetXContacts = 34,
        //    GetXContactsByXLea = 35,
        //    GetXContactsByXSchool = 36,
        //    GetXContactsByXStudent = 37,
        //    GetXLeasByXRoster = 38,
        //    GetXLeasByXStaff = 39,
        //    GetXCalendarsByXLea = 40,
        //    GetXCoursesByXSchool = 41,
        //    GetXCoursesByXRoster = 42,
        //    GetXStaffsByXStudent = 43
        //}

        //public ServicePath myServicePath { get; set; }
        ///// <summary>
        ///// Max page value for specified service path object
        ///// </summary>
        ///// <param name="navigationPageSize"></param>
        ///// <param name="p"></param>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public int GetLastPage(int navigationPageSize, ServicePath p, string refId)
        //{
        //    string path = "";
        //    int navigationLastPage = 0;

        //    switch (p)
        //    {
        //        case ServicePath.GetXLeas:
        //            path = "xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXSchool:
        //            path = "xSchools/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXRoster:
        //            path = "xRosters/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXStaff:
        //            path = "xStaffs/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXStudent:
        //            path = "xStudents/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXContact:
        //            path = "xContacts/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXSchools:
        //            path = "xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXLea:
        //            path = "xLeas/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXCalendar:
        //            path = "xCalendars/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXCourse:
        //            path = "xCourses/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXRoster:
        //            path = "xRosters/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXStaff:
        //            path = "xStaffs/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXStudent:
        //            path = "xStudents/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXContact:
        //            path = "xContacts/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXCalendars:
        //            path = "xCalendars";
        //            break;
        //        case ServicePath.GetXCalendarsByXLea:
        //            path = "xLeas/{refId}/xCalendars";
        //            break;
        //        case ServicePath.GetXCalendarsByXSchool:
        //            path = "xSchools/{refId}/xCalendars";
        //            break;
        //        case ServicePath.GetXCourses:
        //            path = "xCourses";
        //            break;
        //        case ServicePath.GetXCoursesByXLea:
        //            path = "xLeas/{refId}/xCourses";
        //            break;
        //        case ServicePath.GetXCoursesByXSchool:
        //            path = "xSchools/{refId}/xCourses";
        //            break;
        //        case ServicePath.GetXCoursesByXRoster:
        //            path = "xRosters/{refId}/xCourses";
        //            break;
        //        case ServicePath.GetXRosters:
        //            path = "xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXLea:
        //            path = "xLeas/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXSchool:
        //            path = "xSchools/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXCourse:
        //            path = "xCourses/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXStaff:
        //            path = "xStaffs/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXStudent:
        //            path = "xStudents/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXStaffs:
        //            path = "xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXLea:
        //            path = "xLeas/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXSchool:
        //            path = "xSchools/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXCourse:
        //            path = "xCourses/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXRoster:
        //            path = "xRosters/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXStudent:
        //            path = "xStudents/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStudents:
        //            path = "xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXLea:
        //            path = "xLeas/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXSchool:
        //            path = "xSchools/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXRoster:
        //            path = "xRosters/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXStaff:
        //            path = "xStaffs/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXContact:
        //            path = "xContacts/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXContacts:
        //            path = "xContacts";
        //            break;
        //        case ServicePath.GetXContactsByXLea:
        //            path = "xLeas/{refId}/xContacts";
        //            break;
        //        case ServicePath.GetXContactsByXSchool:
        //            path = "xSchools/{refId}/xContacts";
        //            break;
        //        case ServicePath.GetXContactsByXStudent:
        //            path = "xStudents/{refId}/xContacts";
        //            break;
        //    }

        //    RestRequest request = new RestRequest(path, Method.GET);
        //    request.AddHeader("Accept", "application/json");

        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddHeader("navigationPage", "1");
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute(request);

        //    try
        //    {
        //        navigationLastPage = Int32.Parse(response.Headers.ToList()
        //        .Find(x => x.Name.Equals("navigationLastPage", StringComparison.CurrentCultureIgnoreCase))
        //        .Value.ToString());
        //    }
        //    catch(NullReferenceException)
        //    {
        //        navigationLastPage = 0;
        //    }

        //    return navigationLastPage;
        //}
        ///// <summary>
        ///// Max page value for specified service path object
        ///// </summary>
        ///// <param name="navigationPageSize"></param>
        ///// <param name="p"></param>
        ///// <returns></returns>
        //public int GetLastPage(int navigationPageSize, ServicePath p)
        //{
        //    string path = "";
        //    int navigationLastPage = 0;

        //    switch (p)
        //    {
        //        case ServicePath.GetXLeas:
        //            path = "xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXSchool:
        //            path = "xSchools/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXRoster:
        //            path = "xRosters/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXStaff:
        //            path = "xStaffs/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXStudent:
        //            path = "xStudents/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXLeasByXContact:
        //            path = "xContacts/{refId}/xLeas";
        //            break;
        //        case ServicePath.GetXSchools:
        //            path = "xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXLea:
        //            path = "xLeas/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXCalendar:
        //            path = "xCalendars/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXCourse:
        //            path = "xCourses/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXRoster:
        //            path = "xRosters/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXStaff:
        //            path = "xStaffs/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXStudent:
        //            path = "xStudents/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXSchoolsByXContact:
        //            path = "xContacts/{refId}/xSchools";
        //            break;
        //        case ServicePath.GetXCalendars:
        //            path = "xCalendars";
        //            break;
        //        case ServicePath.GetXCalendarsByXLea:
        //            path = "xLeas/{refId}/xCalendars";
        //            break;
        //        case ServicePath.GetXCalendarsByXSchool:
        //            path = "xSchools/{refId}/xCalendars";
        //            break;
        //        case ServicePath.GetXCourses:
        //            path = "xCourses";
        //            break;
        //        case ServicePath.GetXCoursesByXLea:
        //            path = "xLeas/{refId}/xCourses";
        //            break;
        //        case ServicePath.GetXCoursesByXSchool:
        //            path = "xSchools/{refId}/xCourses";
        //            break;
        //        case ServicePath.GetXCoursesByXRoster:
        //            path = "xRosters/{refId}/xCourses";
        //            break;
        //        case ServicePath.GetXRosters:
        //            path = "xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXLea:
        //            path = "xLeas/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXSchool:
        //            path = "xSchools/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXCourse:
        //            path = "xCourses/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXStaff:
        //            path = "xStaffs/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXRostersByXStudent:
        //            path = "xStudents/{refId}/xRosters";
        //            break;
        //        case ServicePath.GetXStaffs:
        //            path = "xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXLea:
        //            path = "xLeas/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXSchool:
        //            path = "xSchools/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXCourse:
        //            path = "xCourses/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXRoster:
        //            path = "xRosters/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStaffsByXStudent:
        //            path = "xStudents/{refId}/xStaffs";
        //            break;
        //        case ServicePath.GetXStudents:
        //            path = "xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXLea:
        //            path = "xLeas/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXSchool:
        //            path = "xSchools/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXRoster:
        //            path = "xRosters/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXStaff:
        //            path = "xStaffs/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXStudentsByXContact:
        //            path = "xContacts/{refId}/xStudents";
        //            break;
        //        case ServicePath.GetXContacts:
        //            path = "xContacts";
        //            break;
        //        case ServicePath.GetXContactsByXLea:
        //            path = "xLeas/{refId}/xContacts";
        //            break;
        //        case ServicePath.GetXContactsByXSchool:
        //            path = "xSchools/{refId}/xContacts";
        //            break;
        //        case ServicePath.GetXContactsByXStudent:
        //            path = "xStudents/{refId}/xContacts";
        //            break;
        //    }

        //    RestRequest request = new RestRequest(path, Method.GET);
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", "1");
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute(request);

        //    try
        //    {
        //        navigationLastPage = Int32.Parse(response.Headers.ToList()
        //        .Find(x => x.Name.Equals("navigationLastPage", StringComparison.CurrentCultureIgnoreCase))
        //        .Value.ToString());
        //    }
        //    catch(NullReferenceException)
        //    {
        //        navigationLastPage = 0;
        //    }

        //    return navigationLastPage;
        //}

        //#endregion
        //#region App Provisioning Info
        ///// <summary>
        ///// Create staff usernames and passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> CreateXStaffUsers(string refId)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("createUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Delete generated staff passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> DeleteXStaffUsers(string refId)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("deleteUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Return generated staff usernames and passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffUsers(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("getUsers", "true");
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Return generated staff usernames and passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStaffType> GetXStaffUsers(string refId)
        //{
        //    ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("getUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStaffCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStaffs.xStaff;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Create student usernames and passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> CreateXStudentUsers(string refId)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("createUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Delete generated student passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> DeleteXStudentUsers(string refId)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("deleteUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Return generated student usernames and passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <param name="navigationPage"></param>
        ///// <param name="navigationPageSize"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentUsers(string refId, int? navigationPage, int? navigationPageSize)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("getUsers", "true");
        //    request.AddHeader("Accept", "application/json");
        //    request.AddHeader("navigationPage", navigationPage.ToString());
        //    request.AddHeader("navigationPageSize", navigationPageSize.ToString());

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Return generated student usernames and passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //public ResponseMulti<XStudentType> GetXStudentUsers(string refId)
        //{
        //    ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("getUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XStudentCollectionType>(request);

        //    try
        //    {
        //        output.Data = response.Data.xStudents.xStudent;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Create contact usernames and passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //private ResponseMulti<XContactType> CreateXContactUsers(string refId)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("createUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);
        //    Console.WriteLine(response.ResponseUri);
        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Delete generated contact passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>

        //private ResponseMulti<XContactType> DeleteXContactUsers(string refId)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("deleteUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);
        //    Console.WriteLine(response.ResponseUri);
        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Return generated contact usernames and passwords by school
        ///// </summary>
        ///// <param name="refId"></param>
        ///// <returns></returns>
        //private ResponseMulti<XContactType> GetXContactUsers(string refId)
        //{
        //    ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

        //    RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
        //    request.AddParameter("refId", refId, ParameterType.UrlSegment);
        //    request.AddQueryParameter("getUsers", "true");
        //    request.AddHeader("Accept", "application/json");

        //    var response = restClient.Execute<XContactCollectionType>(request);
        //    Console.WriteLine(response.ResponseUri);
        //    try
        //    {
        //        output.Data = response.Data.xContacts.xContact;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }
        //    catch (Exception)
        //    {
        //        output.Data = null;
        //        output.StatusCode = (int)response.StatusCode;
        //        output.Message = response.StatusDescription;
        //        output.Header = Util.BuildHeader(response);
        //    }

        //    return output;
        //}
        //#endregion
    }
}
