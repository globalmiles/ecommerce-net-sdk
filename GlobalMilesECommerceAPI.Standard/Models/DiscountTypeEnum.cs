/*
 * GlobalMilesEcommerceAPI.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GlobalMilesEcommerceAPI.Standard;
using GlobalMilesEcommerceAPI.Standard.Utilities;

namespace GlobalMilesEcommerceAPI.Standard.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum DiscountTypeEnum
    {
        LOYALTY_DISCOUNT, //This type indicates a discount by Global Miles.
        OTHER, //Other type of discounts.
    }

    /// <summary>
    /// Helper for the enum type DiscountTypeEnum
    /// </summary>
    public static class DiscountTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "loyalty_discount", "other" };

        /// <summary>
        /// Converts a DiscountTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The DiscountTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(DiscountTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case DiscountTypeEnum.LOYALTY_DISCOUNT:
                case DiscountTypeEnum.OTHER:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of DiscountTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of DiscountTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<DiscountTypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into DiscountTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed DiscountTypeEnum value</returns>
        public static DiscountTypeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type DiscountTypeEnum", value));

            return (DiscountTypeEnum) index;
        }
    }
} 