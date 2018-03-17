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
    public class ListPointPaymentResponse : Response 
    {
        // These fields hold the values for the public properties.
        private List<Models.Payment> result;

        /// <summary>
        /// Result object of the response.
        /// </summary>
        [JsonProperty("result")]
        public List<Models.Payment> Result 
        { 
            get 
            {
                return this.result; 
            } 
            set 
            {
                this.result = value;
                onPropertyChanged("Result");
            }
        }
    }
} 