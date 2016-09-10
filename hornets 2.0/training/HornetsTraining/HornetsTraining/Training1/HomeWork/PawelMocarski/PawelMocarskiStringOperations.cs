using System;

namespace HornetsTraining.Training1.HomeWork.PawelMocarski
{
    public class PawelMocarskiStringOperations : StringOperations
    {
        public override string GetName() => "Pawel Mocarski";



        public override string Substring(string candidate, int start, int length)
        {
            if (string.IsNullOrEmpty(candidate)) throw new ArgumentException("candidate", "String is null or empty");
            if (start > candidate.Length - 1 || start < 0) throw new ArgumentException("start", "Parameter is not valid");
            if (start + length - 1 > candidate.Length || length <= 0) throw new ArgumentException("length", "Parameter is not valid");

            var characters = new char[length];

            for (var i = 0; i < length; i++)
                characters[i] = candidate[start++];

            return new string(characters);
        }


        public override int PositionInString(string candidate, string needle)
        {
            if (string.IsNullOrEmpty(candidate)) throw new ArgumentException("candidate", "String is null or empty");
            if (string.IsNullOrEmpty(needle)) throw new ArgumentException("needle", "String is null or empty");
            if (needle.Length > candidate.Length) throw new ArgumentException("needle", "Needle length can't be greater than candidate length");


            for (var i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] != needle[0]) continue;

                if (i + needle.Length > candidate.Length) break;

                for (var j = 1; j < needle.Length; j++)
                {
                    if (candidate[i + j] == needle[j])
                    {
                        if (j == needle.Length - 1)
                            return i;
                    }
                }
            }

            return -1;
        }



        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            if (replaceWith == null) throw new ArgumentNullException("replaceWith", "Parameter can't be null");

            var startPosition = PositionInString(candidate, needle);
            if (startPosition == -1) throw new ArgumentException("needle", "String does not contain requested substring");

            var part1 = string.Empty;
            if (startPosition > 0)
                part1 = Substring(candidate, 0, startPosition);

            var part2 = string.Empty;
            if (startPosition + 1 + needle.Length <= candidate.Length)
                part2 = Substring(candidate, startPosition + needle.Length, candidate.Length - (startPosition + needle.Length));

            return part1 + replaceWith + part2;
        }





    }
}
