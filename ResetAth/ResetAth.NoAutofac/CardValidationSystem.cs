using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.NoAutofac
{
    public class CardValidationSystem
    {
        private CreditCard _card;
        private BankWebService _service;

        public CardValidationSystem()
        {
            this._service = new BankWebService();
        }

        public bool Validate(CreditCard card)
        {
            this._card = card;
            return this._service.Validate(card.AccountNo);
        }

        public bool CheckPinCode(string pinCode)
        {
            if (this._card == null || pinCode.Length != 4)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
