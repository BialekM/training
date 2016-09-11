using System;
using System.Collections.Generic;
using HornetsTraining.Training1.HomeWork;
using HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using HornetsTraining.Training1.HomeWork.BartoszMackiewicz;
using HornetsTraining.Training1.HomeWork.Haski;
using HornetsTraining.Training1.HomeWork.KrzysztofPater;
using HornetsTraining.Training1.HomeWork.MichałMuzyczka;
using HornetsTraining.Training1.HomeWork.PatrykDrapik;
using HornetsTraining.Training1.HomeWork.PawelKownacki;
using HornetsTraining.Training1.HomeWork.PawelMocarski;
using HornetsTraining.Training1.HomeWork.SławekNowiński;
using HornetsTraining.Training1.HomeWork.ŁukaszŚmierzchała;

namespace HornetsTraining.Training2.Delegates
{
    public class DelegateExample
    {
        //public delegate int PositionInStringDelegate(string candidate, string needle);
        public delegate TResult PositionInStringDelegate<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

        public Func<string, string, int> Example;

        public PositionInStringDelegate<string, string, int> PositionDelegates;

        public void TestPositionInStringByAll()
        {
            List<StringOperations> listOfOperations = new List<StringOperations>
            {
                new AdrianPankiewiczStringOperations(),
                new BartoszMackiewiczStringOperations(),
                new HaskiStringOperations(),
                new KrzysztofPaterStringOperations(),
                new LukaszSmierzchalaStringOperations(),
                new MichalStringOperations(),
                new PatrykDrapikStringOperations(),
                new PawelKownackiStringOperations(),
                new PawelMocarskiStringOperations(),
                new SlawekStringOperation()
            };

            foreach (var operation in listOfOperations)
            {
                PositionDelegates += operation.PositionInString;
            }

            PositionDelegates += Position;

            PositionDelegates("beatka", "eat");
        }

        private int Position(string dupa, string needle)
        {
            return -1;
        }
    }
}