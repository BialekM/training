using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTesting.Training1.HomeWork.LukaszSmierzchala.ClassesForInitializing;

namespace HornetsTesting.Training1.HomeWork.LukaszSmierzchala.FunctionsTests
{
    public class StringOperationsFunctionsTests
    {
        public StringOperationsFunctionsTest<TestSubstring> Substring { get; private set; }

        public StringOperationsFunctionsTest<TestPositionInString> PositionInString { get; private set; }

        public StringOperationsFunctionsTest<TestStringReplace> StringReplace { get; private set; }


        public StringOperationsFunctionsTests()
        {
            Substring = new StringOperationsFunctionsTest<TestSubstring>();
            PositionInString = new StringOperationsFunctionsTest<TestPositionInString>();
            StringReplace = new StringOperationsFunctionsTest<TestStringReplace>();
        }
    }
}
