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
    public enum OAuthProviderErrorEnum
    {
        INVALID_REQUEST, //The request is missing a required parameter, includes an unsupported parameter value (other than grant type), repeats a parameter, includes multiple credentials, utilizes more than one mechanism for authenticating the client, or is otherwise malformed.
        INVALID_CLIENT, //Client authentication failed (e.g., unknown client, no client authentication included, or unsupported authentication method).
        INVALID_GRANT, //The provided authorization grant (e.g., authorization code, resource owner credentials) or refresh token is invalid, expired, revoked, does not match the redirection URI used in the authorization request, or was issued to another client.
        UNAUTHORIZED_CLIENT, //The authenticated client is not authorized to use this authorization grant type.
        UNSUPPORTED_GRANT_TYPE, //The authorization grant type is not supported by the authorization server.
        INVALID_SCOPE, //The requested scope is invalid, unknown, malformed, or exceeds the scope granted by the resource owner.
    }

    /// <summary>
    /// Helper for the enum type OAuthProviderErrorEnum
    /// </summary>
    public static class OAuthProviderErrorEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "invalid_request", "invalid_client", "invalid_grant", "unauthorized_client", "unsupported_grant_type", "invalid_scope" };

        /// <summary>
        /// Converts a OAuthProviderErrorEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The OAuthProviderErrorEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(OAuthProviderErrorEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case OAuthProviderErrorEnum.INVALID_REQUEST:
                case OAuthProviderErrorEnum.INVALID_CLIENT:
                case OAuthProviderErrorEnum.INVALID_GRANT:
                case OAuthProviderErrorEnum.UNAUTHORIZED_CLIENT:
                case OAuthProviderErrorEnum.UNSUPPORTED_GRANT_TYPE:
                case OAuthProviderErrorEnum.INVALID_SCOPE:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of OAuthProviderErrorEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of OAuthProviderErrorEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<OAuthProviderErrorEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into OAuthProviderErrorEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed OAuthProviderErrorEnum value</returns>
        public static OAuthProviderErrorEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type OAuthProviderErrorEnum", value));

            return (OAuthProviderErrorEnum) index;
        }
    }
} 