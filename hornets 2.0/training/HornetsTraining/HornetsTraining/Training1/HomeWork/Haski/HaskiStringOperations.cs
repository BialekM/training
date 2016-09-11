using System;

namespace HornetsTraining.Training1.HomeWork.Haski {
    public class HaskiStringOperations : StringOperations {
        public override string GetName() {
            return "Haski";
        }

        public override string Substring(string candidate, int start, int length) {
            string resoult = "";
            for (int i = start; i < start + length; i++)
            {
                resoult += candidate[i];
            }
            return resoult;
        }

        /// <summary>
        /// return -1 when nothing is found
        /// </summary>
        /// <param name="candidate"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public override int PositionInString(string candidate, string needle) {
            for (int i = 0, correctCounter = 0; i < candidate.Length; i++) {
                if (candidate[i] != needle[correctCounter]) correctCounter = 0;
                else {
                    correctCounter++;
                    if (correctCounter == needle.Length) return i - needle.Length + 1;
                }
            }
            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith) {
            int index = PositionInString(candidate, needle);
            if (index == -1) return candidate;
            return candidate.Remove(index, needle.Length).Insert(index, replaceWith);
        }
    }
}