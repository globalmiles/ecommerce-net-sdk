/*
 * GlobalMilesECommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GlobalMilesECommerceAPI.Standard.Http.Client;

using GlobalMilesECommerceAPI.Standard.Models;
using GlobalMilesECommerceAPI.Standard;
using GlobalMilesECommerceAPI.Standard.Utilities;


namespace GlobalMilesECommerceAPI.Standard.Exceptions
{
    public class OAuthProviderException : APIException 
    {
        // These fields hold the values for the public properties.
        private Models.OAuthProviderErrorEnum error;
        private string errorDescription;
        private string errorUri;

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("error", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.OAuthProviderErrorEnum Error 
        { 
            get 
            {
                return this.error; 
            } 
            private set 
            {
                this.error = value;
            }
        }

        /// <summary>
        /// Human-readable text providing additional information on error.
        /// Used to assist the client developer in understanding the error that occurred.
        /// </summary>
        [JsonProperty("error_description")]
        public string ErrorDescription 
        { 
            get 
            {
                return this.errorDescription; 
            } 
            private set 
            {
                this.errorDescription = value;
            }
        }

        /// <summary>
        /// A URI identifying a human-readable web page with information about the error, used to provide the client developer with additional information about the error
        /// </summary>
        [JsonProperty("error_uri")]
        public string ErrorUri 
        { 
            get 
            {
                return this.errorUri; 
            } 
            private set 
            {
                this.errorUri = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public OAuthProviderException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 