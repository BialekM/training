using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.LukaszPopiolek
{
    public class LukaszPopiolekList<TItem> : MyList<TItem>
    {
        public LukaszPopiolekList()
        {
            listOfItems = new TItem[Index];
        }

        public override void Add(TItem item)
        {
            var lenght = this.listOfItems.Length;
            TItem[] temp = new TItem[++lenght];
            for (int i = 0; i < listOfItems.Length; i++)
            {
                temp[i] = listOfItems[i];
            }
            listOfItems = temp;
            listOfItems[lenght - 1] = item;

        }
    }
}