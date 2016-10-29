using System.Collections.Generic;
using System.Linq;

namespace SeeSharpBasics.training7.linq
{
    public class LinqTest
    {
        public void test()
        {
            string[] whatever = new string[8];
            List<string> list = new List<string>
            {
                "andrzej", "Edwin", "konrad", "marcin", "olek", "slawek"
            };
            List<int> listOfInt = new List<int>
            {
                1,2,3,4,5,6,7,8,9
            };
            var olek = list.Where(element => element == "olek").Where(m => m == "").ToArray(); // defered execution, fluent api
            //
            list.Add("olek");

            list.Where(IAmFilteringLikeLambda);

            var wynik = olek.ToList(); //2 

            var cokolwiek = listOfInt.GhostRiderWhere(m => m == 8);

            var result = listOfInt.Where(intElement => intElement == 8).ToList();
            //result.Join(olek, )
        }

        private bool IAmFilteringLikeLambda(string element) 
        {
            //return true;
            return element == "olek";
        }
    }
}