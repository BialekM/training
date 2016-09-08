using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGenerics
{
    public class GenericsOperations<TList> : MyList<int>
    {
        protected int[] myListOfInt;
        int size = 1;
        public override void Add(int item)
        {
            listOfItems = new int[size];
            for (int i = 0; i < size; i++)
            {

                myListOfInt[i] = item;
                size++;
                return;
            }

        }
    }
}
