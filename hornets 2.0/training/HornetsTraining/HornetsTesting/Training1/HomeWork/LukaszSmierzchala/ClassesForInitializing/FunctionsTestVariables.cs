using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTesting.Training1.HomeWork.LukaszSmierzchala.ClassesForInitializing
{
    public class FunctionsTestVariables
    {
        public List<TestSubstring> Substring { get; private set; }

        public List<TestPositionInString> PositionInString { get; private set; }

        public List<TestStringReplace> StringReplace { get; private set; }


        public FunctionsTestVariables()
        {
            Substring = SetSubstringVariables();
            PositionInString = SetPositionInStringVariables();
            StringReplace = SetStringReplaceVariables();
        }

        private List<TestSubstring> SetSubstringVariables()
        {
            var substringVars = new List<TestSubstring>
            {
                new TestSubstring("trala", 1, 2, "ra"),
                new TestSubstring("trala", 2, 2, "al")
            };

            return substringVars;
        }

        private List<TestPositionInString> SetPositionInStringVariables()
        {
            var positionInStringVars = new List<TestPositionInString>
            {
                new TestPositionInString("omfgWhatsgoingonhere", "What", 4),
                new TestPositionInString("omfgWhatsgoingonhere", "at", 6),
            };

            return positionInStringVars;
        }

        private List<TestStringReplace> SetStringReplaceVariables()
        {
            var positionInStringVars = new List<TestStringReplace>
            {
                new TestStringReplace("omfgWhatsgoingonhere", "What", "xx", "omfgxxsgoingonhere"),
                new TestStringReplace("omfgWhatsgoingonhere", "at", "XXX", "omfgWhXXXsgoingonhere"),
            };

            return positionInStringVars;
        }
    }
}
