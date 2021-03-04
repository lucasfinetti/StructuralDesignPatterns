using StructuralDesignPatterns.Proxy.Domain;
using StructuralDesignPatterns.Proxy.Manager;
using System;

namespace StructuralDesignPatterns.Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternet();

            internet.Connect("proxy.org");
            internet.Connect("abc.com");

            Console.ReadKey();
        }
    }
}
