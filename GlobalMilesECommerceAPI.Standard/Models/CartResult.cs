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
    public class CartResult : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Amount availableAmount;
        private Models.CartDiscount cartDiscount;

        /// <summary>
        /// The available amount of money for payment.
        /// </summary>
        [JsonProperty("available_amount")]
        public Models.Amount AvailableAmount 
        { 
            get 
            {
                return this.availableAmount; 
            } 
            set 
            {
                this.availableAmount = value;
                onPropertyChanged("AvailableAmount");
            }
        }

        /// <summary>
        /// A discount object for cart.
        /// </summary>
        [JsonProperty("cart_discount")]
        public Models.CartDiscount CartDiscount 
        { 
            get 
            {
                return this.cartDiscount; 
            } 
            set 
            {
                this.cartDiscount = value;
                onPropertyChanged("CartDiscount");
            }
        }
    }
} 