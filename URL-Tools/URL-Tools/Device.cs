using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL_Tools
{
    public class Device
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Device(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
