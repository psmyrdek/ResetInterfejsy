using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.NoAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard("1111-2222-3333-4444");
            CashMachine cashMachine = new CashMachine();
            int money = 0;

            bool cardIsValid = cashMachine.PutCreditCard(card);

            if (cardIsValid)
            {
                bool pinIsValid = cashMachine.EnterPinCode("1231");

                if (pinIsValid)
                {
                    money = cashMachine.Withdraw(2000, true);
                }
            }

            Console.WriteLine(money);
            Console.ReadKey();
        }
    }
}
