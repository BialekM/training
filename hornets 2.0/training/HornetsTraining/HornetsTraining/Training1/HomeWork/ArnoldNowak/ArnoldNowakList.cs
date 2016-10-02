using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.ArnoldNowak
{
    public class ArnoldNowakList<TListItem>:MyList<TListItem>
    {
        public ArnoldNowakList()
        {
            Index = 0;
            listOfItems = new TListItem[Index];
        } 
        public new void Add(TListItem item)
        {
            System.Array.Resize(ref listOfItems, (listOfItems.Length+1));
            listOfItems[Index] = item;
            Index++;
        }

        public TListItem GetElement(int index)
        {
            return listOfItems[index];
        }

        public void EraseList()
        {
            listOfItems = null;
        }

        public void CleanList()
        {
            listOfItems = new TListItem[Index];
        }
    }
}