using ResetAth.Autofac.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.Autofac.Implementations
{
    public class AccountManager : IAccountManager
    {
        public int Withdraw(int amount)
        {
            return amount;
        }
    }
}
