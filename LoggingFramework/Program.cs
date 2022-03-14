using Driver;
using Logger253;
using LoggerCore;

namespace LoggingFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            const string LOG_FILE = @"c:\trash\log1.txt";
            LogOutputEnum output = LogOutputEnum.Both;
            if (args.Length > 0)
            {
                if (args[0].StartsWith("-"))
                {
                    if (args[0].Contains("f") && args[0].Contains("c")) output = LogOutputEnum.Both;
                    else if (args[0].Contains("f")) output = LogOutputEnum.File;
                    else if (args[0].Contains("c")) output = LogOutputEnum.Console;
                }
            }

            ILogger logger = new AllLogger(LOG_FILE, output);
            logger.Log("Program Started");
            Thread.Sleep(3000); // sending emails
            logger.Log("Program Ended");
        }
    }
}