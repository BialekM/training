using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTraining.Training1.HomeWork.MichałMuzyczka
{
    public class MichalMyList<T>
    {
        protected T[] ListOfItems;
        private int _index = 0;
        private int _lastIndex = 0;

        public virtual void Add(T item)
        {
            var copyList = ListOfItems;

            try
            {
                if (ListOfItems == null)
                    ListOfItems = new T[1];
                _index++;
                T[] newList = new T[_index];
                for (int i = 0; i < _lastIndex; i++)
                {
                    newList[i] = this.ListOfItems[i];
                }
                newList[_index - 1] = item;
                _lastIndex++;
                ListOfItems = newList;
            }
            catch
            {
                ListOfItems = copyList;
            }
        }
    }
}
