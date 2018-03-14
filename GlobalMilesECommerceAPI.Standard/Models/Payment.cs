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
    public class Payment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string paymentProvisionToken;
        private string createdAt;
        private string updatedAt;
        private Models.PaymentStatusEnum status;
        private Models.Amount amount;

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
        /// Create date time of payment. The format is ISO 8601 date and time.
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

        /// <summary>
        /// Last update date time of payment. The format is ISO 8601 date and time.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt 
        { 
            get 
            {
                return this.updatedAt; 
            } 
            set 
            {
                this.updatedAt = value;
                onPropertyChanged("UpdatedAt");
            }
        }

        /// <summary>
        /// The status of payment.
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.PaymentStatusEnum Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// An amount of payment.
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