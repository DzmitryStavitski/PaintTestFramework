using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace Framework.elements
{
    public class MenuItem : BaseElement<Menu>
    {
        protected MenuItem(Menu uiItem, string itemName) : base(uiItem)
        {

        }

        public static MenuItem Get(SearchCriteria searchCriteria, string itemName, Window window = null)
        {
            return new MenuItem(Find(searchCriteria, window), itemName);
        }
    }
}
