using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.TomaszKilian
{
    class TomaszKilianTableOperations : TableOperations
    {
        public override int[] BubbleSort(int[] tableToSort)
        {
            int counter = '0';
           
            
            
                for (int j = 0; j < tableToSort.Length; j++)
                {
                    if (tableToSort[j] > tableToSort[j + 1])
                    {
                        tableToSort[j] = counter;
                        tableToSort[j] = tableToSort[j + 1];
                        tableToSort[j + 1] = counter;
                        
                    }
                }
               

            
            return tableToSort;

        }
    }
}








