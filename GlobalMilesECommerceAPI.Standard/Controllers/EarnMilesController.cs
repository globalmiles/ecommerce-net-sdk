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
    public partial class EarnMilesController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EarnMilesController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EarnMilesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EarnMilesController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint allows to create an order for earn miles. It may also include discounts and payments.
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.OrderResponse response from the API call</return>
        public Models.OrderResponse CreateOrderInfo(Models.OrderRequest body)
        {
            Task<Models.OrderResponse> t = CreateOrderInfoAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to create an order for earn miles. It may also include discounts and payments.
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.OrderResponse response from the API call</return>
        public async Task<Models.OrderResponse> CreateOrderInfoAsync(Models.OrderRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/orders");


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
                return APIHelper.JsonDeserialize<Models.OrderResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint allows to get available amount of money, based on miles of user and their discounts which is based on cart or items.
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CartResponse response from the API call</return>
        public Models.CartResponse CreateCartInfo(Models.CartRequest body)
        {
            Task<Models.CartResponse> t = CreateCartInfoAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows to get available amount of money, based on miles of user and their discounts which is based on cart or items.
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CartResponse response from the API call</return>
        public async Task<Models.CartResponse> CreateCartInfoAsync(Models.CartRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/ecommerce/carts");


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
                return APIHelper.JsonDeserialize<Models.CartResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 