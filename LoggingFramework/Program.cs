using Driver;

namespace LoggingFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new AllLogger(@"c:\trash\log1.txt");
            logger.Log("Program Started");
            Thread.Sleep(3000); // sending emails
            logger.Log("Program Ended");
        }
    }
}