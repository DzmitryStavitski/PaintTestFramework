using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using Framework.Application;
using Framework.utils;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Framework.elements
{
    public class BaseElement<T> where T : UIItem
    {
        private static NLog.Logger logger = LoggerUtil.GetLogger();

        protected static App _app = App.GetApplication();
        protected static T Uitem;
        protected static Window defaultWindow = _app.GetWindow();

        public BaseElement(T uiItem)
        {
            Uitem = uiItem;
        }

        public static UIItem Find(TreeScope treeScope, AutomationProperty property, object value)
        {
            logger.Debug($"Searching Element by treeScope ({treeScope}), property({property}), value({value})");

            UIItem element =
                new UIItem(_app.GetWindow().AutomationElement.FindFirst(treeScope, new PropertyCondition(property, value)),
                    new NullActionListener());
            return element;
        }

        public static T Find(SearchCriteria searchCriteria, Window window = null)
        {
            logger.Debug("Searching Element by searchCriteria, window");

            if (window == null)
            {
                window = defaultWindow;
            }

            try
            {
                Uitem = _app.GetWindow().Get<T>(searchCriteria);
                return Uitem;
            }
            catch (AutomationException ex)
            {
                
            }

            return Uitem;
        }

        public static UIItem FindItemByIndex(TreeScope treeScope, Condition condition, int index)
        {
            logger.Debug($"Searching Element by Index");

            var elements = defaultWindow.AutomationElement.FindAll(treeScope, condition);
            UIItem element = null;
            for (var i = 0; i < elements.Count; i++)
            {
                if (i == index)
                {
                    element = new UIItem(elements[i], new NullActionListener());
                }
            }
            return element;
        }

        public bool IsElementExist()
        {
            return Uitem.Visible;
        }

        public void Click()
        {
            logger.Debug("Click on Element");
            Uitem.Click();
        }
    }
}
