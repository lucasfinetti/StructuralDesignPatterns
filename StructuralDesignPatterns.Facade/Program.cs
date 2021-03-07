using StructuralDesignPatterns.Facade.Facade;
using StructuralDesignPatterns.Facade.Services;
using System;

namespace StructuralDesignPatterns.Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            var paymentMachineService = new PaymentMachineService("Stone");
            var creditCardService = new CreditCardService("Visa");
            
            var paymentFacade = new PaymentFacade(paymentMachineService, creditCardService);

            var response = paymentFacade.DoPayment(1000);

            Console.WriteLine(response);
            Console.ReadKey();
        }
    }
}
