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
    public class StartPointPaymentResult : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string paymentProvisionToken;

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