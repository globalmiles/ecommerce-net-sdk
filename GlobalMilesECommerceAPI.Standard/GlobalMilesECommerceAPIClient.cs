/*
 * GlobalMilesEcommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using GlobalMilesEcommerceAPI.Standard.Controllers;
using GlobalMilesEcommerceAPI.Standard.Http.Client;
using GlobalMilesEcommerceAPI.Standard.Utilities;

namespace GlobalMilesEcommerceAPI.Standard
{
    public partial class GlobalMilesEcommerceAPIClient
    {

        /// <summary>
        /// Singleton access to PayWithMiles controller
        /// </summary>
        public PayWithMilesController PayWithMiles
        {
            get
            {
                return PayWithMilesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to EarnMiles controller
        /// </summary>
        public EarnMilesController EarnMiles
        {
            get
            {
                return EarnMilesController.Instance;
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
        public GlobalMilesEcommerceAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public GlobalMilesEcommerceAPIClient(string oAuthClientId, string oAuthClientSecret)
        {
            Configuration.OAuthClientId = oAuthClientId;
            Configuration.OAuthClientSecret = oAuthClientSecret;
        }
        #endregion
    }
}