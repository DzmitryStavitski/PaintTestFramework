using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Framework.utils
{
    class LoggerUtil
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static Logger GetLogger()
        {
            return logger;
        }
    }
}
