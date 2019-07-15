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
    public class DiscountItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.DiscountTypeEnum type;
        private double amount;
        private string discountProvisionToken;

        /// <summary>
        /// Type of the discount.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.DiscountTypeEnum Type 
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
        /// Amount of the current discount.
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
    }
} 