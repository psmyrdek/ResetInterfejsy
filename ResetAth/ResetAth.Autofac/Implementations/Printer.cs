using ResetAth.Autofac.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.Autofac.Implementations
{
    class Printer : IPrinter
    {
        private IGui _gui;

        public Printer(IGui gui)
        {
            this._gui = gui;
        }

        public void PrintConfirmation(int amount)
        {
            this._gui.Printing(amount);
        }
    }
}
