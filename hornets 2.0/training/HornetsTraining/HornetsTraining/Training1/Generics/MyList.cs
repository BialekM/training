namespace HornetsTraining.Training1.Generics
{
    public class MyList<TListItem>
    {
        protected TListItem[] listOfItems;
        protected int Index = 0;

        public virtual void Add(TListItem item)
        {
            //automatyczne rozszerzanie tablicy

            listOfItems[Index] = item;
            Index++;
        }
    }
}