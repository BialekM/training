using System.ComponentModel;
using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.Olek
{
    public abstract class OlekTableOperations : TableOperations//zrobiłem abstrakcyjną, bo być może nie chciało się zgrać z testem???
    {
        public override int[] BubbleSort(int[] tableToSort)
        {
            //  for w forze

            int[] a = new int[tableToSort.Length];
            var b = tableToSort.Length;


            for (int i = 0; i <= b; i++)
            {
                if (tableToSort[i] < tableToSort[i + 1])
                {
                    
                }
            }


            return a;
            //throw new System.NotImplementedException();
        }
        
    }
}