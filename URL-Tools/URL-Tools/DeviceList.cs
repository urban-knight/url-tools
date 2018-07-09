using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL_Tools
{
    public class DeviceList
    {
        internal List<Device> devices;

        public DeviceList()
        {
            this.devices = new List<Device> {
                {new Device ("[D] Windows Chrome", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/525.19 (KHTML, like Gecko) Chrome/1.0.154.53 Safari/525.19") },
                {new Device ("[D] MacOS Safari", "Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en-us) AppleWebKit/312.8 (KHTML, like Gecko) Safari/312.6") },
                {new Device ("[D] Windows Safari", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16") },
                {new Device ("[D] Windows Opera", "Opera/9.80 (Windows NT 5.1) Presto/2.12.388 Version/12.14") },
                {new Device ("[D] Windows Mozilla", "Mozilla/5.0 (Windows; U; Windows NT 5.0; it-IT; rv:1.7.12) Gecko/20050915") },
                { new Device("[M] iOS Safari", "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_1 like Mac OS X) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1") },
                { new Device("[M] Android Chrome", "Mozilla/5.0 (Linux; Android 7.0; SM-G930V Build/NRD90M) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.125 Mobile Safari/537.36") },
                { new Device("[M] Android OperaMobile", "Opera/9.80 (Android 2.2; Opera Mobi/-2118645896; U; pl) Presto/2.7.60 Version/10.5") },
                { new Device("[M] SymbOS OperaMobile", "Opera/9.80 (S60; SymbOS; Opera Tablet/9174; U; en) Presto/2.7.81 Version/10.5") }
            };
        }

        public string[] GetDevices()
        {
            List<string> devices = new List<string>();
            foreach (Device d in this.devices)
            {
                devices.Add(d.Name);
            }
            return devices.ToArray();
        }

        public Device FindByName(string name) {
            return this.devices.Find(i => i.Name == name);
        }
    }
}
