using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.BartekZapart
{
    public class BartekZapartStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            //return base.Substring(candidate, start, length);
            // wasze cialo metody
            return "";
        }

        public override string GetName()
        {
            return "Bartek Zapart";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            throw new NotImplementedException();
        }

        public override int CountOccurences(string candidate, char needle)
        {
            throw new NotImplementedException();
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            throw new NotImplementedException();
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            throw new NotImplementedException();
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            throw new NotImplementedException();
        }

        public void AdrianPankiewicz(string test)
        {
            
        }
    }
}
