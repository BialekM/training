using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.DesignPatterns.ExceptionHandling;
using Toci.DesignPatterns.ExceptionHandling.ErrorLog;


namespace HornetsTesting.ExceptionHandling.ErrorLog
{
    [TestClass]
    public class ErrorLogTests
    {
        [TestMethod]
        public void ConnectToDatabase()
        {
            using (var database = new TociExceptionEntities())
            {
                var errorLog = database.ErrorLog;
            }
        }

        [TestMethod]
        public void TociExceptionTest()
        {
            int recordsNumber = GetRecordsNumber();
            try
            {
                ThrowTociException();
            }
            catch (TociApplicationException)
            {
                
            }

            Assert.AreEqual(GetRecordsNumber(), recordsNumber+1);
        }

        private int GetRecordsNumber()
        {
            using (var database = new TociExceptionEntities())
            {
                return database.ErrorLog.Count();
            }
        }

        private void ThrowTociException()
        {
            throw new TociDbApplicationException("custom message example", 1, "backend message example");
        }

    }
}