using ResetAth.Autofac.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResetAth.Autofac.Implementations
{
    public class ClassicGui : IGui
    {
        public void StartValidation(ICreditCard card)
        {
            Console.WriteLine(String.Format("Włożono kartę o numerze {0}", card.AccountNo));
            Console.WriteLine("Rozpoczynam walidację...");
        }

        public void NotifyAboutPrinting()
        {
            Console.WriteLine("Drukowanie w trakcie...");
        }

        public void NotifyAboutError()
        {
            Console.WriteLine("Wystąpił bład! Odbierz kartę...");
        }

        public void Printing(int amount)
        {
            Console.WriteLine(String.Format("Wypłacam {0}", amount));
        }
    }
}
