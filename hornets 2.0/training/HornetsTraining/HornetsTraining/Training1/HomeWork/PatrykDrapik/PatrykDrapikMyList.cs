using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.PatrykDrapik
{
    public class PatrykDrapikMyList<TListItem> : MyList<TListItem>
    {
        public override void Add(TListItem item)
        {
            TListItem[] newList = new TListItem[Index + 1];

            for (int i = 0; i < Index; i++)
            {
                newList[i] = listOfItems[i];
            }

            newList[Index] = item;
            listOfItems = newList;

            Index++;
        }

        public TListItem GetElement(int index)
        {
            return listOfItems[index];
        }

        public int Count()
        {
            return Index;
        }
    }
}