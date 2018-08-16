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
    public enum PaymentTypeEnum
    {
        CREDIT_CARD, //Credit Card
        DEBIT_CARD, //Debit Card
        BANK_TRANSFER, //Bank Transfers / Electronic Funds Transfer (EFT)
        CASH, //Cash
        DIGITAL_WALLET, //Digital Wallet
        MOBILE_PAYMENT, //Mobile Payment
        GIFT_CARD, //Gitf Card
        MILE_PAYMENT, //Pay with miles provided by Global Miles
        OTHER, //Other
    }

    /// <summary>
    /// Helper for the enum type PaymentTypeEnum
    /// </summary>
    public static class PaymentTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "credit_card", "debit_card", "bank_transfer", "cash", "digital_wallet", "mobile_payment", "gift_card", "mile_payment", "other" };

        /// <summary>
        /// Converts a PaymentTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PaymentTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PaymentTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PaymentTypeEnum.CREDIT_CARD:
                case PaymentTypeEnum.DEBIT_CARD:
                case PaymentTypeEnum.BANK_TRANSFER:
                case PaymentTypeEnum.CASH:
                case PaymentTypeEnum.DIGITAL_WALLET:
                case PaymentTypeEnum.MOBILE_PAYMENT:
                case PaymentTypeEnum.GIFT_CARD:
                case PaymentTypeEnum.MILE_PAYMENT:
                case PaymentTypeEnum.OTHER:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PaymentTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PaymentTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PaymentTypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into PaymentTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PaymentTypeEnum value</returns>
        public static PaymentTypeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type PaymentTypeEnum", value));

            return (PaymentTypeEnum) index;
        }
    }
} 