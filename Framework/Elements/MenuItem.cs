using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Elements
{
    public class MenuItem : BaseElement
    {
        private string[] path;

        public MenuItem(Application.Application application, string elementID, params string[] path)
            : base(application, elementID)
        {
            this.path = path;
        }
        public override void click()
        {
            logger.Debug($"Returning menuItem (with path = {path})");
            var menu = application.getApplicationWindow().MenuBar.MenuItem(path[path.Length - 1]);
            menu.Click();
        }
    }
}
