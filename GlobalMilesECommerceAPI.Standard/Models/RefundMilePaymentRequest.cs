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
    public class RefundMilePaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string storeCode;
        private string paymentProvisionToken;
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
        /// A token represents a payment object for provisioning.
        /// </summary>
        [JsonProperty("payment_provision_token")]
        public string PaymentProvisionToken 
        { 
            get 
            {
                return this.paymentProvisionToken; 
            } 
            set 
            {
                this.paymentProvisionToken = value;
                onPropertyChanged("PaymentProvisionToken");
            }
        }

        /// <summary>
        /// An amount of the payment.
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