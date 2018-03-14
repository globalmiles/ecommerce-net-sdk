using System;
using System.Collections.Generic;

namespace GlobalMilesECommerceAPI.Standard.Http.Response
{
    public class HttpStringResponse : HttpResponse
    {
        /// <summary>
        /// Raw string body of the http response
        /// </summary>
        public string Body { get; set; }
    }
}
