using System.Collections.Generic;

namespace Toci.HornetsTraining.Training4.DependencyInjection
{
    public interface ITeamLeasingInfoTranslation
    {
        Dictionary<string, string> GetTranslations(List<string> keys);
    }
}