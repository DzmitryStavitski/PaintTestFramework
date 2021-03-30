using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Framework.Application;
using Framework.Elements;

namespace PaintTests.Objects
{
    class PaintObject
    {
        Application application = new Application(@"C:\Windows\System32\mspaint.exe", "Untitled - Paint");

        private TextBox textBox;

        public void ClickOnFileButton()
        {
            //application.FindButtonByText("Color 2").click();
            Thread.Sleep(2000);
        }

        public void ClickOnLoadMenuItem()
        {
            application.OpenProjectTub();
            textBox = new TextBox(application,"1148");
            textBox.EnterText(@"C:\Users\d.stavitsky\Downloads\test.jpg");
            Thread.Sleep(10000);
            new Button(application, "1").click();
        }

        public void ClickOnOpenMenuItem()
        {
            application.FindMenuItemByPath("Open").click();
        }

        public PaintObject()
        {
            application.Run();
        }

        public bool IsOpen()
        {
            return application != null;
        }

        public void Close()
        {
            application.Close();
        }
    }
}
