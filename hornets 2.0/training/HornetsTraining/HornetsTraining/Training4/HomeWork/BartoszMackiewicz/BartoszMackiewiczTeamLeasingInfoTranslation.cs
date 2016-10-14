using System.Collections.Generic;
using System.IO;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace Toci.HornetsTraining.Training4.HomeWork.BartoszMackiewicz
{
    public class BartoszMackiewiczTeamLeasingInfoTranslation:TeamLeasingInfoTranslation
    {
        public BartoszMackiewiczTeamLeasingInfoTranslation(string language) : base(language)
        {
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            throw new System.NotImplementedException();
        }

        protected override Dictionary<string, string> ReadDictionary()
        {
            StreamReader lineReader = new StreamReader(path);
            
        }
    }
}