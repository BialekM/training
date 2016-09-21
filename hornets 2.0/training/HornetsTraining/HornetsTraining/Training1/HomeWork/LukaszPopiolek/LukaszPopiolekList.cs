using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.LukaszPopiolek
{
    public class LukaszPopiolekList<TItem> : MyList<TItem>
    {
        public LukaszPopiolekList()
        {
            listOfItems = new TItem[Index];
            Index = -1;
        }

        public override void Add(TItem item)
        {
            var lenght = this.listOfItems.Length;
            TItem[] newArray = new TItem[++lenght];
            for (int i = 0; i < lenght - 1; i++)
            {
                newArray[i] = listOfItems[i];
            }
            listOfItems = newArray;
            listOfItems[lenght - 1] = item;
            Index++;
        }

        public TItem GetElement(int index)
        {
            return index <= Index ? listOfItems[index] : default(TItem);
        }
    }
}