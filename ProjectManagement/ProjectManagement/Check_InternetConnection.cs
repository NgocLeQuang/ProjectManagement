using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace ProjectManagement
{
    class CheckInternetConnection
    {
        public bool InternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                string host = "10.10.10.248";
                byte[] buffer = new byte[32];
                int timeout = 10;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply != null && reply.Status == IPStatus.Success)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
