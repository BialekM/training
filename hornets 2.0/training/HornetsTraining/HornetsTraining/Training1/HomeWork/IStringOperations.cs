namespace Toci.HornetsTraining.Training1.HomeWork
{
    public interface IStringOperations
    {
        string GetName();
        string Substring(string candidate, int start, int length);
        int PositionInString(string candidate, string needle);
        string StringReplace(string candidate, string needle, string replaceWith);
    }
}