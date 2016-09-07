namespace HornetsTraining.Training1.HomeWork.RafalKawalerski
{
    public class RafalKawalerskiStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Rafal Kawalerski";
        }

        public override string Substring(string candidate, int start, int length)
        {
            var text = "";
            if (candidate.Length - start < length)
                return "Za duza wartosc length";
            for (int i = start; i < start + length; i++)
                text += candidate[i];
            
            return text;
        }

        public override int PositionInString(string candidate, string needle)
        {
            var position; 
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            throw new System.NotImplementedException();
        }
    }
}