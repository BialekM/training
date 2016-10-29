using System;
using System.Linq;
using Toci.Mvcexample.Models.DBContext;

namespace Toci.Mvcexample.Ntier.Dal.Interfaces
{
    public interface IDevelopersSearchDal
    {
        IQueryable<developer> GetDevelopers(DateTime expFrom, double perHourCost, string technology);
    }
}