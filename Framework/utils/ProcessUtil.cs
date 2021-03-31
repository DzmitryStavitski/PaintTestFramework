using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.utils
{
    public static class ProcessUtil
    {
        public static void CloseAllProcessesByName(string name)
        {
            foreach (var process in Process.GetProcesses())
            {
                process.Kill();
            }
        }
    }
}
