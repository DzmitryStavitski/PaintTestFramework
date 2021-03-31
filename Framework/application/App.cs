using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Framework.Properties;
using NLog;
using TestStack.White.UIItems.WindowItems;

namespace Framework.Application
{
    public class App
    {
        private static App _instance;
        private static TestStack.White.Application _application;
        private static Window _mainWindow;
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        private App()
        { }

        public static App GetApplication()
        {
            if (_instance == null)
            {
                _instance = new App();
            }
            return _instance;
        }

        public Window GetWindow()
        {
            return _mainWindow;
        }

        public void Run()
        {
            Logger.Debug($"Starting Application (Path = {Settings.Default.Path}/{Settings.Default.Exe})");

            _application = TestStack.White.Application.Launch(Path.Combine(Settings.Default.Path, Settings.Default.Exe));
            _mainWindow = _application.GetWindow(Settings.Default.MainWindowName);

            Logger.Info("Application is running...");
        }

        public void Close()
        {
            Logger.Debug($"Closing the application");

            _application.Close();
            _application.Dispose();

            Logger.Info($"Application was closed");
        }
    }
}
