using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace Toci.HornetsTraining.Training4.HomeWork.MarcinJaniak
{
    public class MarcinJaniakTeamLeasingInfoTranslation : TeamLeasingInfoTranslation
    {
        protected string FileNamePattern = "TeamLeasingInfoTranslation.{0}.txt";

        public MarcinJaniakTeamLeasingInfoTranslation(string language) : base(language)
        {

        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            var translations = ReadDictionary();
            var result = translations.Join(keys, d => d.Key, x => x, (a, b) => a)
                                     .ToDictionary(x => x.Key, x => x.Value);
            return result;
        }

        protected override Dictionary<string, string> ReadDictionary()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/Training4/DependencyInjection/data/"
      + string.Format(FileNamePattern, Language);

            StreamReader sr = new StreamReader(filePath);
  
            var result = new Dictionary<string, string>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
               var arr =  line.Split('\t');
               result.Add(arr[0], arr[1]);
            }
            return result;
        }
    }

}