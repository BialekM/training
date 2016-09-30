using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.KonradGalazka
{
    public class KonradGalazkaMyList<TlistItem> : MyList<TlistItem>
    {
        private TlistItem[] listOfItems;
        private TlistItem[] temp;
        private int Index = 0;

        public override void Add(TlistItem item)
        {
            if (listOfItems == null)
            {
                listOfItems = new TlistItem[Index];
            }

            temp = new TlistItem[listOfItems.Length +1];
            for (int i = 0; i < listOfItems.Length; i++)
            {
                temp[i] = listOfItems[i];
            }
            temp[Index] = item;
            listOfItems = temp;
            Index++;
        }
    }
}