using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.SlawekKowal
{
    public class SlawekKMyList<TListItem> : MyList<TListItem>
    {
        public override void Add(TListItem item)
        {
            TListItem[] tempList = new TListItem[Index + 1];
            if (Index == 0)
            {
                tempList[0] = item;
            }
            else
            {
                for (int i = 0; i < listOfItems.Length; i++)
                {
                    tempList[i] = listOfItems[i];
                }
                tempList[Index] = item;
            }
            Index++;
            listOfItems = tempList;
        }

        public TListItem GetItem(int index)
        {
            return listOfItems[index];
        }
    }
}