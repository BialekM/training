using System;
using System.Collections.Generic;
using System.IO;

namespace Toci.HornetsTraining.Training4.HomeWork
{
    public static class TeamLeasingFileReader
    {
        private const string DataRelativePath = @"..\..\..\HornetsTraining\Training4\DependencyInjection\data\";

        public static Dictionary<string, string> ReadDictionary(string fileName)
        {
            Dictionary<string, string> keysWithTranslations = new Dictionary<string, string>();

            using (StreamReader file = new StreamReader(CreateFilePath(fileName)))
            {
                while (!(file.EndOfStream))
                {
                    var keyValuePair = CreateKeyValuePair(file.ReadLine());
                    keysWithTranslations.Add(keyValuePair.Key, keyValuePair.Value);
                }
            }

            return keysWithTranslations;
        }

        private static string CreateFilePath(string fileName)
        {
            return DataRelativePath + fileName;
        }


        private static KeyValuePair<string, string> CreateKeyValuePair(string wholeLine)
        {
            int i = 0;
            while (wholeLine[i] != ' ' && wholeLine[i] != '\t')
                i++;

            string key = wholeLine.Substring(0, i);
            i++;
            string value = wholeLine.Substring(i, wholeLine.Length - 1 - key.Length);

            return new KeyValuePair<string, string>(key, value);
        }

    }
}