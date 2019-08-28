using System;
using Logging.Entities;

namespace Logging.Repository
{
    public interface ILoggingRepository
    {
        void LogException(string message, Exception ex, LogMessageType type);
    }
}
