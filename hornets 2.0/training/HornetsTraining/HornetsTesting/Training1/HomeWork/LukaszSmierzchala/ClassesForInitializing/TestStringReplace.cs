using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTesting.Training1.HomeWork.LukaszSmierzchala.ClassesForInitializing
{
    public class TestStringReplace
    {
        public string Candidate { get; private set; }

        public string Needle { get; private set; }

        public string ReplaceWith { get; private set; }

        public string Expected { get; private set; }


        public TestStringReplace(string candidate, string needle, string replaceWith, string expected)
        {
            Candidate = candidate;
            Needle = needle;
            ReplaceWith = replaceWith;
            Expected = expected;
        }
    }
}
