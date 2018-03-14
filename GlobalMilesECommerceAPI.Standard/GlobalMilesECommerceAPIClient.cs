/*
 * GlobalMilesECommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using GlobalMilesECommerceAPI.Standard.Controllers;
using GlobalMilesECommerceAPI.Standard.Http.Client;
using GlobalMilesECommerceAPI.Standard.Utilities;

namespace GlobalMilesECommerceAPI.Standard
{
    public partial class GlobalMilesECommerceAPIClient
    {

        /// <summary>
        /// Singleton access to PayWithMilesPoints controller
        /// </summary>
        public PayWithMilesPointsController PayWithMilesPoints
        {
            get
            {
                return PayWithMilesPointsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Transaction controller
        /// </summary>
        public TransactionController Transaction
        {
            get
            {
                return TransactionController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Authentication controller
        /// </summary>
        public AuthenticationController Authentication
        {
            get
            {
                return AuthenticationController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Return controller
        /// </summary>
        public ReturnController Return
        {
            get
            {
                return ReturnController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to OAuthAuthorization controller
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorization
        {
            get
            {
                return OAuthAuthorizationController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Authorization instance

        public AuthManager Auth
        {
            get { return AuthManager.Instance; }
        }

        #endregion
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public GlobalMilesECommerceAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public GlobalMilesECommerceAPIClient(string oAuthClientId, string oAuthClientSecret)
        {
            Configuration.OAuthClientId = oAuthClientId;
            Configuration.OAuthClientSecret = oAuthClientSecret;
        }
        #endregion
    }
}