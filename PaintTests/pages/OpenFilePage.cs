using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using Framework.Application;
using Framework.elements;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using Button = Framework.elements.Button;
using TextBox = Framework.elements.TextBox;

namespace PaintTests.pages
{
    public class OpenFilePage
    {
        private static readonly Window ModalWindow = App.GetApplication().GetWindow().ModalWindow("Open");

        public static Button ButtonOpenFile => Button.Get(SearchCriteria.ByControlType(ControlType.Button).AndByText("Open"), ModalWindow);
        public static TextBox TextBoxFilePath => TextBox.Get(SearchCriteria.ByAutomationId("1148"), "File path input");
    }
}
