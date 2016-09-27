using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Toci.HornetsTraining.Training2.HomeWork.PawelMocarski.MercedesBenzBank
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
            List<Transfer> transfers;
            string transferJson;


            if (File.Exists(fileName))
            {
                transferJson = File.ReadAllText(fileName);
                transfers = JsonConvert.DeserializeObject<List<Transfer>>(transferJson);

            }
            else
            {
                transfers = new List<Transfer>();
            }

            transfers.Add(transfer);
            transferJson = JsonConvert.SerializeObject(transfers);
            File.WriteAllText(fileName, transferJson);

            return true; //TODO
        }
    }
}
