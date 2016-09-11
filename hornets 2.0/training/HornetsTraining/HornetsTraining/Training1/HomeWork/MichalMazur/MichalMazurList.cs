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
            int count = 0;
            bool foundItem = false;

            foreach (var i in listOfItems)
            {

                if (i.Equals(item))
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
                    foundItem = true;
                    break;

                }

                count++;

            }
            if (foundItem == true)
                listOfItems = listWithRemovedItem;
            else
                throw new Exception("item " + item.ToString() + " not found on list");
        }

    }
}