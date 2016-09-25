using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.PawelMarciniak
{
    public class PawelMarciniakMyList<TListItem> : MyList<TListItem>
    {
        public override void Add(TListItem item)
        {
            if (listOfItems.Length == 0)
            {
                listOfItems[0] = item;
            }
            else
            {
                TListItem[] newList = new TListItem[Index + 1];

                for ( int i = 0; i <= Index; i++)
                {
                    newList[i] = listOfItems[i];
                }

                newList[Index + 1] = item;
                listOfItems = newList;
            }

            Index++;
        }

        public TListItem GetElem(int index)
        {
            return listOfItems[index];
        }
    }
}