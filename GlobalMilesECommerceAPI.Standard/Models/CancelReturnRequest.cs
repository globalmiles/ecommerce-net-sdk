/*
 * GlobalMilesECommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io ).
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
    public class CancelReturnRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string storeCode;
        private string returnProvisionToken;

        /// <summary>
        /// An identifier for online store.
        /// </summary>
        [JsonProperty("store_code")]
        public string StoreCode 
        { 
            get 
            {
                return this.storeCode; 
            } 
            set 
            {
                this.storeCode = value;
                onPropertyChanged("StoreCode");
            }
        }

        /// <summary>
        /// A token represents a return object for provisioning.
        /// </summary>
        [JsonProperty("return_provision_token")]
        public string ReturnProvisionToken 
        { 
            get 
            {
                return this.returnProvisionToken; 
            } 
            set 
            {
                this.returnProvisionToken = value;
                onPropertyChanged("ReturnProvisionToken");
            }
        }
    }
} 