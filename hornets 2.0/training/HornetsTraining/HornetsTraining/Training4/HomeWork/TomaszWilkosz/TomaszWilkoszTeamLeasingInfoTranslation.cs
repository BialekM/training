using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace Toci.HornetsTraining.Training4.HomeWork.TomaszWilkosz
{
    public class TomaszWilkoszTeamLeasingInfoTranslation : TeamLeasingInfoTranslation
    {
        private string pathToFile = @"..\..\HornetsTraining\Training4\DependencyInjection\data\";
        private string pathDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public TomaszWilkoszTeamLeasingInfoTranslation(string language)
            : base(language)
        {
            FileNamePattern = String.Format(FileNamePattern, language);
            pathToFile = String.Format(pathDirectory + pathToFile + FileNamePattern);
        }

        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {

            return ReadDictionary().Where(dataToRead => keys.Contains(dataToRead.Key)).ToDictionary(x => x.Key, x => x.Value); 

        }

        protected override Dictionary<string, string> ReadDictionary()
        {

            Dictionary<string, string> outputData = new Dictionary<string, string>();
            string fileToRead = @"..\..\..\HornetsTraining\Training4\DependencyInjection\data\" + string.Format(FileNamePattern, Language);
            string[] lines = System.IO.File.ReadAllLines(fileToRead);

            foreach (string singleLine in lines)
            {
                var tempStringArray = singleLine.Split('\t');
                outputData.Add(tempStringArray[0],tempStringArray[1]);
            }

            return outputData;
        }
    }
}