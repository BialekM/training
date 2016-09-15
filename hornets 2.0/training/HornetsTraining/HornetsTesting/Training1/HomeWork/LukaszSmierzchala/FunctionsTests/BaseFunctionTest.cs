using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTesting.Training1.HomeWork.LukaszSmierzchala.FunctionsTests
{
    public abstract class BaseFunctionTest<TInstance, TFunctionVariables, TFunctionDelegate>
    {
        public abstract void Test(TInstance instance, TFunctionVariables functionVariables, TFunctionDelegate functionDelegate);
    }
}
