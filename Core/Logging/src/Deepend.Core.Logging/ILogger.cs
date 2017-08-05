using System;

namespace Deepend.Core.Logging
{
    /// <summary>
    /// Interface for logger
    /// </summary>
    public interface ILogger
    {
        void Log(string message);
        void Log(Exception ex);
    }
}