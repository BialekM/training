using System.Linq;
using System;
using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.MichalMazur
{
    public class MichalMazurList<TListItem> : MyList<TListItem>
    {
        private TListItem[] listWithAddItem;
        private TListItem[] listWithRemovedItem;
        public MichalMazurList()
        {
            listOfItems = new TListItem[1];
            Index = 0;
        }
        public override void Add(TListItem item)
        {

            if (Index >= listOfItems.Length)
            {

                listWithAddItem = new TListItem[listOfItems.Length + 1];
                int count = 0;
                foreach (var i in listOfItems)
                {
                    listWithAddItem[count] = listOfItems[count];
                    count++;
                }
                listOfItems = listWithAddItem;
                listOfItems[Index] = item;
                Index++;

            }
            else
            {
                listOfItems[Index] = item;
                Index++;


            }
        }

        public void Remove(TListItem item)
        {
            listWithRemovedItem = new TListItem[listOfItems.Length - 1];
            int indexOfFindingItem = ReturnPositionOfFindingElement(item);
            Copy(indexOfFindingItem);
            listOfItems = listWithRemovedItem;

        }

        private int ReturnPositionOfFindingElement(TListItem item)
        {
            for (int i = 0; i < listOfItems.Length; i++)
            {
                if (listOfItems[i].Equals(item))
                    return i;
            }
            return -1;
        }

 

        private void Copy(int position)
        {
            for (int j=0,i=0; i < listOfItems.Length;j++, i++)
            {
                if (i == position)
                {
                    j -= 1;
                    continue;
                }
                listWithRemovedItem[j] = listOfItems[i];
                
            }
        }

    }
}