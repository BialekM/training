using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.LukaszSmierzchala
{
    public class LukaszSmiechrzalList<TListItem> : MyList<TListItem>
    {
        public TListItem this[int index]
        {
            get
            {
                return this.listOfItems[index];
            }

        }

        public override void Add(TListItem item)
        {
            if (this.listOfItems == null)
            {
                this.listOfItems = new TListItem[0];
            }

            Index += 1;
            var tempList = new TListItem[Index];

            for (int i = 0; i < this.listOfItems.Length; i++)
            {
                tempList[i] = this.listOfItems[i];
            }
            tempList[Index - 1] = item;

            this.listOfItems = tempList;
        }

    }
}
