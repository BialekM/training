using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.BartoszMackiewicz
{
    class BartoszMackiewiczList<TListItems> :  MyList<TListItems>

    {
        public override void Add(TListItems item)
        {
            if (Index >= listOfItems.Length)
            {
              TListItems[] newlistOfItems = new TListItems[listOfItems.Length+1];
              newlistOfItems = listOfItems;
            }
            //else
            //    (base.Add());

        }
    }
}
