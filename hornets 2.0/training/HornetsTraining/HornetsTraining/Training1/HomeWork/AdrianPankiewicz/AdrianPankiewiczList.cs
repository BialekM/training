

using System;
using System.Security.Cryptography;

namespace HornetsTraining.Training1.HomeWork.AdrianPankiewicz
{
    public class AdrianPankiewiczList<TListItem>
    {
        protected TListItem[] listOfItems;
        protected int numberOfElements = 0;

        public AdrianPankiewiczList()
        {
            listOfItems = new TListItem[1];
        }

        public virtual void Add(TListItem item)
        {
            if (numberOfElements >= listOfItems.Length)
                DobubleTabSize();

            listOfItems[numberOfElements] = item;
            numberOfElements++;
        }

        public bool Empty()
        {
            return numberOfElements == 0;
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