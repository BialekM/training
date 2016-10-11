namespace Toci.DesignPatterns.ExceptionHandling
{
    public class TociDbApplicationException : TociApplicationException
    {
        public TociDbApplicationException(string customMessage, int code, string backendMessage) : base(customMessage, code, backendMessage)
        {
        }
    }
}