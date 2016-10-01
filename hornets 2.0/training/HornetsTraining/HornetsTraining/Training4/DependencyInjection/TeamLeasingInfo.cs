using System.Collections.Generic;

namespace Toci.HornetsTraining.Training4.DependencyInjection
{
    public class TeamLeasingInfo
    {
        protected ITeamLeasingInfoTranslation Translation;

        public TeamLeasingInfo(ITeamLeasingInfoTranslation translation)
        {
            Translation = translation;
        }

        public Dictionary<string, string> GetInfo()
        {
            return Translation.GetTranslations(new List<string>
            {
                "_klucz", "_klucz2"
            });
        }
    }
}