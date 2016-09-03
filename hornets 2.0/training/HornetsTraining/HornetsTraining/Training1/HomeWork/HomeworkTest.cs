using HornetsTraining.Training1.HomeWork.Adrian;
using HornetsTraining.Training1.HomeWork.BartekZapart;

namespace HornetsTraining.Training1.HomeWork
{
    public class HomeworkTest
    {
        public void TestHomework()
        {
            IStringOperations[] strOp = new StringOperations[40];

            strOp[0] = new AdrianStringOperations();
            strOp[1] = new BartekZapartStringOperations();

            foreach (var strOperation in strOp)
            {
                //strOperation.
            }
        }
    }
}