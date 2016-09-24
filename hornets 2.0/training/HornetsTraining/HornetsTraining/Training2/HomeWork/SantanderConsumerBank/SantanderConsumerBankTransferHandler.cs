using System;
using System.Xml;

namespace HornetsTraining.Training2.HomeWork.SantanderConsumerBank
{
    public class SantanderConsumerBankTransferHandler : TransferHandler
    {
        protected XmlDocument Writer = new XmlDocument();

        public override bool DoInTransfer(Transfer transfer)
        {
            XmlElement el = (XmlElement)Writer.AppendChild(Writer.CreateElement("InTransfer"));
            el.AppendChild(Writer.CreateElement("SourceBankAccount")).InnerText = transfer.SourceBankAccount;
            el.AppendChild(Writer.CreateElement("DestinationBankAccount")).InnerText = transfer.DestinationBankAccount;
            el.AppendChild(Writer.CreateElement("Money")).InnerText = Convert.ToString("+ " + transfer.Money);
            el.AppendChild(Writer.CreateElement("DateTime")).InnerText = Convert.ToString(DateTime.Now);
            Writer.Save("doInTransfer.xml");
            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            XmlElement el = (XmlElement)Writer.AppendChild(Writer.CreateElement("OutTransfer"));
            el.AppendChild(Writer.CreateElement("SourceBankAccount")).InnerText = transfer.SourceBankAccount;
            el.AppendChild(Writer.CreateElement("DestinationBankAccount")).InnerText = transfer.DestinationBankAccount;
            el.AppendChild(Writer.CreateElement("Money")).InnerText = Convert.ToString("- " + transfer.Money);
            el.AppendChild(Writer.CreateElement("DateTime")).InnerText = Convert.ToString(DateTime.Now);
            Writer.Save("doOutTransfer.xml");
            return true;
        }
    }
}