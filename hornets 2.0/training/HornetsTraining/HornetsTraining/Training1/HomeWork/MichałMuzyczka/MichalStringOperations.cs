using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HornetsTraining.Training1.HomeWork.MichałMuzyczka
{
    public class MichalStringOperations : StringOperations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Michał Muzyczka";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidate"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public override string Substring(string candidate, int start, int length)
        {
            var result = new char[length];
            try
            {
                var index = start;
                for (int i = 0; i < length; i++)
                {
                    result[i] = candidate[index];
                    index++;
                }
                return CharArrayToString(result);
            }
            catch
            {

                return CharArrayToString(result);
            }
        }


        /// <summary>
        /// If not found, return -1
        /// </summary>
        /// <param name="candidate"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public override int PositionInString(string candidate, string needle)
        {
            if (needle.Length > candidate.Length)
                return -1;
            var subStrLength = needle.Length;
            var baseStringLength = candidate.Length;
            try
            {
                char[] subString = new char[subStrLength];
                for (int i = 0; i < baseStringLength; i++)
                {
                    for (int j = 0; j < subStrLength; j++)
                    {
                        subString[j] = candidate[i + j];
                        String temp = CharArrayToString(subString);
                        if (temp.Equals(needle, StringComparison.OrdinalIgnoreCase))
                        {
                            return i;
                        }
                    }
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }


        /// <summary>
        /// Method ignores case size 
        /// </summary>
        /// <param name="candidate"></param>
        /// <param name="needle"></param>
        /// <param name="replaceWith"></param>
        /// <returns></returns>
        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            bool antiLoop = (PositionInString(replaceWith, needle) != -1);
 
            // For example, let candidate string be "higAShi"
            var candidateLength = candidate.Length;
            // needle let be "AS"
            var needleLength = needle.Length;
            // replace let be "MAMI"
            var replaceLength = replaceWith.Length;

            var index = PositionInString(candidate, needle);
            if (index == -1)
            {
                return candidate;
            }

            var difference = replaceLength - needleLength;
            var baseArray = candidate.ToCharArray();
            var newArray = new char[baseArray.Length + difference];

            // Copy from 0 to index, after that we will have "hig..."
            for (int i = 0; i < index; i++)
            {
                newArray[i] = candidate[i];
            }

            // Now replace old string with new one, after that we will have "higMAMI..."
            var temp = index;
            for (int i = 0; i < replaceLength; i++)
            {
                newArray[temp] = replaceWith[i];
                temp++;
            }

            // And add the rest, so we will have "higMAMIhi"
            temp = index + replaceLength;
            for (int i = index + needleLength; i < candidateLength; i++)
            {
                newArray[temp] = candidate[i];
                temp++;
            }

            if (antiLoop)
            {
                 return Regex.Replace(CharArrayToString(newArray), needle, replaceWith);
            }
            return StringReplace(CharArrayToString(newArray), needle, replaceWith);
        }


        /// <summary>
        /// .Netowa funkcja toString sprowadza char[] do char[], przez co funkcja Equals wywołuje się niepoprawnie
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private string CharArrayToString(char[] array)
        {
            var result = String.Empty;
            foreach (var letter in array)
            {
                if (letter != '\0')
                    result += letter;
            }

            return result;
        }
    }
}
