/*
 * GlobalMilesEcommerceAPI.Standard
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
using GlobalMilesEcommerceAPI.Standard;
using GlobalMilesEcommerceAPI.Standard.Utilities;


namespace GlobalMilesEcommerceAPI.Standard.Models
{
    public class OAuthRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string clientId;
        private string clientSecret;
        private string grantType = "client_credentials";

        /// <summary>
        /// ID of the client which is provided by Global Miles.
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId 
        { 
            get 
            {
                return this.clientId; 
            } 
            set 
            {
                this.clientId = value;
                onPropertyChanged("ClientId");
            }
        }

        /// <summary>
        /// Secret of the client which is provided by Global Miles.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret 
        { 
            get 
            {
                return this.clientSecret; 
            } 
            set 
            {
                this.clientSecret = value;
                onPropertyChanged("ClientSecret");
            }
        }

        /// <summary>
        /// Type of the OAuth flows. We support only one type of token: client_credentials
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType 
        { 
            get 
            {
                return this.grantType; 
            } 
            set 
            {
                this.grantType = value;
                onPropertyChanged("GrantType");
            }
        }
    }
} 