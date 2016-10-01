using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.AndrzejIwanski
{
    public class AndrzejIwanskiList<TListItem> : MyList<TListItem>
    {
        public override void Add(TListItem item)
        {
            if (listOfItems == null)
            {
                listOfItems = new TListItem[1];
            }

            Index++;
            TListItem[] tempList = new TListItem[Index];

            for (int i = 0; i < listOfItems.Length; ++i)
            {
                tempList[i] = listOfItems[i];
            }

            tempList[Index - 1] = item;
            listOfItems = tempList;
        }

        public TListItem GetItem(int index)
        {
            return index < Index ? listOfItems[index] : default(TListItem);
        }
    }
}