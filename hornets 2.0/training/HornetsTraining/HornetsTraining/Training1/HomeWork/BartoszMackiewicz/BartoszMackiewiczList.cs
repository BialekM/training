using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.BartoszMackiewicz
{
   public class BartoszMackiewiczList<TListItems> :  MyList<TListItems>

    {
        
        public override void Add(TListItems item)
        {

            if (listOfItems == null) listOfItems = new TListItems[0];
            if (Index >= listOfItems.Length)
            {
                TListItems[] newlistOfItems = new TListItems[listOfItems.Length + 1];

                for (int i =0; i < listOfItems.Length;i++ )
                {
                    newlistOfItems[i] = listOfItems[i];
                }
                newlistOfItems[Index] = item;
                listOfItems = newlistOfItems;
                Index++;
            }
            else
            base.Add(item);
              
            

        }
    }
}
