using Autofac;
using ResetAth.Autofac.Implementations;
using ResetAth.Autofac.Contract;
using ResetAth.Autofac.Resolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.Autofac
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = AutofacResolver.GetContainer();

            ICreditCard card = new CreditCard("1111-2222-3333-4444");

            ICashMachine cashMachine = container.Resolve<ICashMachine>();

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
