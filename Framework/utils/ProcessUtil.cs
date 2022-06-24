using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Framework.utils
{
    public static class ProcessUtil
    {
        private static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public static void CloseAllProcessesByName(string name)
        {
            Logger.Debug($"Kill all proccess with name = {name}");

            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    if (process.ProcessName.Equals(name))
                    {
                        process.Kill();
                    }
                }
                catch (Exception e)
                {
                    Logger.Warn($"Proccess with name = {process.ProcessName}) denied access. Exception message = {e.Message}");
                    continue;
                }
            }
        }
    }
}
