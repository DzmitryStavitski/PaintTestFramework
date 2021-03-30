using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Framework.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(Application.Application application, string elementID)
            : base(application, elementID)
        {

        }

        public override void click()
        {
            logger.Debug($"Clicking on Button (element ID = {elementID})");

            var button = application.getApplicationWindow().Get<TestStack.White.UIItems.TextBox>(SearchCriteria.ByAutomationId(elementID.ToString()));
            if (button != null) button.Click();
        }

        public string returnText()
        {
            logger.Debug($"Returning text from TextBox (element ID = {elementID})");

            return
                application.getApplicationWindow().Get<Label>(SearchCriteria.ByAutomationId(elementID.ToString())).AutomationElement.
                    GetCurrentPropertyValue(System.Windows.Automation.AutomationElement.NameProperty).ToString();
        }

        public void EnterText(string text)
        {
            var textBox = application.getApplicationWindow()
                .Get<TestStack.White.UIItems.TextBox>(SearchCriteria.ByAutomationId(elementID));
            textBox.Enter(text);
        }
    }
}
