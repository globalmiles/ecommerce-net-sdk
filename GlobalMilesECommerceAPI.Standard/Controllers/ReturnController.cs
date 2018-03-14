/*
 * GlobalMilesECommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using GlobalMilesECommerceAPI.Standard;
using GlobalMilesECommerceAPI.Standard.Utilities;
using GlobalMilesECommerceAPI.Standard.Http.Request;
using GlobalMilesECommerceAPI.Standard.Http.Response;
using GlobalMilesECommerceAPI.Standard.Http.Client;
using GlobalMilesECommerceAPI.Standard.Exceptions;

namespace GlobalMilesECommerceAPI.Standard.Controllers
{
    public partial class ReturnController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ReturnController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ReturnController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ReturnController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint allows to start a return for a specific order.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartReturnResponse response from the API call</return>
        public Models.StartReturnResponse CreateStartReturn(
                string accept,
                string contentType,
                string authorization,
                Models.StartReturnRequest body)
        {
            Task<Models.StartReturnResponse> t = CreateStartReturnAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to start a return for a specific order.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartReturnResponse response from the API call</return>
        public async Task<Models.StartReturnResponse> CreateStartReturnAsync(
                string accept,
                string contentType,
                string authorization,
                Models.StartReturnRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/returns");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept", accept },
                { "Content-Type", contentType },
                { "Authorization", authorization }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthToken.AccessToken));

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.StartReturnResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint allows to complete a return.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public Models.Response UpdateCompleteReturn(
                string accept,
                string contentType,
                string authorization,
                Models.CompleteReturnRequest body)
        {
            Task<Models.Response> t = UpdateCompleteReturnAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to complete a return.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public async Task<Models.Response> UpdateCompleteReturnAsync(
                string accept,
                string contentType,
                string authorization,
                Models.CompleteReturnRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/returns");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept", accept },
                { "Content-Type", contentType },
                { "Authorization", authorization }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthToken.AccessToken));

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.Response>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint allows to cancel a return.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public Models.Response DeleteCancelReturn(
                string accept,
                string contentType,
                string authorization,
                Models.CancelReturnRequest body)
        {
            Task<Models.Response> t = DeleteCancelReturnAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to cancel a return.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public async Task<Models.Response> DeleteCancelReturnAsync(
                string accept,
                string contentType,
                string authorization,
                Models.CancelReturnRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/returns");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept", accept },
                { "Content-Type", contentType },
                { "Authorization", authorization }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthToken.AccessToken));

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.DeleteBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.Response>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 