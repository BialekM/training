using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.Factory;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Toci.HornetsTraining.Training3.Homework.LukaszSmierzchala.Tpl;

namespace HornetsTesting.Training3.Homework.LukaszSmierzchala.Tpl
{
    [TestClass]
    public class TplTests
    {
        [TestMethod]
        public void TplTest()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var tpl = new LukaszSmierzchalaTpl(
                new ToyotaBankTransferResolver(
                    new TransferHandlerFactory()), new Dictionary<int, string>() { { 0, "2160" } });
            tpl.DoTransfers();

            stopwatch.Stop();

            long time = stopwatch.ElapsedMilliseconds;
        }
    }
}
