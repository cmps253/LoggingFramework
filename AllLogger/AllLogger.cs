using Logger253;
using LoggerCore;
using LoggingFramework;

namespace Driver
{
    public enum LogOutputEnum
    {
        File,
        Console,
        Both
    }
    public class AllLogger : BaseLogger
    {
        List<ILogger> _loggers = new();
        public AllLogger(string fileName, LogOutputEnum output)
        {
            switch (output)
            {
                case LogOutputEnum.File:
                    _loggers.Add(new FileLogger(fileName));
                    break;
                case LogOutputEnum.Console:
                    _loggers.Add(new ConsoleLogger());
                    break;
                default:
                case LogOutputEnum.Both:
                    _loggers.Add(new FileLogger(fileName));
                    _loggers.Add(new ConsoleLogger());
                    break;
            }
        }
        public override void Log(string msg)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(msg);
            }
        }
    }
}
