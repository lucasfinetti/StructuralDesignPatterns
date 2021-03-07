using StructuralDesignPatterns.Facade.Services;
using System;

namespace StructuralDesignPatterns.Facade.Facade
{
    public class PaymentFacade
    {
        protected PaymentMachineService _paymentMachineService;

        protected CreditCardService _creditCardService;

        public PaymentFacade(PaymentMachineService paymentMachineService, CreditCardService creditCardService)
        {
            _paymentMachineService = paymentMachineService;
            _creditCardService = creditCardService;
        }

        public string DoPayment(decimal value)
        {
            var antiFraudService = new AntiFraudService();
            var bankService = new BankService();

            _creditCardService.RequestAuthorize();

            _paymentMachineService.ReceiveRequest();

            var antiFraudIsValid = antiFraudService.isValid(value);

            if (!antiFraudIsValid)
                return string.Empty;

            var bankBalanceValid = bankService.CheckBalance();

            if (bankBalanceValid)
                Console.WriteLine("Bank balance Ok");
            else
                Console.WriteLine("Bank balance Not Ok");

            _creditCardService.DoPayment(antiFraudIsValid, bankBalanceValid);

            _paymentMachineService.ReturnRequest();

            return $"${value} - Payment OK";
        }
    }
}
