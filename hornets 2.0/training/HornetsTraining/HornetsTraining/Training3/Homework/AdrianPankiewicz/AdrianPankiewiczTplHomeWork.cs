using System.Threading.Tasks;
using HornetsTraining.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork.Mbank;
using HornetsTraining.Training3.Homework.Tpl;

namespace HornetsTraining.Training3.Homework.AdrianPankiewicz
{
    public class AdrianPankiewiczTplHomeWork : TplHomework
    {
        
        public override void DoTransfers()
        {
            TaskFactory taskFactory = new TaskFactory();
            TransferResolver transferResolver = new MBankTranferResolver();
            for (int i = 0; i < 1000; i++)
            {
                Transfer newTransfer = RandomTransferGenerator.GenerateRandomTransfer();
                taskFactory.StartNew(() => transferResolver.DoTransfer(newTransfer));
            }

        }

    }
}