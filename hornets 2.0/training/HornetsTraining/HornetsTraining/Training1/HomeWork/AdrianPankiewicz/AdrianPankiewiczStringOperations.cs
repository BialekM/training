
using System;
using System.Management.Instrumentation;

namespace HornetsTraining.Training1.HomeWork.AdrianPankiewicz
{

    public class AdrianPankiewiczStringOperations : StringOperations
    {
        public const string AdrianPankiewiczString = "Adrian Pankiewicz";

        public override string GetName()
        {
            return AdrianPankiewiczString;
        }

        public override string Substring(string candidate, int start, int length)
        {
            string substring = "";

            for (int i = start; i < start + length; i++)
            {
                substring += candidate[i];
            }

            return substring;
        }

        public override int PositionInString(string candidate, string needle)
        {
           // for (int i = 0; i < candidate.Length; i++)
           //     if (SubstringStartsOnIndex(candidate, needle, i))
//                    return i;

            for (int i = 0; i < candidate.Length; i++)
            {
                if (needle == Substring(candidate, i, needle.Length))
                {
                    return i;
                }
            }

            return -1;
        }

        //Zrobiłeś błąd, powinno być Beginning (nie Begining) :)
        public string GlueBeginingEnd(string candidate)
        {
            string glueBeginningEnd = "";
            int leftIndex = 0;
            int rightIndex = candidate.Length - 1;

            while (leftIndex < rightIndex)
            {
                glueBeginningEnd += candidate[leftIndex];
                glueBeginningEnd += candidate[rightIndex];
                leftIndex++;
                rightIndex--;
            }

            return glueBeginningEnd;
        }

        public int CountOccurences(string candidate, char needle)
        {
            int occurences = 0;

            foreach (char t in candidate)
                if (t == needle)
                    occurences++;

            return occurences;
        }

        public int LetterPositionInString(string candidate, char needle)
        {
            for (int i = 0; i < candidate.Length; i++)
                if (candidate[i] == needle)
                    return i;

            throw new InstanceNotFoundException();
        }

        public string LetterReplace(string candidate, char needle, char replace)
        {
            string lettersReplace = "";

            foreach (char t in candidate)
                if (t == needle)
                    lettersReplace += replace;
                else
                    lettersReplace += t;

            return lettersReplace;
        }


        public override string StringReplace(string candidate, string needle, string replace)
        {
            string stringReplace = "";
            int substringPosition = PositionInString(candidate, needle);
            bool subStringExists = substringPosition > 0;

            while (subStringExists)
            {
                stringReplace = ReplaceOneOccurence(candidate, needle, replace, substringPosition);
                substringPosition = PositionInString(stringReplace, needle);
                subStringExists = substringPosition > 0;
            }

            return stringReplace;
        }

        private string ReplaceOneOccurence(string candidate, string needle, string replace, int substringPosition)
        {
            string stringReplace = "";

            stringReplace = Erase(candidate, substringPosition, needle.Length);
            stringReplace = Insert(stringReplace, replace, substringPosition);

            return stringReplace;
        }

        private bool SubstringStartsOnIndex(string candidate, string needle, int index)
        {
            for (int candidateIndex = index, needleIndex = 0; candidateIndex < index + needle.Length; candidateIndex++, needleIndex++)
            {
                if (!(EqualLetterInRange(candidate, needle, candidateIndex, needleIndex)))
                    return false;
            }

            return true;
        }

        private bool EqualLetterInRange(string candidate, string needle, int candidateIndex, int needleIndex)
        {
            return (InRange(candidate, candidateIndex) && InRange(needle, needleIndex)
                && EqualLetter(candidate, needle, candidateIndex, needleIndex));
        }

        private bool InRange(string candidate, int index)
        {
            return index >= 0 && index < candidate.Length;
        }

        private bool EqualLetter(string candidate, string needle, int candidateIndex, int needleIndex)
        {
            return candidate[candidateIndex] == needle[needleIndex];
        }

        private string Erase(string toErase, int from, int length)
        {
            string erased = "";

            for (int i = 0; i < toErase.Length; i++)
                if (!(isValueBetween(i, from, from + length - 1)))
                    erased += toErase[i];

            return erased;
        }

        private bool isValueBetween(int value, int firstBound, int secondBound)
        {
            //if (firstBound > secondBound)
            //    GenericMethodsCollection<int>.Swap(ref firstBound, ref secondBound);

            return value >= firstBound && value <= secondBound;
        }

        private string Insert(string toInsert, string needle, int startIndex)
        {
            string inserted = "";

            inserted = addAtEnd(inserted, Substring(toInsert, 0, startIndex));
            inserted = addAtEnd(inserted, needle);
            inserted = addAtEnd(inserted, Substring(toInsert, startIndex, toInsert.Length - startIndex));

            return inserted;
        }

        private string addAtEnd(string toModify, string needle)
        {
            toModify += needle;
            return toModify;
        }
    }
}
