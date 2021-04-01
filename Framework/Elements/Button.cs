using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Framework.elements
{
    public class Button : BaseElement<TestStack.White.UIItems.Button>
    {

        public Button(TestStack.White.UIItems.Button uiItem) : base(uiItem)
        {

        }

        public static Button Get(SearchCriteria searchCriteria, Window window = null)
        {
            return new Button(Find(searchCriteria, window));
        }
    }
}
