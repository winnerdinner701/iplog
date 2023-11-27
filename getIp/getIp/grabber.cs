using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace getIp
{
    class grabber
    {
        public static string GetIp()
        {
            string ip = new WebClient().DownloadString("https://api.ipify.org");
            string api_key = "1dc58650d7ec486f9df61e3923bcb28e";
            string url = "https://api.ipgeolocation.io/ipgeo?apiKey=" + api_key + "&ip=" + ip;
            string re = new WebClient().DownloadString(url);
            return "**geolocation**: " + re + "\n**ip**: " +ip;
        }
    }
}
