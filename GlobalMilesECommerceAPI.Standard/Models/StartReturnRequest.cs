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
    public class StartReturnRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string storeCode;
        private string transactionId;
        private Models.Amount amount;

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
        /// An amount of the return.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }
    }
} 