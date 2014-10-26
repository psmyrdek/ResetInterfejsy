using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.NoAutofac
{
    public class CreditCard
    {
        public string AccountNo { get; private set;}

        public CreditCard(string accountNo)
        {
            this.AccountNo = accountNo;
        }
    }
}
