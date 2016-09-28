using Toci.HornetsTraining.Training1.Generics;

 public class AdrianKoszykList<TListItem> : MyList<TListItem>
 {
        protected TListItem[] ListOfItems;
        protected int _index = 0;
        protected int _lastIndex=0;

        public void Add(TListItem item)
        {
            if (ListOfItems == null)
            {
                ListOfItems = new TListItem[1];
            }

            _index++;
            TListItem[] newList = new TListItem[_index];

            for (int i = 0; i < _lastIndex; i++)
            {
                newList[i] = ListOfItems[i];
            }

            newList[_index - 1] = item;
            _lastIndex++;
            ListOfItems = newList;
        }

        public TListItem GetElement(int index)
        {
            return ListOfItems[index];
        }


}