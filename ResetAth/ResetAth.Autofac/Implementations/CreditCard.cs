using ResetAth.Autofac.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.Autofac.Implementations
{
    public class CreditCard : ICreditCard
    {
        public string AccountNo { get; set;}

        public CreditCard(string accountNo)
        {
            this.AccountNo = accountNo;
        }
    }
}
