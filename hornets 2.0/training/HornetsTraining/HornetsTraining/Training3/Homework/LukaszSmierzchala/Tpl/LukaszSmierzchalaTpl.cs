using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training3.Homework.Tpl;

namespace Toci.HornetsTraining.Training3.Homework.LukaszSmierzchala.Tpl
{
    public class LukaszSmierzchalaTpl : TplHomework
    {
        private readonly Dictionary<int, string> _banksCode;
        private readonly TransferResolver _transferResolver;

        public LukaszSmierzchalaTpl(TransferResolver transferResolver, Dictionary<int, string> banksCode)
        {
            _transferResolver = transferResolver;
            _banksCode = banksCode;
        }

        public override void DoTransfers()
        {
            int numberOfTransfers = 1000;
            Transfer[] transfers = RandTransfers(numberOfTransfers);

            TaskFactory tasks = new TaskFactory();

            Parallel.ForEach(transfers, (transfer) => _transferResolver.DoTransfer(transfer));

            //foreach (Transfer transfer in transfers)
            //{
            //    _transferResolver.DoTransfer(transfer);
            //}
        }

        private Transfer[] RandTransfers(int number)
        {
            var transfers = new Transfer[number];

            for (int i = 0; i < number; i++)
            {
                transfers[i] = RandTransfer();
            }

            return transfers;
        }

        private Transfer RandTransfer(string destinationBankCode, string sourceBankCode)
        {
            var random = new Random();

            return new Transfer
            {
                DestinationBankAccount = JoinBankAccount(
                    random.Next(99), destinationBankCode, random.Next(), random.Next()),
                Money = (random.NextDouble() + 0.00001) * 100000,
                SourceBankAccount = JoinBankAccount(
                    random.Next(99), sourceBankCode, random.Next(), random.Next())
            };
        }

        private Transfer RandTransfer()
        {
            var random = new Random();
            int count = _banksCode.Count;

            return RandTransfer(_banksCode[random.Next(0, count - 1)], _banksCode[random.Next(0, count - 1)]);
        }

        private string JoinBankAccount(int preCode, string bankCode, int firstPostCode, int secondPostCode)
        {
            return $"{preCode,2:D2}{bankCode}{firstPostCode,10:D10}{secondPostCode,10:D10}";
        }
    }
}

/* spostrzeżenia
Klasa Task: 
- jako opakowanie puli watkow (nie pojedynczego watku), (task != watek)
- reprezentuje operację(najczesciej dlugotrwala) do wykonania
- tworzy/uruchamia watki jako watki tla:
       Task task = Task.Factory.StartNew(() => { while(true); });
       - nie spowoduje bledu 
       - watki tla zostaja zakonczone najpozniej w momencie zakonczenia ostatniego watku pierwszoplanowego

       Task task = Task.Factory.StartNew(() => { while (true) ; });
       task.Wait();
       - spowoduje blad
       - metoda Wait powoduje zatrzymanie watku w ktorym jest wywolana, do momentu
         zakonczenia wykonywania operacji przez task - w tym przypadku nigdy

Klasa Parallel
- pozwala przeprowadzac operacje na kolekcjach (przy wykorzystaniu wielu watkow)
- znacznie ulatwia wykorzystanie w pelni wszystkich watkow sprzetowych
- w przypadku metod DoIn, DoOutTransfer, w klasie ToyotaBankTransferHandler
    - przy nie zalockowaniu operacji modyfikujacych wartosci w bazie danych - kolizja
    - przy zalockowaniu - wzrost wydajnosci prawie zaden
    - NIE WIEM jak zabezpieczyc sie przed kolizja, przy jednoczesnym umozliwieniu zwiekszenia wydajnosci
      (prawdopodobnie wymagana bardziej precyzyjna wiedza odnosnie zasad dzialania baz danych)


Zaganienie wielowatkowski i umiejetnosc efektywnego jego wykorzystania (w wielu roznych sytuacjach)
wydaje sie bardziej zlozone, niz pozostale, dotychczas omawiane zagadnienia 
*/
