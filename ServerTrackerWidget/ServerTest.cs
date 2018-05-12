using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;


namespace ServerTrackerWidget
{
    public class ServerTest
    {
        private Ping pingSender;
        private PingOptions options;

        public ServerTest()
        {
            pingSender = new Ping();
            options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;
        }

        public IPStatus Ping(string IP)
        {
            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(IP, timeout, buffer, options);
            
            return reply.Status;
        }
    }
}