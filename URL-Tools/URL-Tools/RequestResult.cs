using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace URL_Tools
{
    public class RequestResult
    {
        internal string requestURL { get; set; }
        internal HttpStatusCode statusCode { get; set; }
        internal string endURL { get; set; }

        public RequestResult(string requestURL, HttpStatusCode code, string url) {
            this.requestURL = requestURL;
            this.statusCode = code;
            this.endURL = url;
        }
    }
}
