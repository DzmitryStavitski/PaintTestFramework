using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Framework.elements
{
    public class TextBox : BaseElement<TestStack.White.UIItems.TextBox>
    {
        protected TextBox(TestStack.White.UIItems.TextBox uiItem) : base(uiItem)
        {

        }

        public static TextBox Get(SearchCriteria searchCriteria, string itemName, Window window = null)
        {
            return new TextBox(Find(searchCriteria, window));
        }

        public void BulkText(string text)
        {
            Uitem.BulkText = text;
        }
    }
}
