using System;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using Toci.DesignPatterns.ExceptionHandling.ErrorLog;

namespace Toci.DesignPatterns.ExceptionHandling
{
    public static class ExceptionLogger
    {
        private static readonly TociExceptionEntities Database = new TociExceptionEntities();
        public static void LogIntoDatabase(TociApplicationException exception)
        {
            using (Database)
            {
                var errorLogRecord = CreateErrorLogRecord(exception);
                Database.ErrorLog.Add(errorLogRecord);
                Database.SaveChanges();
            }
        }

        private static ErrorLog.ErrorLog CreateErrorLogRecord(TociApplicationException exception)
        {
            return new ErrorLog.ErrorLog
            {
                BackendMessage = exception.BackendMessage,
                CustomFrontMessage = exception.CustomFrontMessage,
                OccurenceDatetime = DateTime.Now
            };
        }

    }
}