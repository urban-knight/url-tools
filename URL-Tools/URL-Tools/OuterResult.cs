using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL_Tools
{
    public class OuterResult
    {
        internal RequestResult Endpoint { get; set; }
        internal List<RequestResult> Redirects { get; set; }
    }
}
