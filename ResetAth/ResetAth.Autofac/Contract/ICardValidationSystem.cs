using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.Autofac.Contract
{
    public interface ICardValidationSystem
    {
        bool Validate(ICreditCard card);
        bool CheckPinCode(string pinCode);
    }
}
