using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training4.DependencyInjection;
using System.IO;

namespace Toci.HornetsTraining.Training4.HomeWork.MichalMuzyczka
{
    public class MichalMuzyczkaTeamLeasingInfoTranslation : TeamLeasingInfoTranslation
    {
        public MichalMuzyczkaTeamLeasingInfoTranslation(string language) : base(language)
        {
        }


        public override Dictionary<string, string> GetTranslations(List<string> keys)
        {
            var fileLanguage = ReadDictionary();
            var result = fileLanguage.Join(keys, x => x.Key, y => y, (x, y) => x)
                .ToDictionary(x => x.Key, x => x.Value);

            return result;
        }


        protected override Dictionary<string, string> ReadDictionary()
        {
            var content = new Dictionary<string, string>();
            var path = @"..\..\..\HornetsTraining\Training4\DependencyInjection\data\" + string.Format(FileNamePattern, Language);

            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                var line = string.Empty;
                while (string.IsNullOrEmpty(line = reader.ReadLine()))
                {
                    var temp = reader.ReadLine().Split('\t');
                    content.Add(temp[0], temp[1]);
                }
            }

            return content;
        }
    }
}

