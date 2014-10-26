using ResetAth.Autofac.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.Autofac.Implementations
{
    class BankWebService : IBankWebService
    {
        public bool Validate(string accountNo)
        {
            return true;
        }
    }
}
