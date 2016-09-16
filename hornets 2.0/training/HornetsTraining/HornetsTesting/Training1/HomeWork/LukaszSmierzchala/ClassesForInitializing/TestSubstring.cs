using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTesting.Training1.HomeWork.LukaszSmierzchala.ClassesForInitializing
{
    public class TestSubstring
    {
        public string Candidate { get; private set; }

        public int Start { get; private set; }

        public int Length { get; private set; }

        public string Expected { get; private set; }


        public TestSubstring(string candidate, int start, int length, string expected)
        {
            Candidate = candidate;
            Start = start;
            Length = length;
            Expected = expected;
        }

    }
}
