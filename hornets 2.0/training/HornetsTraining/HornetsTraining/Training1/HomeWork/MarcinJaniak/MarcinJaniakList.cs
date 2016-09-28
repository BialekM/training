using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.MarcinJaniak
{
    class MarcinJaniakList<TListItem> : MyList<TListItem>
    {

        public override void Add(TListItem item)
        {
            if (listOfItems == null)
            {
                listOfItems = new TListItem[0];
            }
            Index += 1;
            var tempList = new TListItem[Index];
            for (int i = 0; i < listOfItems.Length; i++)
            {
                tempList[i] = listOfItems[i];
            }
            tempList[Index - 1] = item;
            listOfItems = tempList;
        }
    }
}
