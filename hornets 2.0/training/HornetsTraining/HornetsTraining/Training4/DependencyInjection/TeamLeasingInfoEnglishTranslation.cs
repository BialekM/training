using System.Collections.Generic;

namespace Toci.HornetsTraining.Training4.DependencyInjection
{
    public class TeamLeasingInfoEnglishTranslation : TeamLeasingInfoTranslation
    {
        public TeamLeasingInfoEnglishTranslation() : base("en")
        {
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            return null;
        }

        protected override Dictionary<string, string> ReadDictionary()
        {
            throw new System.NotImplementedException();
        }
    }
}