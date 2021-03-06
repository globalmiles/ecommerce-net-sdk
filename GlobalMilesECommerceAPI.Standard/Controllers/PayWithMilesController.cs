/*
 * GlobalMilesECommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io ).
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
    public partial class PayWithMilesController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PayWithMilesController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PayWithMilesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PayWithMilesController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint allows to get list of payments. In order to get detailed payment history and reconciliation you can use this endpoint.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="filterStoreCode">Required parameter: Filter for an online store.</param>
        /// <param name="filterCreatedAt">Required parameter: Filter for created_at field. It is accepted a valid date range value. The format is YYYY-MM-DD..YYYY-MM-DD.</param>
        /// <param name="filterStatus">Optional parameter: Filter for status field. It is accepted a valid status value of payment.</param>
        /// <param name="sort">Optional parameter: Sort for some selected fields. In order to sort descending "-" value will be used before the field. Valid field values are "created_at",  "updated_at", "status".</param>
        /// <return>Returns the Models.ListMilePaymentResponse response from the API call</return>
        public Models.ListMilePaymentResponse ListMilePayments(
                string filterStoreCode,
                string filterCreatedAt,
                string filterStatus = null,
                string sort = null)
        {
            Task<Models.ListMilePaymentResponse> t = ListMilePaymentsAsync(filterStoreCode, filterCreatedAt, filterStatus, sort);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to get list of payments. In order to get detailed payment history and reconciliation you can use this endpoint.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="filterStoreCode">Required parameter: Filter for an online store.</param>
        /// <param name="filterCreatedAt">Required parameter: Filter for created_at field. It is accepted a valid date range value. The format is YYYY-MM-DD..YYYY-MM-DD.</param>
        /// <param name="filterStatus">Optional parameter: Filter for status field. It is accepted a valid status value of payment.</param>
        /// <param name="sort">Optional parameter: Sort for some selected fields. In order to sort descending "-" value will be used before the field. Valid field values are "created_at",  "updated_at", "status".</param>
        /// <return>Returns the Models.ListMilePaymentResponse response from the API call</return>
        public async Task<Models.ListMilePaymentResponse> ListMilePaymentsAsync(
                string filterStoreCode,
                string filterCreatedAt,
                string filterStatus = null,
                string sort = null)
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
                { "filter[store_code]", filterStoreCode },
                { "filter[created_at]", filterCreatedAt },
                { "filter[status]", filterStatus },
                { "sort", sort }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
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
                return APIHelper.JsonDeserialize<Models.ListMilePaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// After successful authentication and retrieving needed token, this endpoint allows to start a payment transaction. To be able to complete whole payment process successfully also check "Complete Mile Payment endpoint" please.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartMilePaymentResponse response from the API call</return>
        public Models.StartMilePaymentResponse CreateStartMilePayment(Models.StartMilePaymentRequest body)
        {
            Task<Models.StartMilePaymentResponse> t = CreateStartMilePaymentAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// After successful authentication and retrieving needed token, this endpoint allows to start a payment transaction. To be able to complete whole payment process successfully also check "Complete Mile Payment endpoint" please.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartMilePaymentResponse response from the API call</return>
        public async Task<Models.StartMilePaymentResponse> CreateStartMilePaymentAsync(Models.StartMilePaymentRequest body)
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
                { "content-type", "application/json; charset=utf-8" }
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
                return APIHelper.JsonDeserialize<Models.StartMilePaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint allows to complete a payment.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public Models.Response UpdateCompleteMilePayment(Models.CompleteMilePaymentRequest body)
        {
            Task<Models.Response> t = UpdateCompleteMilePaymentAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to complete a payment.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public async Task<Models.Response> UpdateCompleteMilePaymentAsync(Models.CompleteMilePaymentRequest body)
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
                { "content-type", "application/json; charset=utf-8" }
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
        /// This endpoint allows to cancel a payment.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public Models.Response DeleteCancelMilePayment(Models.CancelMilePaymentRequest body)
        {
            Task<Models.Response> t = DeleteCancelMilePaymentAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to cancel a payment.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public async Task<Models.Response> DeleteCancelMilePaymentAsync(Models.CancelMilePaymentRequest body)
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
                { "content-type", "application/json; charset=utf-8" }
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
        /// This endpoint allows to refund a payment.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public Models.Response CreateRefundMilePayment(Models.RefundMilePaymentRequest body)
        {
            Task<Models.Response> t = CreateRefundMilePaymentAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to refund a payment.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.Response response from the API call</return>
        public async Task<Models.Response> CreateRefundMilePaymentAsync(Models.RefundMilePaymentRequest body)
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
                { "content-type", "application/json; charset=utf-8" }
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

    }
} 