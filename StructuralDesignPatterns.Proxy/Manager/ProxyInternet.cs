using StructuralDesignPatterns.Proxy.Domain;
using System;
using System.Collections.Generic;

namespace StructuralDesignPatterns.Proxy.Manager
{
    public class ProxyInternet : IInternet
    {
        private List<string> BannedSites;
        private IInternet RealInternet;

        public ProxyInternet()
        {
            Console.WriteLine("ProxyClient: Initialized");

            BannedSites = new List<string>();
            BannedSites.Add("abc.com");
            BannedSites.Add("def.com");
            BannedSites.Add("ijk.com");
            BannedSites.Add("lnm.com");

            RealInternet = new RealInternet();
        }

        public void Connect(string server)
        {
            if (BannedSites.Contains(server.ToLower()))
            {
                Console.WriteLine("Access Denied");
                return;
            }

            RealInternet.Connect(server);
        }
    }
}
