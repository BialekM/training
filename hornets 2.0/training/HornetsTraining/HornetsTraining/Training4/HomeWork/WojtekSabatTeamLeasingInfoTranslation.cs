using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace Toci.HornetsTraining.Training4.HomeWork
{
    public class WojtekSabatTeamLeasingInfoTranslation : TeamLeasingInfoTranslation
    {
        protected const string FileLocalizationPath = @"../../../HornetsTraining\Training4\DependencyInjection\data\";

        public WojtekSabatTeamLeasingInfoTranslation(string language) : base(language)
        {
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            var dict = ReadDictionary();
            var keyValuePairs = keys.Select(k => new KeyValuePair<string, string>(k, dict[k]));
            return keyValuePairs.ToDictionary(p => p.Key, p => p.Value);
        }

        protected override Dictionary<string, string> ReadDictionary()
        {
            var path = FileLocalizationPath + GetFileName();
            return GetDictionaryFromFile(path);
        }

        protected string GetFileName() 
        {
            return string.Format(FileNamePattern, Language);
        }

        protected Dictionary<string, string> GetDictionaryFromFile(string filePath)
        {
            var keysTranslationsDict = new Dictionary<string,string>();

            using (var streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var splitedKeyValueArray = line.Split("\t".ToCharArray());
                    keysTranslationsDict.Add(splitedKeyValueArray[0], splitedKeyValueArray[1]);
                }
            }
            return keysTranslationsDict;
        }
    }
}