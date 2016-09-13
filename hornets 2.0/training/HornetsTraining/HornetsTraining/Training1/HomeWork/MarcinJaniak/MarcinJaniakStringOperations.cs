using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTraining.Training1.HomeWork.MarcinJaniak
{
    class MarcinJaniakStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Marcin Janiak";
        }

        public override int PositionInString(string candidate, string needle)
        {
            bool needleMatch = false;
            for (int i = 0; i < candidate.Length-needle.Length; i++)
            {
                if (candidate[i] == needle[0])
                {
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (candidate[i + j] != needle[j])
                        {
                            needleMatch = false;
                        }
                        else
                        {
                            needleMatch = true;
                        }
                    }
                    if (needleMatch)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            int firstMatch = PositionInString(candidate, needle);

            string result = Substring(candidate, 0, firstMatch)
                + replaceWith
                + Substring(candidate, firstMatch + needle.Length, candidate.Length);


            return result;
        }

        public override string Substring(string candidate, int start, int length)
        {
            //najprostsze rozwiązanie bez zwracania uwagi na to, czy start+length<=candidate.length
            string temp="";
            for (int i = start; i < length; i++)
            {
                temp += candidate[i];
            }
            return temp;
        }
    }
}
