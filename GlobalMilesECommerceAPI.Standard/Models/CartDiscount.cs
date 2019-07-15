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
    public class CartDiscount : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string currency;
        private double? discount;
        private string discountProvisionToken;
        private List<Models.CartItemDiscount> items;

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
        /// Amount of the current discount.
        /// </summary>
        [JsonProperty("discount")]
        public double? Discount 
        { 
            get 
            {
                return this.discount; 
            } 
            set 
            {
                this.discount = value;
                onPropertyChanged("Discount");
            }
        }

        /// <summary>
        /// A token represents a discount object for provisioning.
        /// </summary>
        [JsonProperty("discount_provision_token")]
        public string DiscountProvisionToken 
        { 
            get 
            {
                return this.discountProvisionToken; 
            } 
            set 
            {
                this.discountProvisionToken = value;
                onPropertyChanged("DiscountProvisionToken");
            }
        }

        /// <summary>
        /// An array of discounts for cart items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CartItemDiscount> Items 
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
    }
} 