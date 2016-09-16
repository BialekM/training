using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HornetsTraining.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork.NBP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork.MichalMuzyczka
{
    [TestClass]
    public class NBPTransferResolverTests
    {
        [TestMethod]
        public void PassWhenGetNBPHandler()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            // Arrange
            var target = getTarget();
            var model = getModel();

            // Act
            target.DoTransfer(model);

            // Assert


        }

        private TransferResolver getTarget()
        {
            return new NBPTransferResolver();
        }

        private Transfer getModel()
        {
            return new Transfer
            {
                Money = 100.50,
                DestinationBankAccount = "10 1010 10203040506070809000",
                SourceBankAccount = "10 1010 10203040506070809000",
            };
        }
    }
}
