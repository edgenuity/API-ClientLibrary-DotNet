/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.3.1
 * Since       2016-07-20
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
using RestSharp.Deserializers;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using RicOneApi;

namespace RicOneApi.Api
{
    /// <summary>
    /// Static class built off of RICOne client to allow access to xPress data model objects
    /// </summary>
    public class XPress
    {
        private RestClient restClient;
        private string baseApiUrl;

        public XPress(string baseApiUrl)
        {
            this.baseApiUrl = baseApiUrl;
            this.restClient = new RestClient(baseApiUrl);

            if (Authenticator.Instance.ConvertUnixTime(Authenticator.Instance.GetDecodedToken(Authenticator.Instance.GetToken()).exp) <= DateTime.Now)
            {
                Authenticator.Instance.RefreshToken();
                this.restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(Authenticator.Instance.GetToken(), "Bearer");
            }
            else
            {
                this.restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(Authenticator.Instance.GetToken(), "Bearer");
            }
        }

        # region xLeas
        /// <summary>
        /// Request all Leas
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeas(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xLeas", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Request all Leas
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeas()
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xLeas", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Request single Leas by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XLeaType> GetXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XLeaType> output = new ResponseSingle<XLeaType>();

            RestRequest request = new RestRequest("xLeas/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLea.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Request single Leas by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XLeaType> GetXLea(string refId)
        {
            ResponseSingle<XLeaType> output = new ResponseSingle<XLeaType>();

            RestRequest request = new RestRequest("xLeas/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);
  
            try
            {
                output.Data = response.Data.xLea.First();
                output.StatusCode = (int) response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch(Exception)
            {
                output.Data = null;
                output.StatusCode = (int) response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXSchool(string refId)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXRoster(string refId)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xStaffs/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXStaff(string refId)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xStaffs/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXStudent(string refId)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xContacts/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Leas associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XLeaType> GetXLeasByXContact(string refId)
        {
            ResponseMulti<XLeaType> output = new ResponseMulti<XLeaType>();

            RestRequest request = new RestRequest("xContacts/{refId}/xLeas", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XLeaCollectionType>(request);

            try
            {
                output.Data = response.Data.xLeas.xLea;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        #endregion

        #region xSchools
        /// <summary>
        /// Request all Schools
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchools(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xSchools", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request all Schools
        /// </summary>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchools()
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xSchools", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseSingle<XSchoolType> GetXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XSchoolType> output = new ResponseSingle<XSchoolType>();

            RestRequest request = new RestRequest("xSchools/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchool.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XSchoolType> GetXSchool(string refId)
        {
            ResponseSingle<XSchoolType> output = new ResponseSingle<XSchoolType>();

            RestRequest request = new RestRequest("xSchools/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchool.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXLea(string refId)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xCalendars/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCalendar(string refId)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xCalendars/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xCourses/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXCourse(string refId)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xCourses/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXRoster(string refId)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xStaffs/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStaff(string refId)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xStaffs/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
      
        /// <summary>
        /// Returns Schools associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXStudent(string refId)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xContacts/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Schools associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XSchoolType> GetXSchoolsByXContact(string refId)
        {
            ResponseMulti<XSchoolType> output = new ResponseMulti<XSchoolType>();

            RestRequest request = new RestRequest("xContacts/{refId}/xSchools", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XSchoolCollectionType>(request);

            try
            {
                output.Data = response.Data.xSchools.xSchool;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        #endregion
        
        #region xCalendars
        /// <summary>
        /// Request all Calendars
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XCalendarType> GetXCalendars(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

            RestRequest request = new RestRequest("xCalendars", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCalendarCollectionType>(request);

            try
            {
                output.Data = response.Data.xCalendars.xCalendar;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request all Calendars
        /// </summary>
        /// <returns></returns>
        public ResponseMulti<XCalendarType> GetXCalendars()
        {
            ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

            RestRequest request = new RestRequest("xCalendars", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarCollectionType>(request);

            try
            {
                output.Data = response.Data.xCalendars.xCalendar;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseSingle<XCalendarType> GetXCalendar(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XCalendarType> output = new ResponseSingle<XCalendarType>();

            RestRequest request = new RestRequest("xCalendars/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCalendarCollectionType>(request);

            try
            {
                output.Data = response.Data.xCalendar.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Calendar by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XCalendarType> GetXCalendar(string refId)
        {
            ResponseSingle<XCalendarType> output = new ResponseSingle<XCalendarType>();

            RestRequest request = new RestRequest("xCalendars/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarCollectionType>(request);

            try
            {
                output.Data = response.Data.xCalendar.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Calendars associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xCalendars", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCalendarCollectionType>(request);

            try
            {
                output.Data = response.Data.xCalendars.xCalendar;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Calendars associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXLea(string refId)
        {
            ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xCalendars", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarCollectionType>(request);

            try
            {
                output.Data = response.Data.xCalendars.xCalendar;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Calendars associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xCalendars", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCalendarCollectionType>(request);

            try
            {
                output.Data = response.Data.xCalendars.xCalendar;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Calendars associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XCalendarType> GetXCalendarsByXSchool(string refId)
        {
            ResponseMulti<XCalendarType> output = new ResponseMulti<XCalendarType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xCalendars", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCalendarCollectionType>(request);

            try
            {
                output.Data = response.Data.xCalendars.xCalendar;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        #endregion

        #region xCourses
        /// <summary>
        /// Request all Courses
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XCourseType> GetXCourses(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

            RestRequest request = new RestRequest("xCourses", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourses.xCourse;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request all Courses
        /// </summary>
        /// <returns></returns>
        public ResponseMulti<XCourseType> GetXCourses()
        {
            ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

            RestRequest request = new RestRequest("xCourses", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourses.xCourse;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Request single Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseSingle<XCourseType> GetXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XCourseType> output = new ResponseSingle<XCourseType>();

            RestRequest request = new RestRequest("xCourses/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourse.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XCourseType> GetXCourse(string refId)
        {
            ResponseSingle<XCourseType> output = new ResponseSingle<XCourseType>();

            RestRequest request = new RestRequest("xCourses/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourse.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Courses associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourses.xCourse;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Courses associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XCourseType> GetXCoursesByXLea(string refId)
        {
            ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourses.xCourse;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Courses associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourses.xCourse;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Courses associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XCourseType> GetXCoursesByXSchool(string refId)
        {
            ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourses.xCourse;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Courses associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();


            RestRequest request = new RestRequest("xRosters/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourses.xCourse;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Courses associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XCourseType> GetXCoursesByXRoster(string refId)
        {
            ResponseMulti<XCourseType> output = new ResponseMulti<XCourseType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xCourses", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XCourseCollectionType>(request);

            try
            {
                output.Data = response.Data.xCourses.xCourse;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        #endregion

        #region xRosters
        /// <summary>
        /// Request all Rosters
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRosters(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xRosters", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request all Rosters
        /// </summary>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRosters()
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xRosters", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseSingle<XRosterType> GetXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XRosterType> output = new ResponseSingle<XRosterType>();
       
            RestRequest request = new RestRequest("xRosters/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRoster.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XRosterType> GetXRoster(string refId)
        {
            ResponseSingle<XRosterType> output = new ResponseSingle<XRosterType>();

            RestRequest request = new RestRequest("xRosters/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRoster.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }   
        /// <summary>
        /// Returns Rosters associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXLea(string refId)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXSchool(string refId)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xCourses/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXCourse(string refId)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xCourses/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xStaffs/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXStaff(string refId)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xStaffs/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Rosters associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XRosterType> GetXRostersByXStudent(string refId)
        {
            ResponseMulti<XRosterType> output = new ResponseMulti<XRosterType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xRosters", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XRosterCollectionType>(request);

            try
            {
                output.Data = response.Data.xRosters.xRoster;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        #endregion

        #region xStaffs
        /// <summary>
        /// Request all Staffs
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xStaffs", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request all Staffs
        /// </summary>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffs()
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xStaffs", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Staffs by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseSingle<XStaffType> GetXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XStaffType> output = new ResponseSingle<XStaffType>();

            RestRequest request = new RestRequest("xStaffs/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaff.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Staffs by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XStaffType> GetXStaff(string refId)
        {
            ResponseSingle<XStaffType> output = new ResponseSingle<XStaffType>();

            RestRequest request = new RestRequest("xStaffs/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaff.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXLea(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xCourses/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Course by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xCourses/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Staffs associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        #endregion

        #region xStudents
        /// <summary>
        /// Request all Students
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudents(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xStudents", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request all Students
        /// </summary>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudents()
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xStudents", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseSingle<XStudentType> GetXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XStudentType> output = new ResponseSingle<XStudentType>();

            RestRequest request = new RestRequest("xStudents/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudent.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XStudentType> GetXStudent(string refId)
        {
            ResponseSingle<XStudentType> output = new ResponseSingle<XStudentType>();

            RestRequest request = new RestRequest("xStudents/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudent.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXLea(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXSchool(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific Roster by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXRoster(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xRosters/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xStaffs/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific Staff by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXStaff(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xStaffs/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xContacts/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Students associated to a specific Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentsByXContact(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xContacts/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        #endregion xStudents

        #region xContacts
        /// <summary>
        /// Request all Contacts
        /// </summary>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContacts(int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request all Contacts
        /// </summary>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContacts()
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xContacts", Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseSingle<XContactType> GetXContact(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseSingle<XContactType> output = new ResponseSingle<XContactType>();

            RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContact.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Request single Contact by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseSingle<XContactType> GetXContact(string refId)
        {
            ResponseSingle<XContactType> output = new ResponseSingle<XContactType>();

            RestRequest request = new RestRequest("xContacts/{refId}", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContact.First();
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Lea by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXLea(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xLeas/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific School by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXSchool(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="navigationPage"></param>
        /// <param name="navigationPageSize"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", navigationPage.ToString());
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());

            var response = restClient.Execute<XContactCollectionType>(request);
            
            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Returns Contacts associated to a specific Student by refId
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XContactType> GetXContactsByXStudent(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xStudents/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);

            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        #endregion

        #region navigationLastPage

        /// <summary>
        /// Enumerator used to retrieve service path object for max page size
        /// </summary>
        public enum ServicePath
        {
            GetXLeas = 1,
            GetXLeasByXSchool = 2,
            GetXLeasByXStudent = 3,
            GetXLeasByXContact = 4,
            GetXSchools = 5,
            GetXSchoolsByXLea = 6,
            GetXSchoolsByXCalendar = 7,
            GetXSchoolsByXCourse = 8,
            GetXSchoolsByXRoster = 9,
            GetXSchoolsByXStaff = 10,
            GetXSchoolsByXStudent = 11,
            GetXSchoolsByXContact = 12,
            GetXCalendars = 13,
            GetXCalendarsByXSchool = 14,
            GetXCourses = 15,
            GetXCoursesByXLea = 16,
            GetXRosters = 17,
            GetXRostersByXLea = 18,
            GetXRostersByXSchool = 19,
            GetXRostersByXCourse = 20,
            GetXRostersByXStaff = 21,
            GetXRostersByXStudent = 22,
            GetXStaffs = 23,
            GetXStaffsByXLea = 24,
            GetXStaffsByXSchool = 25,
            GetXStaffsByXCourse = 26,
            GetXStaffsByXRoster = 27,
            GetXStudents = 28,
            GetXStudentsByXLea = 29,
            GetXStudentsByXSchool = 30,
            GetXStudentsByXRoster = 31,
            GetXStudentsByXStaff = 32,
            GetXStudentsByXContact = 33,
            GetXContacts = 34,
            GetXContactsByXLea = 35,
            GetXContactsByXSchool = 36,
            GetXContactsByXStudent = 37,
            GetXLeasByXRoster = 38,
            GetXLeasByXStaff = 39,
            GetXCalendarsByXLea = 40,
            GetXCoursesByXSchool = 41,
            GetXCoursesByXRoster = 42,
            GetXStaffsByXStudent = 43
        }

        public ServicePath myServicePath { get; set; }
        /// <summary>
        /// Max page value for specified service path object
        /// </summary>
        /// <param name="navigationPageSize"></param>
        /// <param name="p"></param>
        /// <param name="refId"></param>
        /// <returns></returns>
        public int GetLastPage(int navigationPageSize, ServicePath p, string refId)
        {
            string path = "";
            int navigationLastPage = 0;

            if (p == ServicePath.GetXLeas)
            {
                path = "xLeas";
            }
            else if (p == ServicePath.GetXLeasByXSchool)
            {
                path = "xSchools/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXRoster)
            {
                path = "xRosters/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXStaff)
            {
                path = "xStaffs/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXStudent)
            {
                path = "xStudents/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXContact)
            {
                path = "xContacts/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXSchools)
            {
                path = "xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXLea)
            {
                path = "xLeas/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXCalendar)
            {
                path = "xCalendars/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXCourse)
            {
                path = "xCourses/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXRoster)
            {
                path = "xRosters/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXStaff)
            {
                path = "xStaffs/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXStudent)
            {
                path = "xStudents/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXContact)
            {
                path = "xContacts/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXCalendars)
            {
                path = "xCalendars";
            }
            else if (p == ServicePath.GetXCalendarsByXLea)
            {
                path = "xLeas/{refId}/xCalendars";
            }
            else if (p == ServicePath.GetXCalendarsByXSchool)
            {
                path = "xSchools/{refId}/xCalendars";
            }
            else if (p == ServicePath.GetXCourses)
            {
                path = "xCourses";
            }
            else if (p == ServicePath.GetXCoursesByXLea)
            {
                path = "xLeas/{refId}/xCourses";
            }
            else if (p == ServicePath.GetXCoursesByXSchool)
            {
                path = "xSchools/{refId}/xCourses";
            }
            else if (p == ServicePath.GetXCoursesByXRoster)
            {
                path = "xRosters/{refId}/xCourses";
            }
            else if (p == ServicePath.GetXRosters)
            {
                path = "xRosters";
            }
            else if (p == ServicePath.GetXRostersByXLea)
            {
                path = "xLeas/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXSchool)
            {
                path = "xSchools/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXCourse)
            {
                path = "xCourses/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXStaff)
            {
                path = "xStaffs/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXStudent)
            {
                path = "xStudents/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXStaffs)
            {
                path = "xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXLea)
            {
                path = "xLeas/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXSchool)
            {
                path = "xSchools/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXCourse)
            {
                path = "xCourses/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXRoster)
            {
                path = "xRosters/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXStudent)
            {
                path = "xStudents/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStudents)
            {
                path = "xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXLea)
            {
                path = "xLeas/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXSchool)
            {
                path = "xSchools/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXRoster)
            {
                path = "xRosters/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXStaff)
            {
                path = "xStaffs/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXContact)
            {
                path = "xContacts/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXContacts)
            {
                path = "xContacts";
            }
            else if (p == ServicePath.GetXContactsByXLea)
            {
                path = "xLeas/{refId}/xContacts";
            }
            else if (p == ServicePath.GetXContactsByXSchool)
            {
                path = "xSchools/{refId}/xContacts";
            }
            else if (p == ServicePath.GetXContactsByXStudent)
            {
                path = "xStudents/{refId}/xContacts";
            }

            RestRequest request = new RestRequest(path, Method.GET);
            request.AddHeader("Accept", "application/json");

            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddHeader("navigationPage", "1");
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());
            
            var response = restClient.Execute(request);

            try
            {
                navigationLastPage = Int32.Parse(response.Headers.ToList()
                .Find(x => x.Name.Equals("navigationLastPage", StringComparison.CurrentCultureIgnoreCase))
                .Value.ToString());
            }
            catch(NullReferenceException)
            {
                navigationLastPage = 0;
            }

            return navigationLastPage;
        }
        /// <summary>
        /// Max page value for specified service path object
        /// </summary>
        /// <param name="navigationPageSize"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public int GetLastPage(int navigationPageSize, ServicePath p)
        {
            string path = "";
            int navigationLastPage = 0;

            if (p == ServicePath.GetXLeas)
            {
                path = "xLeas";
            }
            else if (p == ServicePath.GetXLeasByXSchool)
            {
                path = "xSchools/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXRoster)
            {
                path = "xRosters/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXStaff)
            {
                path = "xStaffs/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXStudent)
            {
                path = "xStudents/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXLeasByXContact)
            {
                path = "xContacts/{refId}/xLeas";
            }
            else if (p == ServicePath.GetXSchools)
            {
                path = "xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXLea)
            {
                path = "xLeas/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXCalendar)
            {
                path = "xCalendars/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXCourse)
            {
                path = "xCourses/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXRoster)
            {
                path = "xRosters/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXStaff)
            {
                path = "xStaffs/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXStudent)
            {
                path = "xStudents/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXSchoolsByXContact)
            {
                path = "xContacts/{refId}/xSchools";
            }
            else if (p == ServicePath.GetXCalendars)
            {
                path = "xCalendars";
            }
            else if (p == ServicePath.GetXCalendarsByXLea)
            {
                path = "xLeas/{refId}/xCalendars";
            }
            else if (p == ServicePath.GetXCalendarsByXSchool)
            {
                path = "xSchools/{refId}/xCalendars";
            }
            else if (p == ServicePath.GetXCourses)
            {
                path = "xCourses";
            }
            else if (p == ServicePath.GetXCoursesByXLea)
            {
                path = "xLeas/{refId}/xCourses";
            }
            else if (p == ServicePath.GetXCoursesByXSchool)
            {
                path = "xSchools/{refId}/xCourses";
            }
            else if (p == ServicePath.GetXCoursesByXRoster)
            {
                path = "xRosters/{refId}/xCourses";
            }
            else if (p == ServicePath.GetXRosters)
            {
                path = "xRosters";
            }
            else if (p == ServicePath.GetXRostersByXLea)
            {
                path = "xLeas/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXSchool)
            {
                path = "xSchools/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXCourse)
            {
                path = "xCourses/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXStaff)
            {
                path = "xStaffs/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXRostersByXStudent)
            {
                path = "xStudents/{refId}/xRosters";
            }
            else if (p == ServicePath.GetXStaffs)
            {
                path = "xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXLea)
            {
                path = "xLeas/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXSchool)
            {
                path = "xSchools/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXCourse)
            {
                path = "xCourses/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXRoster)
            {
                path = "xRosters/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStaffsByXStudent)
            {
                path = "xStudents/{refId}/xStaffs";
            }
            else if (p == ServicePath.GetXStudents)
            {
                path = "xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXLea)
            {
                path = "xLeas/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXSchool)
            {
                path = "xSchools/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXRoster)
            {
                path = "xRosters/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXStaff)
            {
                path = "xStaffs/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXStudentsByXContact)
            {
                path = "xContacts/{refId}/xStudents";
            }
            else if (p == ServicePath.GetXContacts)
            {
                path = "xContacts";
            }
            else if (p == ServicePath.GetXContactsByXLea)
            {
                path = "xLeas/{refId}/xContacts";
            }
            else if (p == ServicePath.GetXContactsByXSchool)
            {
                path = "xSchools/{refId}/xContacts";
            }
            else if (p == ServicePath.GetXContactsByXStudent)
            {
                path = "xStudents/{refId}/xContacts";
            }
            
            RestRequest request = new RestRequest(path, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("navigationPage", "1");
            request.AddHeader("navigationPageSize", navigationPageSize.ToString());
            
            var response = restClient.Execute(request);

            try
            {
                navigationLastPage = Int32.Parse(response.Headers.ToList()
                .Find(x => x.Name.Equals("navigationLastPage", StringComparison.CurrentCultureIgnoreCase))
                .Value.ToString());
            }
            catch(NullReferenceException)
            {
                navigationLastPage = 0;
            }

            return navigationLastPage;
        }

        #endregion
        #region App Provisioning Info
        /// <summary>
        /// Create staff usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> CreateXStaffUsers(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("createUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Delete generated staff passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> DeleteXStaffUsers(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("deleteUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Return generated staff usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStaffType> GetXStaffUsers(string refId)
        {
            ResponseMulti<XStaffType> output = new ResponseMulti<XStaffType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStaffs", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("getUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStaffCollectionType>(request);

            try
            {
                output.Data = response.Data.xStaffs.xStaff;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Create student usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> CreateXStudentUsers(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("createUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Delete generated student passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> DeleteXStudentUsers(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("deleteUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Return generated student usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        public ResponseMulti<XStudentType> GetXStudentUsers(string refId)
        {
            ResponseMulti<XStudentType> output = new ResponseMulti<XStudentType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xStudents", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("getUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XStudentCollectionType>(request);

            try
            {
                output.Data = response.Data.xStudents.xStudent;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Create contact usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        private ResponseMulti<XContactType> CreateXContactUsers(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("createUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);
            Console.WriteLine(response.ResponseUri);
            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        /// <summary>
        /// Delete generated contact passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>

        private ResponseMulti<XContactType> DeleteXContactUsers(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("deleteUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);
            Console.WriteLine(response.ResponseUri);
            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }

        /// <summary>
        /// Return generated contact usernames and passwords by school
        /// </summary>
        /// <param name="refId"></param>
        /// <returns></returns>
        private ResponseMulti<XContactType> GetXContactUsers(string refId)
        {
            ResponseMulti<XContactType> output = new ResponseMulti<XContactType>();

            RestRequest request = new RestRequest("xSchools/{refId}/xContacts", Method.GET);
            request.AddParameter("refId", refId, ParameterType.UrlSegment);
            request.AddQueryParameter("getUsers", "true");
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute<XContactCollectionType>(request);
            Console.WriteLine(response.ResponseUri);
            try
            {
                output.Data = response.Data.xContacts.xContact;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }
            catch (Exception)
            {
                output.Data = null;
                output.StatusCode = (int)response.StatusCode;
                output.Message = response.StatusDescription;
                output.Header = Util.BuildHeader(response);
            }

            return output;
        }
        #endregion
    }
}
