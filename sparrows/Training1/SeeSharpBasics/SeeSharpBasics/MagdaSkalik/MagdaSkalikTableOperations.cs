using SeeSharpBasics.BartekZapart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.MagdaSkalik
{
    public class MagdaSkalikTableOperations : TableOperations
    {
        public override void BubbleSort(int[] tableToSort) //posortowanie tablicy
        {

            int[] temp = new int[tableToSort.Length];
            for (int j = 0; j < tableToSort.Length - 1; j++)
            {
                for (int i = 0; i < tableToSort.Length - 1; i++)
                {
                    if (tableToSort[i] > tableToSort[i + 1])
                    {
                        temp[i] = tableToSort[i];
                        tableToSort[i] = tableToSort[i + 1];
                        tableToSort[i + 1] = temp[i];
                    }

                }
            }
            return tableToSort;
        
        }
    }
}
