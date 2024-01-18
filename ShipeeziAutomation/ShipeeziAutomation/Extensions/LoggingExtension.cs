using Caliburn.Micro;
using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipeeziAutomation.Extensions
{
    public static class LoggingExtension
    {
        public static void ConfigureLogging(this SimpleContainer container)
        {
          //  ILoggerManager loggerManager = new LoggerManager(BaseLoggerManager.LogType.TXT);
            container.Singleton<ILoggerManager,LoggerManager>();
            
        }
    }
}
