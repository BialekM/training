﻿using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.LukaszSykutera
{
    public class LukaszSykuteraMyList<TListItem> : MyList<TListItem>
    {
        public override void Add(TListItem item)
        {
            TListItem[] newList = new TListItem[Index +1];

            for (int i = 0; i < Index; i++)
            {
                newList[i] = listOfItems[i];
            }

            newList[Index] = item;
            listOfItems = newList;

            Index++;
        }
    }
}