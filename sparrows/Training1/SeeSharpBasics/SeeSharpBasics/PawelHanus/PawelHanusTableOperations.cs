using System;
using System.Runtime.InteropServices;
using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.PawelHanus
{
    public class PawelHanusTableOperations : TableOperations
    {

        public int[] AraySubset(int[] data, int offset, int size)
        {
            int[] subset = new int[size];

            for (int i = offset,j=0; i < data.Length; i++,j++)
            {
                subset[j] = data[i];
            }

            return subset;
        }

        public int[] GetElementsFromTable(int[] table, int greaterThan)
        {
            int[] result = new int[table.Length];
            int occurences = 0;

            for (int i = 0,j=0; i < table.Length; i++)
            {
                if (table[i] > greaterThan)
                {
                    result[j] = table[i];
                    occurences++;
                }
            }

            int[] resulttrim = AraySubset(result, 0, occurences);
            return resulttrim;
        }

        public int[] ReverseTable(int[] tableToReverse)
        {
            int[] reversed =new int[tableToReverse.Length];

            for (int i = 0, j=tableToReverse.Length-1; i < tableToReverse.Length; i++,j--)
            {
                reversed[i] = tableToReverse[j];
            }
            return reversed;
        }

        public override int[] BubbleSort(int[] tableToSort)
        {
            int Temp;
            int NumberOfReplacements = 0;
            for (int i = 0; i < tableToSort.Length; i++)
            {
                NumberOfReplacements = 0;
                for (int j = 0; j < tableToSort.Length-1; j++)
                {
                    
                    if (tableToSort[j] > tableToSort[j+1])
                    {
                        Temp = tableToSort[j+1];
                        tableToSort[j + 1] = tableToSort[j];
                        tableToSort[j] = Temp;
                        NumberOfReplacements++;
                    }                
                }
                if (NumberOfReplacements == 0)
                    return tableToSort;

            }
            return tableToSort;
        }

    }

}