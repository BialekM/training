using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Serialization;
using Toci.HornetsTraining.Training2.HomeWork.Common_Michal.Const;
using Toci.HornetsTraining.Training2.HomeWork.Common_Michal;

namespace Toci.HornetsTraining.Training2.HomeWork.NBP
{
    public class NBPTransferHandler : TransferHandler
    {
        /// <summary>
        /// Utworzenie pseudo raportu z przelewu
        /// </summary>
        /// <param name="transfer"></param>
        /// <returns></returns>
        public override Boolean DoInTransfer(Transfer transfer)
        {
            try
            {
                var report = new TransferReport();
                report.Transfer = transfer;
                report.CreatedTime = DateTime.Now;
                report.TransferStamp = Guid.NewGuid().ToString();
                report.Description = "Example raport";
                report.Transfer = transfer;
                report.InfoFromTransfer();
                report.MoneyBefore = 10000.00;
                report.MoneyNow = report.MoneyBefore + transfer.Money;
                report.MoneyChange = report.MoneyNow - report.MoneyBefore;

                Serializer.ObjectToXmlFile<TransferReport>(report, "TransferInConfirm");
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Utworzenie pseudo raportu z przelewu
        /// </summary>
        /// <param name="transfer"></param>
        /// <returns></returns>
        public override Boolean DoOutTransfer(Transfer transfer)
        {
            try
            {
                var report = new TransferReport();
                report.Transfer = transfer;
                report.CreatedTime = DateTime.Now;
                report.TransferStamp = Guid.NewGuid().ToString();
                report.Description = "Example raport";
                report.Transfer = transfer;
                report.InfoFromTransfer();
                report.MoneyBefore = 10000.00;
                report.MoneyNow = report.MoneyBefore - transfer.Money;
                report.MoneyChange = report.MoneyNow - report.MoneyBefore;

                Serializer.ObjectToXmlFile<TransferReport>(report, "TransferOutConfirm");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}