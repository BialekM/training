using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HornetsTraining.Training2.HomeWork.PawelMocarski.MercedesBenzBank
{
    public class MercedesBenzBankTransferHandler : TransferHandler
    {
        private const string InTransferLogFileName = "in.log";
        private const string OutTransferLogFileName = "out.log";

        public override bool DoInTransfer(Transfer transfer)
        {
            return DoTransfer(InTransferLogFileName, transfer);
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            return DoTransfer(OutTransferLogFileName, transfer);
        }

        private bool DoTransfer(string fileName, Transfer transfer)
        {
            var transferJson = File.ReadAllText(fileName);
            var transfers = JsonConvert.DeserializeObject<List<Transfer>>(transferJson);

            transfers.Add(transfer);
            transferJson = JsonConvert.SerializeObject(transfers);
            File.WriteAllText("", fileName);

            return true; //TODO
        }
    }
}
