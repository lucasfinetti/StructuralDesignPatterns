using System;

namespace StructuralDesignPatterns.Facade.Services
{
    public class CreditCardService
    {
        public string Name { get; set; }

        public CreditCardService(string name)
        {
            Name = name;
        }

        public void RequestAuthorize()
        {
            Console.WriteLine($"Credit card requesting authorization for {Name}...");
        }

        public bool DoPayment(bool antiFraudValid, bool bankBalanceValid)
        {
            Console.WriteLine("Doing payment");
            return antiFraudValid && bankBalanceValid;
        }
    }
}
