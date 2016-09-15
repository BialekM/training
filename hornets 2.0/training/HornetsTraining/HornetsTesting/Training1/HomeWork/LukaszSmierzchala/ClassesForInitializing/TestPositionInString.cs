using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTesting.Training1.HomeWork.LukaszSmierzchala.ClassesForInitializing
{
    public class TestPositionInString
    {
        public string Candidate { get; private set; }

        public string Needle { get; private set; }

        public int Expected { get; private set; }


        public TestPositionInString(string candidate, string needle, int expected)
        {
            Candidate = candidate;
            Needle = needle;
            Expected = expected;
        }

    }
}
