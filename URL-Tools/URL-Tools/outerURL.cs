using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;

namespace URL_Tools
{
    class outerURL
    {
        [System.ComponentModel.DisplayName("entryPoint")]
        internal Url entryPoint { get; set; }
        [System.ComponentModel.DisplayName("endStatusCode")]
        internal HttpStatusCode endStatusCode { get; set; }
        [System.ComponentModel.DisplayName("endUrl")]
        internal Url endUrl { get; set; }
        //[System.ComponentModel.DisplayName("Key")]
        //internal List<OuterResult> redirects { get; set; }

        public outerURL(Url entry, HttpStatusCode endCode, Url endUrl)
        {
            this.entryPoint = entry;
            this.endStatusCode = endCode;
            this.endUrl = endUrl;
        }
    }
}
