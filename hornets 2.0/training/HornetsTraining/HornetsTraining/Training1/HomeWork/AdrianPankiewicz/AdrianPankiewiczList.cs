

using System;
using System.Security.Cryptography;
using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.AdrianPankiewicz
{
    public class AdrianPankiewiczList<TListItem> : MyList<TListItem>
    {

        public AdrianPankiewiczList()
        {
            listOfItems = new TListItem[1];
        }

        public override void Add(TListItem item)
        {
            if (Index >= listOfItems.Length)
                DobubleTabSize();

            listOfItems[Index] = item;
            Index++;
        }

        public bool Empty()
        {
            return Index == 0;
        }

        private void DobubleTabSize()
        {
            EnlargeTab(2 * listOfItems.Length);
        }

        private void EnlargeTab(int newSize)
        {
            TListItem[] newlistOfItems = createTab(newSize);
            rewriteElements(listOfItems, newlistOfItems);
            listOfItems = newlistOfItems;
        }

        private TListItem[] createTab(int size)
        {
            return new TListItem[size];
        }

        private void rewriteElements(TListItem[] source, TListItem[] destination)
        {
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }

        public TListItem GetElement(int index)
        {
            return listOfItems[index];
        }
    }
}