using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Toci.HornetsTraining.Training2.HomeWork.BankMillenium
{
    public class BankMilleniumTransferHandler : TransferHandler
    {
        private const string XmlFilePath = @"../../../HornetsTraining/Training2/HomeWork/BankMillenium/BankMilleniumAccountInfo.xml";

        public override bool DoInTransfer(Transfer transfer)
        {
            try
            {
                if (!File.Exists(XmlFilePath))
                {
                    CreateXml(transfer.SourceBankAccount,transfer.DestinationBankAccount,transfer.Money);
                }
                else
                {
                    AppendToXml(transfer.SourceBankAccount, transfer.DestinationBankAccount, transfer.Money);
                }
                return true;
            }
            catch 
            {
                return false;
                
            }
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            try
            {
                if (!File.Exists(XmlFilePath))
                {
                    CreateXml(transfer.SourceBankAccount, transfer.DestinationBankAccount, transfer.Money * -1);
                }
                else
                {
                    AppendToXml(transfer.SourceBankAccount, transfer.DestinationBankAccount, transfer.Money * -1);
                }
                return true;
            }
            catch
            {
                return false;

            }
        }

        

        public string ReadAccountBalance()
        {
            XDocument transfers = XDocument.Load(XmlFilePath);
            var result = XElement.Load(XmlFilePath).DescendantNodes().Last();
            return result.ToString();


        }

        public void CreateXml(string sourceBankAccount, string destinationBankAccount, double money)
        {

            XDocument transfers = new XDocument(
                new XElement("Transfers",
                    new XElement("Date_Time", GetDate()),
                    //new XElement("Time", DateTime.Now.TimeOfDay),
                    new XElement("SourceBankAccount", sourceBankAccount),
                    new XElement("DestinationBankAccount", destinationBankAccount),
                    new XElement("Money", money),
                    new XElement("AccountBalnace", money))
                );
            transfers.Save(XmlFilePath);

        }

        public void AppendToXml(string sourceBankAccount, string destinationBankAccount, double money)
        {
            XDocument transfers = XDocument.Load(XmlFilePath);
            double accountBalance = double.Parse(ReadAccountBalance());
            double newMoney = money;

            XElement transfer = transfers.Element("Transfers");
            transfer.Add(
                new XElement("Date_Time", GetDate()),
                //new XElement("Time", DateTime.Now.TimeOfDay),
                new XElement("SourceBankAccount", sourceBankAccount),
                new XElement("DestinationBankAccount", destinationBankAccount),
                new XElement("Money", money),
                new XElement("AccountBalance", accountBalance + newMoney)
                );
            transfers.Save(XmlFilePath);

        }

        public string GetDate()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            string dateString = date.ToString(System.Globalization.CultureInfo.InvariantCulture);
            return dateString;
        }
    }
 }
