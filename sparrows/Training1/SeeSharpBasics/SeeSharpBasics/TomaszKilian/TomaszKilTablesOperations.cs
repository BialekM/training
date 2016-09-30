using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.TomaszKilian
{
    class TomaszKilianTableOperations : TableOperations
    {
        public override void BubbleSort(int[] tableToSort)
        {
            int counter = '0';
            bool tellmetrue = false;


            for (int i = 0; i < tableToSort.Length - 1; i++)
            {
                tellmetrue = true;
                for (int j = 0; j < tableToSort.Length; j++)
                {
                    if (tableToSort[j] > tableToSort[j + 1])
                    {
                        tableToSort[j] = counter;
                        tableToSort[j] = tableToSort[j + 1];
                        tableToSort[j + 1] = counter;
                        tellmetrue =false;
                    }
                }
                if (tellmetrue == true)
                    break;
            }

               

            
            return tableToSort;

        }
    }
}








