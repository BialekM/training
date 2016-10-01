using System.Collections.Generic;

namespace Toci.HornetsTraining.Training4.DependencyInjection
{
    public class TeamLeasingInfoGermanTranslation : TeamLeasingInfoTranslation
    {
        public TeamLeasingInfoGermanTranslation( ) : base("de")
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