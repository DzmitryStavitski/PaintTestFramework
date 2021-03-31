using System.Windows.Automation;
using Framework.elements;
using TestStack.White.UIItems.Finders;

namespace PaintTests.pages
{
    public class FileMenuView
    {
        public static MenuItem MenuItemOpen => MenuItem.Get(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Open"), "Open file");
    }
}
