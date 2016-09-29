using System;
using Toci.HornetsTraining.Training1.Generics;

namespace Toci.HornetsTraining.Training1.HomeWork.LukaszCichon
{
   
    public class LukaszCichonList<TItemList> : MyList<TItemList>
    {
        TItemList[] temporary;

        public override void Add(TItemList item)
        {
            
            if (listOfItems == null)
            {
                Index++;
                listOfItems = new TItemList[Index];
                listOfItems[Index - 1] = item;
            }
            else
            {
                Index++;
                temporary = new TItemList[Index];
                for (int i = 0; i < Index - 1; i++)
                {
                    temporary[i] = listOfItems[i];
                }
                listOfItems = new TItemList[Index];
                for (int i = 0; i < Index - 1; i++)
                {
                    listOfItems[i] = temporary[i];
                }
                listOfItems[Index - 1] = item;
            }
        }


        public void Remove(TItemList item)
        {
            int check = 0;

            if (listOfItems == null)
            {
                throw new SystemException("Nie ma Listy");
            }
            else
            {
                temporary = new TItemList[Index];
                for (int i = 0; i < listOfItems.Length; i++)
                {
                    temporary[i] = listOfItems[i];
                }
                for (int i = 0; i < temporary.Length; i++)
                {
                    if (temporary[i].Equals(item))
                    {
                        check++;
                        for (int j = i; j < temporary.Length - 1; j++)
                        {
                            temporary[j] = listOfItems[j + 1];
                        }
                    }
                }
                if (check != 0)
                {
                    Index = Index - check;
                    listOfItems = new TItemList[Index];
                    for (int i = 0; i < listOfItems.Length; i++)
                    {
                        listOfItems[i] = temporary[i];
                    }
                }
                else
                {
                    throw new SystemException("Nie ma takiego elementu na liscie");
                }
            }



        }
    }
}