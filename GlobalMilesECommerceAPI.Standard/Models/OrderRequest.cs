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
    public class OrderRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string storeCode;
        private string userToken;
        private string transactionId;
        private Models.Order order;
        private int? shiftAllowance = 0;

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
        /// The ID of the transaction that represents the order.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId 
        { 
            get 
            {
                return this.transactionId; 
            } 
            set 
            {
                this.transactionId = value;
                onPropertyChanged("TransactionId");
            }
        }

        /// <summary>
        /// A complex object for order.
        /// </summary>
        [JsonProperty("order")]
        public Models.Order Order 
        { 
            get 
            {
                return this.order; 
            } 
            set 
            {
                this.order = value;
                onPropertyChanged("Order");
            }
        }

        /// <summary>
        /// It specifies how many days later the miles / points should be given to the user.
        /// </summary>
        [JsonProperty("shift_allowance")]
        public int? ShiftAllowance 
        { 
            get 
            {
                return this.shiftAllowance; 
            } 
            set 
            {
                this.shiftAllowance = value;
                onPropertyChanged("ShiftAllowance");
            }
        }
    }
} 