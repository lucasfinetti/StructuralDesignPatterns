using System;

namespace StructuralDesignPatterns.Facade.Services
{
    public class BankService
    {
        public bool CheckBalance()
        {
            // Code for check if balance is ok

            Console.WriteLine("Checking balance...");

            return true;
        }
    }
}
