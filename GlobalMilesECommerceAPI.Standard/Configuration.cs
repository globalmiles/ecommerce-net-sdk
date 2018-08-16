using System.Collections.Generic;
using System.Text;
using GlobalMilesECommerceAPI.Standard.Utilities;
using GlobalMilesECommerceAPI.Standard.Models;
namespace GlobalMilesECommerceAPI.Standard
{
    public partial class Configuration
    {
        public delegate void OAuthTokenUpdateDelegate(OAuthToken token);

        public static OAuthToken OAuthToken;

        public static OAuthTokenUpdateDelegate OAuthTokenUpdateCallback;

        public enum Environments
        {
            //Cloud Environment
            CLOUD,
        }
        public enum Servers
        {
            ENUM_DEFAULT,
        }

        //The current environment being used
        public static Environments Environment = Environments.CLOUD;

        //OAuth 2 Client ID
        //TODO: Replace the OAuthClientId with an appropriate value
        public static string OAuthClientId = "TODO: Replace";

        //OAuth 2 Client Secret
        //TODO: Replace the OAuthClientSecret with an appropriate value
        public static string OAuthClientSecret = "TODO: Replace";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.CLOUD,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://api.sandbox.globalmiles.com" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.ENUM_DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}