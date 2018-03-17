/*
 * GlobalMilesEcommerceAPI.Standard
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
using GlobalMilesEcommerceAPI.Standard;
using GlobalMilesEcommerceAPI.Standard.Utilities;
using GlobalMilesEcommerceAPI.Standard.Http.Request;
using GlobalMilesEcommerceAPI.Standard.Http.Response;
using GlobalMilesEcommerceAPI.Standard.Http.Client;
using GlobalMilesEcommerceAPI.Standard.Exceptions;

namespace GlobalMilesEcommerceAPI.Standard.Controllers
{
    public partial class PayWithMilesPointsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PayWithMilesPointsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PayWithMilesPointsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PayWithMilesPointsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint allows to get list of payments. In order to get detailed payment history and reconciliation you can use this API.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="storeCode">Required parameter: An identifier for online store.</param>
        /// <param name="filterByCreatedAt">Required parameter: Filter for created_at field. It is accepted a valid date range value. The format is YYYY-MM-DD...YYYY-MM-DD.</param>
        /// <param name="filterByStatus">Optional parameter: Filter for status field. It is accepted a valid status value of payment.</param>
        /// <param name="sortBy">Optional parameter: Sort for some selected fields. In order to sort descending "-" value will be used before the field. Valid field values are "created_at",  "updated_at", "status".</param>
        /// <return>Returns the Models.ListPointPaymentResponse response from the API call</return>
        public Models.ListPointPaymentResponse ListPointPayments(
                string accept,
                string contentType,
                string authorization,
                string storeCode,
                string filterByCreatedAt,
                string filterByStatus = null,
                string sortBy = null)
        {
            Task<Models.ListPointPaymentResponse> t = ListPointPaymentsAsync(accept, contentType, authorization, storeCode, filterByCreatedAt, filterByStatus, sortBy);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to get list of payments. In order to get detailed payment history and reconciliation you can use this API.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="storeCode">Required parameter: An identifier for online store.</param>
        /// <param name="filterByCreatedAt">Required parameter: Filter for created_at field. It is accepted a valid date range value. The format is YYYY-MM-DD...YYYY-MM-DD.</param>
        /// <param name="filterByStatus">Optional parameter: Filter for status field. It is accepted a valid status value of payment.</param>
        /// <param name="sortBy">Optional parameter: Sort for some selected fields. In order to sort descending "-" value will be used before the field. Valid field values are "created_at",  "updated_at", "status".</param>
        /// <return>Returns the Models.ListPointPaymentResponse response from the API call</return>
        public async Task<Models.ListPointPaymentResponse> ListPointPaymentsAsync(
                string accept,
                string contentType,
                string authorization,
                string storeCode,
                string filterByCreatedAt,
                string filterByStatus = null,
                string sortBy = null)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/payments");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "StoreCode", storeCode },
                { "FilterByCreatedAt", filterByCreatedAt },
                { "FilterByStatus", filterByStatus },
                { "SortBy", sortBy }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Accept", accept },
                { "Content-Type", contentType },
                { "Authorization", authorization }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthToken.AccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ListPointPaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint allows to refund a payment.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public Models.Response CreateRefundPointPayment(
                string accept,
                string contentType,
                string authorization,
                Models.RefundPointPaymentRequest body)
        {
            Task<Models.Response> t = CreateRefundPointPaymentAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to refund a payment.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public async Task<Models.Response> CreateRefundPointPaymentAsync(
                string accept,
                string contentType,
                string authorization,
                Models.RefundPointPaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/payments/actions/refund");


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
                return APIHelper.JsonDeserialize<Models.Response>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint allows to cancel a payment.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public Models.Response DeleteCancelPointPayment(
                string accept,
                string contentType,
                string authorization,
                Models.CancelPointPaymentRequest body)
        {
            Task<Models.Response> t = DeleteCancelPointPaymentAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to cancel a payment.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public async Task<Models.Response> DeleteCancelPointPaymentAsync(
                string accept,
                string contentType,
                string authorization,
                Models.CancelPointPaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/payments");


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

        /// <summary>
        /// This endpoint allows to complete a payment.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public Models.Response UpdateCompletePointPayment(
                string accept,
                string contentType,
                string authorization,
                Models.CompletePointPaymentRequest body)
        {
            Task<Models.Response> t = UpdateCompletePointPaymentAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to complete a payment.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public async Task<Models.Response> UpdateCompletePointPaymentAsync(
                string accept,
                string contentType,
                string authorization,
                Models.CompletePointPaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/payments");


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
        /// After successful authentication and retrieving needed token,this endpoint allows to start a payment transaction. To be able to complete whole sale process successfully  also check "Complete Point Payment endpoint" please.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartPointPaymentResponse response from the API call</return>
        public Models.StartPointPaymentResponse CreateStartPointPayment(
                string accept,
                string contentType,
                string authorization,
                Models.StartPointPaymentRequest body)
        {
            Task<Models.StartPointPaymentResponse> t = CreateStartPointPaymentAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// After successful authentication and retrieving needed token,this endpoint allows to start a payment transaction. To be able to complete whole sale process successfully  also check "Complete Point Payment endpoint" please.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartPointPaymentResponse response from the API call</return>
        public async Task<Models.StartPointPaymentResponse> CreateStartPointPaymentAsync(
                string accept,
                string contentType,
                string authorization,
                Models.StartPointPaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/payments");


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
                return APIHelper.JsonDeserialize<Models.StartPointPaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 