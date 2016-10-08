using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace Toci.HornetsTraining.Training4.HomeWork.LukaszCichon
{
    public class LukaszCichonTeamLeasingInfoTranslation : TeamLeasingInfoTranslation
    {
        public LukaszCichonTeamLeasingInfoTranslation(string language) : base(language)
        {
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            var fileLanguage = ReadDictionary();
            var translationDictionary = fileLanguage.Join(keys, x => x.Key, y => y, (x, y) => x).ToDictionary(x=> x.Key, x=> x.Value);

            return translationDictionary;
        }

        protected override Dictionary<string, string> ReadDictionary()
        {
            Dictionary<string, string> fileLanguage = new Dictionary<string, string>();

            string path = @"..\..\..\HornetsTraining\Training4\DependencyInjection\data\" + string.Format(FileNamePattern, Language);

            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lineSplit = line.Split('\t');
                    fileLanguage.Add(lineSplit[0], lineSplit[1]);
                }
            }

            return fileLanguage;
        }
    }
}