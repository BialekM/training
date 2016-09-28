using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.HornetsTraining.Training1.HomeWork.LukaszSmierzchala
{
    public class LukaszSmierzchalaStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Łukasz Śmierzchała";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string substring = String.Empty;

            if (start < 0 ||
                start >= candidate.Length)
            {
                throw new ArgumentOutOfRangeException("start");
            }

            if (length <= 0 ||
                length + start > candidate.Length)
            {
                throw new ArgumentOutOfRangeException("length");
            }

            for (int i = start; i < start + length; i++)
            {
                substring += candidate[i];
            }

            return substring;

        }

        public override int PositionInString(string candidate, string needle)
        {
            string substring = String.Empty;

            for (int i = 0; i < candidate.Length; i++)
            {
                try
                {
                    substring = this.Substring(candidate, i, needle.Length);
                }
                catch (ArgumentOutOfRangeException)
                {
                    //throw new ArgumentException("substring was not found", nameof(needle));
                    return -1;
                }

                if (needle == substring)
                {
                    return i;
                }
            }

            return -1;
            // throw new ArgumentException("substring was not found", nameof(needle));
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            int startPosition;
            string result;

            //try
            //{
            //    startPosition = this.PositionInString(candidate, needle);
            //}
            //catch (ArgumentException x)
            //{
            //    Console.WriteLine(x.Message);
            //    throw;
            //}

            startPosition = this.PositionInString(candidate, needle);

            if (startPosition == -1)
            {
                return candidate;
            }

            result = this.Substring(candidate, 0, startPosition);  // blablabla , bla, ble => bleblabla
            result += replaceWith;
            for (int i = startPosition + needle.Length; i < candidate.Length; i++)
            {
                result += candidate[i];
            }

            return result;

        }
    }
}
