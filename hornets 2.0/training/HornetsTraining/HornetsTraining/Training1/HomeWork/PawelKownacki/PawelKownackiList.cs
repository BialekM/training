using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.PawelKownacki
{
    public class PawelKownackiList <TListItem> : MyList<TListItem>
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
    }
}