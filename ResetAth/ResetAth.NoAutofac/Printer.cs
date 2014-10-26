using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.NoAutofac
{
    class Printer
    {
        private ClassicGui _gui;

        public Printer(ClassicGui gui)
        {
            this._gui = gui;
        }

        public void PrintConfirmation(int amount)
        {
            this._gui.Printing(amount);
        }
    }
}
