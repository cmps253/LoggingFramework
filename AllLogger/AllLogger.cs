using Logger253;
using LoggingFramework;

namespace Driver
{
    public class AllLogger
    {
        private string _fileName;
        private ConsoleLogger _consoleLogger;
        private FileLogger _fileLogger;
        public AllLogger(string fileName)
        {
            _fileName = fileName;
            _consoleLogger = new ConsoleLogger();
            _fileLogger = new FileLogger(fileName);
        }
        public void Log(string msg)
        {
            _consoleLogger.Log(msg);
            _fileLogger.Log(msg);
        }
    }
}
