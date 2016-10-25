using System;
using Toci.Mvcexample.Models.DBContext;

namespace Toci.Mvcexample.Ntier.Dal
{
    public abstract class DataAccessLayer : IDisposable
    {
        protected readonly TeamLeasingDBContext TeamLeasingDb;

        protected DataAccessLayer()
        {
            TeamLeasingDb = new TeamLeasingDBContext();
        }

        public void Dispose()
        {
            TeamLeasingDb.Dispose();
        }
    }
}