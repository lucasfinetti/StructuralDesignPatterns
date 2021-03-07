using System;

namespace StructuralDesignPatterns.Facade.Services
{
    public class PaymentMachineService
    {
        public string Name { get; set; }

        public PaymentMachineService(string name)
        {
            Name = name;
        }

        public void ReceiveRequest()
        {
            Console.WriteLine($"Receiving request on Machine {Name}...");
        }

        public void ReturnRequest()
        {
            Console.WriteLine("Returning request");
        }
    }
}
