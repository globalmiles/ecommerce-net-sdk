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
    public class BasicOrderResult : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string transactionToken;
        private string transactionId;
        private string completedAt;
        private string createdAt;
        private string updatedAt;
        private Models.OrderStatusEnum status;
        private double subtotal;
        private double tax;
        private double total;
        private string currency;

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
        /// The date and time when the order was completed in partner side.
        /// </summary>
        [JsonProperty("completed_at")]
        public string CompletedAt 
        { 
            get 
            {
                return this.completedAt; 
            } 
            set 
            {
                this.completedAt = value;
                onPropertyChanged("CompletedAt");
            }
        }

        /// <summary>
        /// Create date time of order. The format is ISO 8601 date and time.
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
        /// Last update date time of order. The format is ISO 8601 date and time.
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
        /// The status of order.
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.OrderStatusEnum Status 
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
        /// Total value of all order items without tax.
        /// </summary>
        [JsonProperty("subtotal")]
        public double Subtotal 
        { 
            get 
            {
                return this.subtotal; 
            } 
            set 
            {
                this.subtotal = value;
                onPropertyChanged("Subtotal");
            }
        }

        /// <summary>
        /// The amount of tax.
        /// </summary>
        [JsonProperty("tax")]
        public double Tax 
        { 
            get 
            {
                return this.tax; 
            } 
            set 
            {
                this.tax = value;
                onPropertyChanged("Tax");
            }
        }

        /// <summary>
        /// Total amount of order.
        /// </summary>
        [JsonProperty("total")]
        public double Total 
        { 
            get 
            {
                return this.total; 
            } 
            set 
            {
                this.total = value;
                onPropertyChanged("Total");
            }
        }

        /// <summary>
        /// ISO-4217 3-letter currency code.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }
    }
} 