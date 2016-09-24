using System.ComponentModel;
using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.Olek
{
    public class OlekTableOperations : TableOperations
    {
        public override int[] BubbleSort(int[] tableToSort)
        {
            //  tutaj moja implementacja

            int[] a = new int[tableToSort.Length];
            var b = tableToSort.Length;


            for (int i = 0; i <= b; i++)
            {
                if (tableToSort[i] < tableToSort[i + 1])
                {
                    
                }
            }
            
           

            throw new System.NotImplementedException();
        }
    }
}