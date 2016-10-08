using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace Toci.HornetsTraining.Training4.HomeWork.MichalMazur
{
    public class MichalMazurTeamLeasingInfoTranslation : TeamLeasingInfoTranslation
    {
        private string pathToFile = @"..\..\..\HornetsTraining\Training4\DependencyInjection\data\";
     

        public MichalMazurTeamLeasingInfoTranslation(string language)
            : base(language)
        {
            FileNamePattern = String.Format(FileNamePattern, language);
            pathToFile = String.Format(pathToFile + FileNamePattern);
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {

            return ReadDictionary().Where(d => keys.Contains(d.Key)).ToDictionary(x => x.Key, x => x.Value);

        }

        protected override Dictionary<string, string> ReadDictionary()
        {

            return ReadLines().Select(line => line.Split('\t')).ToDictionary(keyValue => keyValue[0], keyValue => keyValue[1]);

        }



        private List<string> ReadLines()
        {
            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(pathToFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}