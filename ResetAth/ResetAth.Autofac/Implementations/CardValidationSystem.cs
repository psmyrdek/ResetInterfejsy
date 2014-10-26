using ResetAth.Autofac.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.Autofac.Implementations
{
    public class CardValidationSystem : ICardValidationSystem
    {
        private ICreditCard _card;
        private IBankWebService _service;

        public CardValidationSystem(IBankWebService service)
        {
            this._service = service;
        }

        public bool Validate(ICreditCard card)
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
