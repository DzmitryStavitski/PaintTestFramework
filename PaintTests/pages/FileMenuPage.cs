using System.Windows.Automation;
using Framework.elements;
using TestStack.White.UIItems.Finders;

namespace PaintTests.pages
{
    public class FileMenuPage
    {
        public static MenuItem OpenMenu => MenuItem.Get(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Open"));
    }
}
