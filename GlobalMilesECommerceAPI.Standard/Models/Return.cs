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
    public class Return : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string returnProvisionToken;
        private string transactionId;
        private string createdAt;
        private string updatedAt;
        private Models.ReturnStatusEnum status;
        private Models.Amount amount;
        private Models.Amount residual;

        /// <summary>
        /// The token value of a return.
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
        /// Create date time of return. The format is ISO 8601 date and time.
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
        /// Last update date time of return. The format is ISO 8601 date and time.
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
        /// The status of return.
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.ReturnStatusEnum Status 
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
        /// An amount of return.
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

        /// <summary>
        /// A residual amount of return.
        /// </summary>
        [JsonProperty("residual")]
        public Models.Amount Residual 
        { 
            get 
            {
                return this.residual; 
            } 
            set 
            {
                this.residual = value;
                onPropertyChanged("Residual");
            }
        }
    }
} 