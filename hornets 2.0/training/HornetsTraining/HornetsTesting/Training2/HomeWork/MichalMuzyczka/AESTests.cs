using System.Runtime.InteropServices;
using Toci.HornetsTraining.Training2.HomeWork.Common_Michal.Infrastructure;
using Toci.HornetsTraining.Training2.HomeWork.Common_Michal.Secure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace HornetsTesting.Training2.HomeWork.MichalMuzyczka
{
    [TestClass]
    public class AESTests
    {
        [TestMethod]
        public void PassWhenEncryptDecrypt()
        {
            // Arrange
            var target = getTarget();
            var plainText = "Lorem ipsum ";

            // Act
            var encrypted = target.Encrypt(plainText);
            var decrypted = target.Decrypt(encrypted);

            // Assert
            Assert.AreEqual(plainText, decrypted);
        }

        private ICrypt getTarget()
        {
            IKernel kernel = Factory.GetInstance();
            return kernel.Get<ICrypt>();
        }
    }
}