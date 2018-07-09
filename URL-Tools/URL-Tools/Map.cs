using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL_Tools
{
    public class Map
    {
        public List<string> outer { get; set; }
        public List<string> inner { get; set; }

        public Map()
        {
            this.outer = new List<string>();
            this.inner = new List<string>();
        }
    }
}
