using System;
using log4net;
using log4net.Config;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Console_App
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            //XmlConfigurator.Configure(new System.IO.FileInfo(@"C:\Work\Geekbrains\Courses\Level 2\Home_Work_3\Test_Console_App\BaseConfig.xml"));

            log4net.LogicalThreadContext.Properties["CustomColumn"] = "Вася";
            log.Info("Message");
            Console.ReadKey();
        }
    }
}
