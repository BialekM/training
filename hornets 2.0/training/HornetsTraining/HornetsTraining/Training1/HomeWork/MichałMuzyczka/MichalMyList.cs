using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.MichałMuzyczka
{
    public class MichalMyList<T> : MyList<T>
    {
        /// <summary>
        /// 
        /// </summary>
        protected T[] ListOfItems;

        /// <summary>
        /// 
        /// </summary>
        private int _index = 0;

        /// <summary>
        /// 
        /// </summary>
        private int _lastIndex = 0;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="item">Item you want to add to list</param>
        public override void Add(T item)
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
