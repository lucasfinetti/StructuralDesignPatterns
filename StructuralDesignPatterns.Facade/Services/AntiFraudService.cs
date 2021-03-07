using System;

namespace StructuralDesignPatterns.Facade.Services
{
    public class AntiFraudService
    {
        public bool isValid(decimal value)
        {
            Console.WriteLine("Checking AntiFraud...");
            
            if (value < 10000)
            {
                Console.WriteLine("AntiFraud OK!");
            }
            else
            {
                Console.WriteLine("AntiFraud Not OK!");
            }

            return value < 10000;
        }
    }
}
