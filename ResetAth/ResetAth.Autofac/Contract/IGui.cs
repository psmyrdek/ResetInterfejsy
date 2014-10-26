using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.Autofac.Contract
{
    public interface IGui
    {
        void StartValidation(ICreditCard card);
        void NotifyAboutPrinting();
        void NotifyAboutError();
        void Printing(int amount);
    }
}
