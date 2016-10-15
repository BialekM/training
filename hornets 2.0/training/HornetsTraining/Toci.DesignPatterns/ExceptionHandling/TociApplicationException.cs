using System;

namespace Toci.DesignPatterns.ExceptionHandling
{
    public abstract class TociApplicationException : ApplicationException
    {
        public string CustomFrontMessage { get; set; }

        public int ErrorCode { get; set; }

        public string BackendMessage { get; set; }

        protected TociApplicationException(string customMessage, int code, string backendMessage)
        {
            CustomFrontMessage = customMessage;
            ErrorCode = code;
            BackendMessage = backendMessage;

            //dodatkowo logowanie do np bazy danych bledou - BackendMessage i code
            ExceptionLogger.LogIntoDatabase(this);
        }
    }
}