using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.Edwin
{
    public class EdwinTablesOperations : TableOperations
    {
        public override int[] BubbleSort(int[] tableToSort) //sortowanie bąbelkowe
        {
            int tymczasowa;

            for (int i = tableToSort.Length - 1; i > 0; i--)
            {
                for (int j = tableToSort.Length - 1; j > 0; j--)
                {
                    if (tableToSort[j] < tableToSort[j - 1])
                    {
                        tymczasowa = tableToSort[j];
                        tableToSort[j] = tableToSort[j - 1];
                        tableToSort[j - 1] = tymczasowa;
                    }

                }

            }
            return tableToSort;
        }
    }
}