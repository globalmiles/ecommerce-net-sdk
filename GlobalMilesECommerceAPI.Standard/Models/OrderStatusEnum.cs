/*
 * GlobalMilesECommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
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
    public enum OrderStatusEnum
    {
        PENDING, //Pending
        REFUNDED, //Refunded
        PROCESSED, //Processed
        PARTIALLY_REFUNDED, //Partially Refunded
    }

    /// <summary>
    /// Helper for the enum type OrderStatusEnum
    /// </summary>
    public static class OrderStatusEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "pending", "refunded", "processed", "partially_refunded" };

        /// <summary>
        /// Converts a OrderStatusEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The OrderStatusEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(OrderStatusEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case OrderStatusEnum.PENDING:
                case OrderStatusEnum.REFUNDED:
                case OrderStatusEnum.PROCESSED:
                case OrderStatusEnum.PARTIALLY_REFUNDED:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of OrderStatusEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of OrderStatusEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<OrderStatusEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into OrderStatusEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed OrderStatusEnum value</returns>
        public static OrderStatusEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type OrderStatusEnum", value));

            return (OrderStatusEnum) index;
        }
    }
} 