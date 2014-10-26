using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.Autofac.Contract
{
    public interface ICashMachine
    {
        bool PutCreditCard(ICreditCard card);
        bool EnterPinCode(string pinCode);
        int Withdraw(int amount, bool shouldPrintConfirmation);
    }
}
