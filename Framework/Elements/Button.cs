using TestStack.White.UIItems.Finders;

namespace Framework.Elements
{
    public class Button : BaseElement
    {
        public Button(Application.Application application, string elementID)
            : base(application, elementID)
        {

        }

        public override void click()
        {
            logger.Debug($"Clicking on Button (element ID = {elementID})");

            var button = application.getApplicationWindow().Get<TestStack.White.UIItems.Button>(SearchCriteria.ByAutomationId(elementID.ToString()));
            if (button != null) button.Click();
        }
    }
}