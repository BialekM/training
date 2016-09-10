using System.Security.Cryptography;
using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.SławekNowiński
{
    class SlawekList<TListItem> : MyList<TListItem>
    {
        private TListItem[] _altList;


        public override void Add(TListItem item)
        {
            if (listOfItems == null)
            {
                Index++;
                listOfItems = new TListItem[Index];
                listOfItems[Index - 1] = item;
            }
            else
            {
                Index++;

                _altList = new TListItem[Index];

                for (int i = 0; i < Index - 1; i++)
                    _altList[i] = listOfItems[i];
                for (int i = 0; i < Index - 1; i++)
                    listOfItems[i] = _altList[i];

                listOfItems[Index - 1] = item;
            }
        }
    }
}