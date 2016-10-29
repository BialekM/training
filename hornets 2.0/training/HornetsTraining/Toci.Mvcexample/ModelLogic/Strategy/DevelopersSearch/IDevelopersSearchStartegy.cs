namespace Toci.Mvcexample.ModelLogic.Strategy.DevelopersSearch
{
    public interface IDevelopersSearchStartegy
    {
        void SearchDevelopers(string technology, double duration, double price, int devsNumber = 0);
    }
}