using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTraining.Training1.HomeWork;

namespace HornetsTesting.Training1.HomeWork.LukaszSmierzchala.FunctionsTests
{
    public class StringOperationsFunctionsTest<TVariables> : BaseFunctionTest<StringOperations, List<TVariables>, Func<StringOperations, TVariables, bool>>
    {
        public override void Test(StringOperations instance, List<TVariables> functionVariables, Func<StringOperations, TVariables, bool> functionDelegate)
        {
            foreach (TVariables variables in functionVariables)
            {
                functionDelegate(instance, variables);
            }
        }
    }
}
