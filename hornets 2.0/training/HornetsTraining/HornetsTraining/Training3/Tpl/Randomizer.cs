using System;
using System.IO;

namespace Toci.HornetsTraining.Training3.Tpl
{
    public class Randomizer : IDisposable
    {
        private static object _lock = new object();

        StreamWriter strWr;

        public Randomizer()
        {
            strWr = new StreamWriter(@"C:\self\toci\software\sourcetree\training\hornets 2.0\training\HornetsTraining\HornetsTraining\Training3\Tpl\txt\1.txt", true);
        }

        public int GetRandomNumber()
        {
            Random r = new Random(DateTime.Now.Millisecond);

            return r.Next(10000, 9999999);
        }

        public void Save()
        {
            lock (_lock)
            {
                strWr.WriteLine(GetRandomNumber());
            }
        }

        public void Dispose()
        {
            strWr.Close();
        }
    }
}