using StructuralDesignPatterns.Proxy.Domain;
using System;

namespace StructuralDesignPatterns.Proxy.Manager
{
    public class RealInternet : IInternet
    {
        public RealInternet()
        {
            Console.WriteLine("RealProxy: Initialized");
        }

        public void Connect(string server)
        {
            Console.WriteLine("Connecting to " + server);
        }
    }
}
