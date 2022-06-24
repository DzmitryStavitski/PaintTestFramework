using System.Windows.Automation;
using Framework.Application;
using Framework.elements;
using TestStack.White.UIItems.Finders;

namespace PaintTests.pages
{
    public class FileMenuView
    {
        public static MenuItem MenuItemOpen =>
            MenuItem.Get(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Open"), App.GetApplication().GetWindow().ModalWindow("Open file"));
    }
}
