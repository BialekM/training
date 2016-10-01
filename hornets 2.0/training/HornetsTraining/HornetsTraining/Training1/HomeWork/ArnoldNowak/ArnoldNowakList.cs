using System.Diagnostics;
using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.ArnoldNowak
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
            Index++;
            System.Array.Resize(ref listOfItems, (listOfItems.Length+1));
            listOfItems[Index] = item;
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