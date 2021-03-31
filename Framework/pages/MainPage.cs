using System.Windows.Automation;
using Framework.Application;
using Framework.elements;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using Button = Framework.elements.Button;

namespace Framework.pages
{
    public class MainPage
    {
        public static UIItem ButtonFile => BaseElement<TestStack.White.UIItems.Button>.
            Find(TreeScope.Descendants, AutomationElementIdentifiers.NameProperty, "File tab");
        public static Button ButtonClose =>
            Button.Get(SearchCriteria.ByAutomationId("Close"));
        public static Button ButtonDoNotSave =>
            Button.Get(SearchCriteria.ByAutomationId("CommandButton_7"), App.GetApplication().GetWindow().ModalWindow("Paint"));
        public static MenuItem MenuItemSelectAll => MenuItem.Get(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Select all"), "Select all");
        public static UIItem ButtonSelect => BaseElement<TestStack.White.UIItems.Button>.
            FindItemByIndex(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Select"), 2);
        public static Button ButtonCut =>
            Button.Get(SearchCriteria.ByText("Cut"));
    }
}
