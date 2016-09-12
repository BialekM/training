using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.TomaszKilian
{
    public class TomaszKilianStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string wynikowa = "";
            for (int i = start; i <= length ; i++)
            {
                wynikowa += candidate[i];
            }
            return wynikowa;



        }

    public override string GetName()
       {
           throw new NotImplementedException();
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
    }
}
