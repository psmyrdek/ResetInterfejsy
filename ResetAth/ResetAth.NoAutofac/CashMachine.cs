using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.NoAutofac
{
    class CashMachine
    {
        private CardValidationSystem _validationSystem;
        private ClassicGui _gui;
        private Printer _printer;
        private AccountManager _manager;

        public CashMachine()
        {
            this._validationSystem = new CardValidationSystem();
            this._gui = new ClassicGui();
            this._printer = new Printer(_gui);
            this._manager = new AccountManager();
        }

        public bool PutCreditCard(CreditCard card)
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
