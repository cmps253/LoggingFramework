using LoggerCore;

namespace LoggingFramework
{
    public class ConsoleLogger : BaseLogger
    {
        public override void Log(string msg)
        {
            Console.WriteLine(base.FormatMessage(msg)); 
        }
    }
}
