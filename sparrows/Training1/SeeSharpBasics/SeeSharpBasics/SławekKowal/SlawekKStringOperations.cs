namespace SeeSharpBasics.SławekKowal
{
    public class SlawekKStringOperations: StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string sub = "";
            for (int i = 0; i < length; i++) sub += candidate[i + start];
            return sub;
        }

        public override string GetName()
        {
            return "Sławek Kowal";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            throw new System.NotImplementedException();
        }

        public override int CountOccurences(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            throw new System.NotImplementedException();
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            throw new System.NotImplementedException();
        }
    }
}