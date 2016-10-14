using System;

namespace HornetsTesting.Training4.php
{
    public abstract class php
    {
        public void Test(stol stol)
        {
            
        }

        public void Test(krzeslo stol)
        {
            throw new System.NotImplementedException();
        }

        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }

    public class phpextend : php, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class stol {}
	public class krzeslo : stol {}
}