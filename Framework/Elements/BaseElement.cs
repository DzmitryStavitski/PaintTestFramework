using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Framework.Elements
{
    public abstract class BaseElement
    {
        protected string elementID;
        protected static ILogger logger = LogManager.GetCurrentClassLogger();
        protected Application.Application application;

        public BaseElement(Application.Application application, string elementID)
        {
            this.application = application;
            this.elementID = elementID;
        }

        public abstract void click();
    }
}
