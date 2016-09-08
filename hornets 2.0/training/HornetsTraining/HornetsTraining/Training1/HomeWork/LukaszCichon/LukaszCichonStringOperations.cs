using System;

namespace HornetsTraining.Training1.HomeWork.LukaszCichon
{
    public class LukaszCichonStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Lukasz Cichon";
        }

        public override string Substring(string candidate, int start, int length)
        {
            try
            {
                if ((start <= length) && (start < candidate.Length) && (length < candidate.Length))
                {
                    string newCandidate = string.Empty;
                    for (int i = start; i <= length; i++)
                    {
                        newCandidate += candidate[i].ToString();
                    }
                    return newCandidate;
                }
                else
                {
                    throw new SystemException("Zle parametry");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
        public override int PositionInString(string candidate, string needle)
        {
            int position = 0;
            int positionNeedle = 0;

            try
            {
                for (int i = 0; i < candidate.Length; i++)
                {
                    if (candidate[i] == needle[positionNeedle])
                    {
                        positionNeedle++;
                        position = i - needle.Length + 1;

                        if (positionNeedle == needle.Length)
                        {
                            return position;
                        }
                    }
                    else
                    {
                        positionNeedle = 0;
                    }
                }
                throw new SystemException("404");
            }
            catch (Exception ex)
            {
                return Int32.Parse(ex.Message);
            }
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            int position = 0;
            string firstPart = string.Empty;
            string secondPart = string.Empty;
            string result = string.Empty;

            try
            {
                position = PositionInString(candidate, needle);
                if (position == 404)
                {
                    throw new SystemException("Nie znaleziono elementu do podmiany");
                }
                if (position == 0)
                {
                    secondPart = Substring(candidate, position + needle.Length, candidate.Length - 1);
                    return result = replaceWith + secondPart;
                }
                else
                {
                    firstPart = Substring(candidate, 0, position - 1);
                    if (position + needle.Length >= candidate.Length)
                    {
                        return result = firstPart + replaceWith;
                    }
                    else
                    {
                        secondPart = Substring(candidate, position + needle.Length, candidate.Length - 1);
                        return result = firstPart + replaceWith + secondPart;

                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}