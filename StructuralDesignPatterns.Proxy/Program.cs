using StructuralDesignPatterns.Proxy.Manager;
using System;

namespace StructuralDesignPatterns.Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var internet = new ProxyInternet();

            internet.Connect("proxy.org");
            internet.Connect("abc.com");

            Console.ReadKey();
        }
    }
}
