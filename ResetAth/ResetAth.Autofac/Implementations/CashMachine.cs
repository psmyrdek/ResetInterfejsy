using ResetAth.Autofac.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.Autofac.Implementations
{
    public class CashMachine : ICashMachine
    {
        private ICardValidationSystem _validationSystem;
        private IGui _gui;
        private IPrinter _printer;
        private IAccountManager _manager;

        public CashMachine(ICardValidationSystem validation, 
                           IGui gui, 
                           IPrinter printer, 
                           IAccountManager manager)
        {
            this._validationSystem = validation;
            this._gui = gui;
            this._printer = printer;
            this._manager = manager;
        }

        public bool PutCreditCard(ICreditCard card)
        {
            this._gui.StartValidation(card);

            return this._validationSystem.Validate(card);
        }

        public bool EnterPinCode(string pinCode)
        {
            return this._validationSystem.CheckPinCode(pinCode);
        }

        public int Withdraw(int amount, bool shouldPrintConfirmation)
        {
            int tmpAmount = this._manager.Withdraw(amount);

            if (amount > 0 && shouldPrintConfirmation == true)
            {
                this._gui.NotifyAboutPrinting();
                this._printer.PrintConfirmation(amount);
            }
            else
            {
                this._gui.NotifyAboutError();
            }

            return amount;
        }
    }
}
