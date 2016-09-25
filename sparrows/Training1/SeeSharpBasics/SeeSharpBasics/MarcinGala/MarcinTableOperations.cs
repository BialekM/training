using System;
using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.MarcinGala
{
    public class MarcinTableOperations : TableOperations
    {
        public override int[] BubbleSort(int[] tableToSort)
        {
            int[] bufor = new int[tableToSort.Length];

            for (int i = 1; i < tableToSort.Length; i++)
            {
                for (int j = tableToSort.Length - 1; j >= 1; j--)
                {
                    if (tableToSort[j] < tableToSort[j - 1])
                    {
                        bufor[i] = tableToSort[j - 1];
                        tableToSort[j - 1] = tableToSort[j];
                        tableToSort[j] = bufor[i];
                    }
                }
            }

            return tableToSort;
        }
    }
}