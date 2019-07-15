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
    public enum ReturnStatusEnum
    {
        STARTED, //Started
        CANCELLED, //Cancelled
        COMPLETED, //Completed
    }

    /// <summary>
    /// Helper for the enum type ReturnStatusEnum
    /// </summary>
    public static class ReturnStatusEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "started", "cancelled", "completed" };

        /// <summary>
        /// Converts a ReturnStatusEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ReturnStatusEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ReturnStatusEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ReturnStatusEnum.STARTED:
                case ReturnStatusEnum.CANCELLED:
                case ReturnStatusEnum.COMPLETED:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ReturnStatusEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ReturnStatusEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ReturnStatusEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into ReturnStatusEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ReturnStatusEnum value</returns>
        public static ReturnStatusEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type ReturnStatusEnum", value));

            return (ReturnStatusEnum) index;
        }
    }
} 