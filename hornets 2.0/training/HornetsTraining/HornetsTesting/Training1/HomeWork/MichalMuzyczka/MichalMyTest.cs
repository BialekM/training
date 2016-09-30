using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training1.Generics;
using Toci.HornetsTraining.Training1.HomeWork.KrzysztofPater;
using Toci.HornetsTraining.Training1.HomeWork.MichałMuzyczka;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HornetsTesting.Training1.HomeWorkOwnTests
{
    [TestClass]
    public class MichalMyTest
    {
        [TestMethod]
        public void AddToListTest()
        {
            var target = getTarget();
            target.Add(1); 
            target.Add(2); 
            target.Add(3); 
            target.Add(999);
            target.Add(5); 
            target.Add(5); 
        }


        public MyList<int> getTarget()
        {
            return new MichalMyList<int>();
        }
    }
}
