using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HornetsTraining.Training2.HomeWork.NBP;
using HornetsTraining.Training2.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork.MichalMuzyczka
{
    [TestClass]
    public class NBPTransferHandlerTests
    {
        [TestMethod]
        public void PassWhenDoInTransfer()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            // Arrange
            var target = getTarget();
            var model = getModel();

            // Act
            var result = target.DoInTransfer(model);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void PassWhenDoOutTransfer()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            // Arrange
            var target = getTarget();
            var model = getModel();

            // Act
            var result = target.DoOutTransfer(model);

            // Assert
            Assert.IsTrue(result);
        }


        private TransferHandler getTarget()
        {
            return new NBPTransferHandler();
        }

        private Transfer getModel()
        {
            return new Transfer
            {
                Money = 100.50,
                DestinationBankAccount = "10 1050 10203040506070809000",
                SourceBankAccount = "10 1050 10203040506070809000",
             };
        }
    }
}
