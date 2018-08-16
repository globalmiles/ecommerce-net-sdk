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
using GlobalMilesECommerceAPI.Standard;
using GlobalMilesECommerceAPI.Standard.Utilities;


namespace GlobalMilesECommerceAPI.Standard.Models
{
    public class OAuthResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accessToken;
        private string tokenType;
        private string createdAt;

        /// <summary>
        /// An access token from the authorization server.
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken 
        { 
            get 
            {
                return this.accessToken; 
            } 
            set 
            {
                this.accessToken = value;
                onPropertyChanged("AccessToken");
            }
        }

        /// <summary>
        /// The type of token this is, typically just the string "bearer".
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType 
        { 
            get 
            {
                return this.tokenType; 
            } 
            set 
            {
                this.tokenType = value;
                onPropertyChanged("TokenType");
            }
        }

        /// <summary>
        /// The time in unix time format when the access token was created.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }
    }
} 