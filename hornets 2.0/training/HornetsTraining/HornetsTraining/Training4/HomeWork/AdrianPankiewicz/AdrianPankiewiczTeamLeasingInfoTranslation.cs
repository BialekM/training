using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Xml;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace Toci.HornetsTraining.Training4.HomeWork
{
    public class AdrianPankiewiczTeamLeasingInfoTranslation : TeamLeasingInfoTranslation
    {

        public AdrianPankiewiczTeamLeasingInfoTranslation(string language) : base(language)
        {
             
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            Dictionary<string, string> translations = ReadDictionary();
            Dictionary<string, string> listOrdererTranslations = new Dictionary<string, string>();

            keys.ForEach( (key) => listOrdererTranslations.Add(key, translations[key]));
            return listOrdererTranslations;
        }

        protected override Dictionary<string, string> ReadDictionary()
        {
            return TeamLeasingFileReader.ReadDictionary(String.Format(FileNamePattern, Language));
        }

    }
}