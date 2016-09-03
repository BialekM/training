using System;

namespace HornetsTraining.Training1.HomeWork.BartekZapart
{
    public class BartekZapartStringOperations : StringOperations, IDisposable
    {
        public override string GetName()
        {
            return "Bartek Zapart";
        }

        public override string Substring(string candidate, int start, int length)
        {
            throw new System.NotImplementedException();
        }

        public override int PositionInString(string candidate, string needle)
        {
            throw new System.NotImplementedException();
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}