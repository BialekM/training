using System.Collections.Generic;

namespace Toci.HornetsTraining.Training4.DependencyInjection
{
    public abstract class TeamLeasingInfoTranslation : ITeamLeasingInfoTranslation
    {
        protected string Language;
        protected string FileNamePattern = "TeamLeasingInfoTranslation.{0}.txt";

        protected TeamLeasingInfoTranslation(string language)
        {
            Language = language;
        }

        public abstract Dictionary<string, string> GetTranslations(List<string> keys); // dla listy kluczy zwraca liste translacji

        protected abstract Dictionary<string, string> ReadDictionary(); // otwiera plik dla jezyka i zwraca wszystkie translacje
    }
}