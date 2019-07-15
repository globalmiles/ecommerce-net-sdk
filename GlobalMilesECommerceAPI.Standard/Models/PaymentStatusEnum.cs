/*
 * GlobalMilesECommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GlobalMilesECommerceAPI.Standard;
using GlobalMilesECommerceAPI.Standard.Utilities;

namespace GlobalMilesECommerceAPI.Standard.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PaymentStatusEnum
    {
        STARTED, //Started
        COMPLETED, //Completed
        CANCELLED, //Cancelled
        REFUNDED, //Refunded
        USED, //Used
    }

    /// <summary>
    /// Helper for the enum type PaymentStatusEnum
    /// </summary>
    public static class PaymentStatusEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "started", "completed", "cancelled", "refunded", "used" };

        /// <summary>
        /// Converts a PaymentStatusEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PaymentStatusEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PaymentStatusEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PaymentStatusEnum.STARTED:
                case PaymentStatusEnum.COMPLETED:
                case PaymentStatusEnum.CANCELLED:
                case PaymentStatusEnum.REFUNDED:
                case PaymentStatusEnum.USED:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PaymentStatusEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PaymentStatusEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PaymentStatusEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into PaymentStatusEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PaymentStatusEnum value</returns>
        public static PaymentStatusEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type PaymentStatusEnum", value));

            return (PaymentStatusEnum) index;
        }
    }
} 