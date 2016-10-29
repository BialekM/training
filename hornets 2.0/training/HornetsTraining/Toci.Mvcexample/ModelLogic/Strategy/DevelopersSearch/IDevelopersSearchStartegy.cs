using Toci.Mvcexample.Models.DevelopersSearch;

namespace Toci.Mvcexample.ModelLogic.Strategy.DevelopersSearch
{
    public interface IDevelopersSearchStartegy : IModelStrategy<DevelopersSearchModel>
    {
        void SearchDevelopers(string technology, double duration, double price, double devsExperience, int devsNumber = 0);
    }
}