using System;
using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.KrzysztofPater
{
    public class KrzysztofPaterMyList<TListItem> : MyList<TListItem>
    {
        protected TListItem[] listOfItems = new TListItem[1];
        protected int Index = 0;

        public virtual void Add(TListItem item)
        {
            listOfItems[Index] = item;

            TListItem[] tempList = new TListItem[Index + 1];

            for (int i = 0; i < listOfItems.Length; i++)
            {
                tempList[i] = listOfItems[i];
            }
            listOfItems = tempList;
        }

    }
}