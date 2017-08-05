using System;

namespace Deepend.Core.Logging
{
    /// <summary>
    /// Log4Net implementation of ILogger
    /// </summary>
    public class Log4NetLogger : ILogger
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
     (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void Log(Exception ex)
        {
            log.Error(ex);
        }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}