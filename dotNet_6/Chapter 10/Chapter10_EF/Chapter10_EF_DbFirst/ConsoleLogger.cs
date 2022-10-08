using static System.Console;

using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace EntFrame.Shared
{
    public class ConsoleLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            //different Logger for different categories
            return new ConsoleLogger();
        }

        public void Dispose() { }//does nothing, but must exist
    }

    public class ConsoleLogger : ILogger
    {
        //need this if Logger uses unmanaged resources
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }
        public bool IsEnabled(LogLevel level)
        {
            //to avoid overlogging
            switch (level)
            {
                case LogLevel.Trace:
                case LogLevel.Information:
                case LogLevel.None:
                    return false;

                case LogLevel.Debug:
                case LogLevel.Warning:
                case LogLevel.Error:
                case LogLevel.Critical:
                default:
                    return true;
            };
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (eventId == 20100)//example of filtering log by provider event Id - 20100 is SQL command excuting Id
            {
                //log the level and event identifier
                Write($"Level: {logLevel}, Event Id: {eventId}");
                //only output the state oe exceptionif it exists
                if (state != null)
                {
                    Write($", State: {state}");
                }
                if (exception != null)
                {
                    Write($", Exception: {exception.Message}");
                }
                WriteLine();
            }
        }
    }
}
