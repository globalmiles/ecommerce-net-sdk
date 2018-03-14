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
    public class CartRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string userToken;
        private string storeCode;
        private Models.Cart cart;

        /// <summary>
        /// A token that is representing a Global Miles user for the current session.
        /// </summary>
        [JsonProperty("user_token")]
        public string UserToken 
        { 
            get 
            {
                return this.userToken; 
            } 
            set 
            {
                this.userToken = value;
                onPropertyChanged("UserToken");
            }
        }

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
        /// A complex object for cart.
        /// </summary>
        [JsonProperty("cart")]
        public Models.Cart Cart 
        { 
            get 
            {
                return this.cart; 
            } 
            set 
            {
                this.cart = value;
                onPropertyChanged("Cart");
            }
        }
    }
} 