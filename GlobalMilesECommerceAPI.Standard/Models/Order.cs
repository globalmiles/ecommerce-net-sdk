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
    public class Order : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double subtotal;
        private double tax;
        private double total;
        private string currency;
        private List<Models.OrderItem> items;
        private List<Models.DiscountItem> discounts;
        private List<Models.PaymentItem> payments;

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

        /// <summary>
        /// An array of order items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.OrderItem> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }

        /// <summary>
        /// An array of discount items.
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.DiscountItem> Discounts 
        { 
            get 
            {
                return this.discounts; 
            } 
            set 
            {
                this.discounts = value;
                onPropertyChanged("Discounts");
            }
        }

        /// <summary>
        /// An array of payment items.
        /// </summary>
        [JsonProperty("payments")]
        public List<Models.PaymentItem> Payments 
        { 
            get 
            {
                return this.payments; 
            } 
            set 
            {
                this.payments = value;
                onPropertyChanged("Payments");
            }
        }
    }
} 