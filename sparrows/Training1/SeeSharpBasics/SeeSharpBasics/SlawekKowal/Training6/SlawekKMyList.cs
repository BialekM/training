using System.Collections;

namespace SeeSharpBasics.SlawekKowal.Training6
{
    public class SlawekKMyList<T> : IEnumerable
    {
        private T[] _list;
        private int _index = 0;

        public void Add(T adder)
        {
            T[] tempList = new T[_index + 1];
            if (_index > 0) _list.CopyTo(tempList, 0);
            tempList[_index] = adder;
            _list = tempList;
            _index++;
        }

        public T GetItem(int index)
        {
            return _list[index];
        }

        public void RemoveItem(int index)
        {
            T[] tempList = new T[_index - 1];
            int xCounter = 0;
            for (int i = 0; i < _index; i++)
            {
                if (index != i) tempList[i - xCounter] = GetItem(i);
                else xCounter += 1;
            }
            _list = tempList;
            _index--;
        }

        public int GetLenght()
        {
            return _index;
        }

        public int GetIndex(T item)
        {
            for (int i = 0; i < _index; i++)
            {
                if (_list[i].Equals(item)) return i;
            }
            return -1;
        }

        public IEnumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
