﻿using HornetsTraining.Training2.HomeWork.Common_Michal.Secure;
using Ninject;
using Ninject.Modules;

namespace HornetsTraining.Training2.HomeWork.Common_Michal.Infrastructure
{
    public class Container : NinjectModule
    {
        public override void Load()
        {
            Bind<ICrypt>().To<AESCrypt>().WithConstructorArgument(securityOptions);
        }

        private readonly SecurityOptions securityOptions = new SecurityOptions
        {
            Password = "pk4141ddsfs==",
            HashAlghorithm = "SHA1",
            Iterations = 5,
            KeySize = 256,
            Salt = "grp32lmi02",
            Vector = "ple03eki3lekoqp1",
        };
    }
}