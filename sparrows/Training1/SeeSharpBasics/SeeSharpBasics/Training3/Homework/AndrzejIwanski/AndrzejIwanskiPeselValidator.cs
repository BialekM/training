namespace SeeSharpBasics.Training3.Homework.AndrzejIwanski
{
    public class AndrzejIwanskiPeselValidator : PeselValidator
    {
        public override bool IsPeselValid(string peselCandidate)
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsPeselDateValid(string year, string month, string day)
        {
            throw new System.NotImplementedException();
        }
    }
}