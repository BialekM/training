namespace HornetsTraining.Training1.HomeWork.LukaszPopiolek
{
    public class LukaszPopiolekStringOperations : StringOperations
    {
        private string _name;

        public LukaszPopiolekStringOperations()
        {
            //_name = UniversalGetName();
            _name = "Lukasz Popiolek";
        }


        public override string GetName()
        {
            return _name;
        }


        public override string Substring(string candidate, int start, int lenght)
        {
            string result = string.Empty;
            int position;
            if ((start + lenght) <= candidate.Length)
            {
                position = (start + lenght);
            }
            else
            {
                position = candidate.Length;
            }
            for (int i = start; i < position; i++)
            {
                result += candidate[i];
            }
            return result;
        }


        public override int PositionInString(string candidate, string needle)
        {
            int result = -1;
            if (candidate.Length <= needle.Length)
            {
                if (candidate == needle)
                {
                    return 0;
                }
                return result;
            }
            else
            {
                for (int i = 0; i <= (candidate.Length - needle.Length); i++)
                {
                    var test = Substring(candidate, i, needle.Length);
                    if (Substring(candidate, i, needle.Length) == needle)
                    {
                        return i;
                    }
                }
            }
            return result;
        }


        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string result = string.Empty;
            int position, index = 0;
            do
            {
                position = PositionInString(candidate, needle);
                if (position != -1)
                {
                    result += Substring(candidate, index, position) + replaceWith;
                    candidate = Substring(candidate, position + needle.Length, candidate.Length);
                    index = position + needle.Length;
                }
                else
                {
                    result += candidate;
                }
            } while ((position != -1));
            return result;
        }   


        private string UniversalGetName()
        {
            string result = string.Empty;
            int auxiliaryIndex = 0;
            var className = this.GetType().Name;
            className = Substring(className, 0, PositionInString(className, "StringOperations"));
            for (int i = 1; i < className.Length; i++)
            {
                if (char.IsUpper(className[i]))
                {
                    result += Substring(className, auxiliaryIndex, i) + " ";
                    auxiliaryIndex = i;
                }
            }
            result += Substring(className, auxiliaryIndex, className.Length);
            return result;
        }

    }
}
