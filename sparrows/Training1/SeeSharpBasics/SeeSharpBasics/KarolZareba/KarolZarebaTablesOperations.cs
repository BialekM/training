﻿using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.KarolZareba
{
    public class KarolZarebaTablesOperations : TableOperations
    {
        public int[] GetElemenInts(int[] table, int greaterThan) //table = 1,2,3,4,5,6,7,8,9 gratherThan = 5-> 6,7,8,9
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] > greaterThan)
                {
                    //dodajemy do wynikowej tablicy
                }
            }

            return null;
        }

        public override int[] BubbleSort(int[] tableToSort)
        {
            throw new System.NotImplementedException();
        }
    }
}