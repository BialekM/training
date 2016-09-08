using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTraining.Training1.HomeWork.PawelMarciniak
{
    class PawelMarciniakStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Pawel Marciniak";
        }

        public override string Substring(string candidate, int start, int length)
        {
            
        }

        public override int PositionInString(string candidate, string needle)
        {
            throw new NotImplementedException();
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            throw new NotImplementedException();
        }
    }
}
