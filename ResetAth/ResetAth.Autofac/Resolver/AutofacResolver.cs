using Autofac;
using ResetAth.Autofac.Contract;
using ResetAth.Autofac.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.Autofac.Resolver
{
    public static class AutofacResolver
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CashMachine>().As<ICashMachine>();
            builder.RegisterType<BankWebService>().As<IBankWebService>();
            builder.RegisterType<CardValidationSystem>().As<ICardValidationSystem>();
            builder.RegisterType<ClassicGui>().As<IGui>();
            builder.RegisterType<Printer>().As<IPrinter>();
            builder.RegisterType<AccountManager>().As<IAccountManager>();

            return builder.Build();
        }
    }
}
