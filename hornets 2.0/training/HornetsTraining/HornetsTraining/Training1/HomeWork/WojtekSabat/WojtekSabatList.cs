using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.WojtekSabat
{
    public class WojtekSabatList<TListItem> : MyList<TListItem>
    {
        public int Length;// = Index;

        public override void Add(TListItem item)
        {
            TListItem [] tmpArray = new TListItem[Index+1];
            if (listOfItems != null)
            {
                for (int i = 0; i < Index; i++)
                    tmpArray[i] = listOfItems[i];
            }
            tmpArray[Index++] = item;
            listOfItems = tmpArray;
        }
    }
}