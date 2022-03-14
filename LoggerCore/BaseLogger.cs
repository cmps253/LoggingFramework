namespace LoggerCore
{
    public abstract class BaseLogger : ILogger
    {
        public abstract void Log(string msg);
        protected string FormatMessage(string msg) => $"{DateTime.Now}: {msg}\n";
    }
}
