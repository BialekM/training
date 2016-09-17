using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.WojtekSabat
{
    public class WojtekSabatList<TListItem> : MyList<TListItem>
    {
        public int Length => Index;

        public override void Add(TListItem item)
        {
            TListItem [] tmpArray = new TListItem[++Index];
            tmpArray[Index-1] = item;
            listOfItems = tmpArray;
        }
    }
}