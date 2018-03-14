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
    public class PaymentItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.PaymentTypeEnum type;
        private double amount;
        private string paymentProvisionToken;

        /// <summary>
        /// A type of payment.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.PaymentTypeEnum Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Amount of current payment.
        /// </summary>
        [JsonProperty("amount")]
        public double Amount 
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
    }
} 