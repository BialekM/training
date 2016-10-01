using System.Collections.Generic;

namespace Toci.HornetsTraining.Training1.Generics
{
    public class GenericsExample
    {
        public void Test()
        {
            MyList<int> myListOofInt = new MyList<int>();
            MyList<string> myListOfString = new MyList<string>();

            MyList<GenericsExample> genExList = new MyList<GenericsExample>();

            List<int> wlasciwa = new List<int>();


            wlasciwa.Add(8);

            myListOofInt.Add(8);
        }
    }
}