using System;
using HornetsTraining.Training1.Generics;

namespace HornetsTraining.Training1.HomeWork.LukaszCichon
{
   
    public class LukaszCichonList<TItemList> : MyList<TItemList>
    {
        private TItemList[] _itemList;
        private int _index = 0;

        public override void Add(TItemList item)
        {
            TItemList[] temporary;

            if (_itemList == null)
            {
                _index++;
                _itemList = new TItemList[_index];
                _itemList[_index - 1] = item;
            }
            else
            {
                _index++;
                temporary = new TItemList[_index];
                for (int i = 0; i < _index - 1; i++)
                {
                    temporary[i] = _itemList[i];
                }
                _itemList = new TItemList[_index];
                for (int i = 0; i < _index - 1; i++)
                {
                    _itemList[i] = temporary[i];
                }
                _itemList[_index - 1] = item;
            }
        }


        public void Remove(TItemList item)
        {
            TItemList[] temporary;
            int check = 0;
            try
            {
                if (_itemList == null)
                {
                    throw new SystemException("Nie ma Listy");
                }
                else
                {
                    temporary = new TItemList[_index];
                    for (int i = 0; i < _itemList.Length; i++)
                    {
                        temporary[i] = _itemList[i];
                    }
                    for (int i = 0; i < temporary.Length; i++)
                    {
                        if (temporary[i].Equals(item))
                        {
                            check++;
                            for (int j = i; j < temporary.Length - 1; j++)
                            {
                                temporary[j] = _itemList[j + 1];
                            }
                        }
                    }
                    if (check != 0)
                    {
                        _index = _index - check;
                        _itemList = new TItemList[_index];
                        for (int i = 0; i < _itemList.Length; i++)
                        {
                            _itemList[i] = temporary[i];
                        }
                    }
                    else
                    {
                        throw new SystemException("Nie ma takiego elementu na liscie");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}