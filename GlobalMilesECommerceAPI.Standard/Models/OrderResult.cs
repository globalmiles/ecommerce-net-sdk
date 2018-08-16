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
    public class OrderResult : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string transactionToken;

        /// <summary>
        /// A token represents an order object from Global Miles system.
        /// </summary>
        [JsonProperty("transaction_token")]
        public string TransactionToken 
        { 
            get 
            {
                return this.transactionToken; 
            } 
            set 
            {
                this.transactionToken = value;
                onPropertyChanged("TransactionToken");
            }
        }
    }
} 