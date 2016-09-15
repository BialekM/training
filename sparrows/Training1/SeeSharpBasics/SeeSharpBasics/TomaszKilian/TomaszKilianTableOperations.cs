using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.TomaszKilian
{
    class TomaszKilianTableOperations : TableOperations
    {
        public override int[] BubbleSort(int[] tableToSort)
        {
            int counter = '0';
            bool tellmeend = false;
            for (int i = 0; i < tableToSort.Length; i++)
            {
                for (int j = 0; j < tableToSort.Length; j++)
                {
                    if (tableToSort[j] > tableToSort[j + 1])
                    {
                        tableToSort[j] = counter;
                        tableToSort[j] = tableToSort[j + 1];
                        tableToSort[j + 1] = counter;
                        tellmeend = false;
                    }
                }
                if (tellmeend == true)
                    break;

            }
            return tableToSort;

        }
    }
}
