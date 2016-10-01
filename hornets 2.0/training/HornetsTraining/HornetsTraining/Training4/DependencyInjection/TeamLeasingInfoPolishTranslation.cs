using System.Collections.Generic;

namespace Toci.HornetsTraining.Training4.DependencyInjection
{
    public class TeamLeasingInfoPolishTranslation : TeamLeasingInfoTranslation
    {
        public TeamLeasingInfoPolishTranslation( ) : base("pl")
        {
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            throw new System.NotImplementedException();
        }

        protected override Dictionary<string, string> ReadDictionary()
        {
            throw new System.NotImplementedException();
        }
    }
}