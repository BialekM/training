using System;
using System.Collections.Generic;
using System.IO;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace Toci.HornetsTraining.Training4.HomeWork.LukaszPopiolek
{
    public class LukaszPopiolekTeamLeasingInfoTranslation : TeamLeasingInfoTranslation
    {
        private static string _path = @"..\..\..\HornetsTraining\Training4\DependencyInjection\data\";
        public LukaszPopiolekTeamLeasingInfoTranslation(string language) : base(language)
        {
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            var temp = ReadDictionary();
            foreach (var element in keys)
            {
            }
            return ReadDictionary();
        }

        protected override Dictionary<string, string> ReadDictionary()
        {

            Dictionary<string,string> _dictionary = new Dictionary<string, string>();
            foreach (var line in File.ReadAllLines(_path + string.Format(FileNamePattern, Language)))
            {
                var temp = line.Split('\t');
                _dictionary.Add(temp[0], temp[1]);
            }
            return _dictionary;
        }
    }
}