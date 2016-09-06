using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.MarekMilosierny.Generics
{
    public class MarekList<TItemList> : MyList<TItemList>
    {
        private TItemList[] _itemList;
        private int _index = 0;

        public override void Add(TItemList item)
        {
            if (_itemList == null)
            {
                _index = 1;
                _itemList = new TItemList[_index];
                _itemList[_index - 1] = item;
            }
            else
            {
                TItemList[] newList = new TItemList[_index + 1];

                for (int i = 0; i < _index; i++)
                {
                    newList[i] = _itemList[i];
                }

                newList[_index] = item;
                _index++;
                _itemList = new TItemList[_index];

                for (int i = 0; i < _index; i++)
                {
                    _itemList[i] = newList[i];
                }
            }
        }

    }
}
 