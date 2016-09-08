using HornetsTraining.Training1.Generics;
using System;
namespace HornetsTraining.Training1.HomeWork.MichalMazur
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
            for (int count = 0; count < listOfItems.Length; count++)
            {
                if (listOfItems[count].Equals(item))
                {
                    listWithRemovedItem = new TListItem[listOfItems.Length - 1];

                    for (int count2 = 0; count2 < count; count2++)
                    {
                        listWithRemovedItem[count2] = listOfItems[count2];
                    }
                    for (int count2 = count; count2 < listOfItems.Length - 1; count2++)
                    {
                        listWithRemovedItem[count2] = listOfItems[count2 + 1];
                    }

                }
                
                
                 
            }
        }

    }
}