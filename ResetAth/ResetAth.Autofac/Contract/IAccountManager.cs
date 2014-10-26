using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.Autofac.Contract
{
    public interface IAccountManager
    {
        int Withdraw(int amount);
    }
}
