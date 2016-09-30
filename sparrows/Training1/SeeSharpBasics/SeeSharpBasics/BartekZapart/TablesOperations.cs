namespace SeeSharpBasics.BartekZapart
{
    public abstract class TableOperations
    {
        public int[] GetElementsFromTable(int[] table, int greaterThan) // table = 1,2,3,4,5,6,7,8,9 greatherThan = 5 =&gt; 6,7,8,9
        {
            int[] result = new int[table.Length];

for (int i = 0, j = 0; i < table.Length; i++)
            {
                if (table[i] > greaterThan)
                {
                    //dodajemy do wynikowej tablicy
                    result[j] = table[i];
                    j++;
                }
            }

            return result;
        }

        public int[] ReverseTable(int[] tableToReverse)
        {
            int[] reversed = new int[tableToReverse.Length];

            for (int i = tableToReverse.Length - 1, j = 0; i>= 0; i--, j++)
            {
                reversed[j] = tableToReverse[i];
            }

            return reversed;
        }

        public abstract void BubbleSort(int[] tableToSort); //posortowac tablice
    }
}