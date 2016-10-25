using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.AndrzejIwanski
{
    public class AndrzejIwanskiTableOperations : TableOperations
    {
        public override int[] BubbleSort(int[] tableToSort)
        {
            int temp;

            for (int j = 0; j < tableToSort.Length - 1; j++)
            {
                for (int i = 0; i < tableToSort.Length - 1; i++)
                {
                    if (tableToSort[i] > tableToSort[i + 1])
                    {
                        Zamien(ref tableToSort[i], ref tableToSort[i + 1]);
                    }
                }
            }
            return tableToSort;
        }

        private void Zamien<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}