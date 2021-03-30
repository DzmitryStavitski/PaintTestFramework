using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.WindowsAPI;

namespace Framework.Application
{
    public class Application
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        private TestStack.White.Application application;
        private Window _applicationWindow;
        private string applicationPath;
        private string applicationWindowName;

        public Application(string applicationPath, string applicationWindowName)
        {
            this.applicationPath = applicationPath;
            this.applicationWindowName = applicationWindowName;
        }

        public Application(string applicationWindowName)
        {
            this.applicationWindowName = applicationWindowName;
        }

        public void OpenProjectTub()
        {
            _applicationWindow.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            _applicationWindow.Keyboard.Enter("O");
        }

        public void Run()
        {
            logger.Debug($"Starting Application (Path = {applicationPath}, Window Name = {applicationWindowName})");

            application = TestStack.White.Application.Launch(applicationPath);
            _applicationWindow = application.GetWindow(applicationWindowName);

            logger.Info("Application is running...");
        }

        public Elements.Button FindButtonByText(string elementText)
        {
            logger.Debug($"Returning button (with text = {elementText})");

            var button = _applicationWindow.Get<Button>(SearchCriteria.ByText(elementText));
            return new Elements.Button(this, button.Id);
        }

        public Elements.TextBox FindTextBoxByText(string elementText)
        {
            logger.Debug($"Returning button (with text = {elementText})");

            var button = _applicationWindow.Get<TextBox>(SearchCriteria.ByText(elementText));
            return new Elements.TextBox(this, button.Id);
        }

        public Elements.MenuItem FindMenuItemByPath(params string[] path)
        {
            logger.Debug($"Returning menuItem (with path = {path})");

            var menu = _applicationWindow.MenuBar.MenuItem(path);
            return new Elements.MenuItem(this, menu.Id, path);
        }

        public void Close()
        {
            logger.Debug($"Closing the application");

            application.Close();
            application.Dispose();

            logger.Info($"Application was closed");
        }

        public Window getApplicationWindow()
        {
            return _applicationWindow;
        }
    }
}
