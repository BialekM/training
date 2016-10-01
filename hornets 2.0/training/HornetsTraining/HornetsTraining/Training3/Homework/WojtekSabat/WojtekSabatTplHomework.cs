using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.BankMillenium;
using Toci.HornetsTraining.Training3.Homework.Tpl;

namespace Toci.HornetsTraining.Training3.Homework.WojtekSabat
{
    public class WojtekSabatTplHomework : TplHomework
    {
        private readonly TransferResolver _transferResolver = new BankMilleniumTransferResolver();
        private List<Transfer> transfers = new List<Transfer>();

        public override void DoTransfers()
        {
            const int ITERATIONS = 100000;
            TaskFactory taskFactory = new TaskFactory();
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            for (int i = 0; i < ITERATIONS; i++)
            {
                taskFactory.StartNew(DelMethod);
                //DelMethod();
            }
            while (true)                          // Konieczne, aby DelMethod() wykonała się określoną liczbę razy
                if (transfers.Count == ITERATIONS)// Inaczej stopWatch stopuje zanim wątki skończą wykonywać DelMethod()
                {
                    stopWatch.Stop();
                    break;
                }                              
            var duration = stopWatch.Elapsed; 
        }
        //ITERATIONS = 10000                               ITERATIONS = 100000
        //00:00:47.7348540 - parallelized - looser         komunikat poniżej
        //00:00:39.3500510 - sequence     - winner         00:06:08.2786909

        private void DelMethod()
        {
             var transfer = TransferRandomizer.GetRandomTransfer();
             _transferResolver.DoTransfer(transfer);
            transfers.Add(transfer);
        }
    }
}
/*Środowisko CLR nie było w stanie przejść od kontekstu COM 0x10b1b68 do kontekstu COM 0x10b1c20 w ciągu 60 sekund.Wątek, 
 * do którego należy docelowy kontekst/apartament, najprawdopodobniej jest w stanie oczekiwania lub przetwarzania bardzo 
 * długotrwałej operacji bez przekazywania komunikatów systemu Windows.Ta sytuacja ma na ogół negatywny wpływ na wydajność 
 * i może nawet doprowadzić do tego, że aplikacja przestanie odpowiadać lub że użycie pamięci będzie stale wzrastać z czasem.
 * Aby uniknąć tego problemu, wszystkie wątki STA powinny używać wartości podstawowych oczekiwania z 
 * przekazywaniem komunikatów(takich jak CoWaitForMultipleHandles) i rutynowo przekazywać komunikaty podczas długotrwałych operacji.
 */