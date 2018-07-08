using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace URL_Tools
{
    public class OuterResult
    {
        internal HttpStatusCode statusCode { get; set; }
        internal string endURL { get; set; }

        public OuterResult(HttpStatusCode code, string url) {
            this.statusCode = code;
            this.endURL = url;
        }
    }
}
