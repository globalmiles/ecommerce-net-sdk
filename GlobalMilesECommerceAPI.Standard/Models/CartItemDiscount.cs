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
    public class CartItemDiscount : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private double discount;

        /// <summary>
        /// An identifier to reference this product.
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Amount of the current discount.
        /// </summary>
        [JsonProperty("discount")]
        public double Discount 
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
    }
} 