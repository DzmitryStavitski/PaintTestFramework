using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Application;
using Framework.utils;
using Gherkin;
using TechTalk.SpecFlow;

namespace PaintTests.Hooks
{
    [Binding]
    public sealed class BeforeAndAfterScenario
    {
        private readonly App _app = App.GetApplication();

        [BeforeScenario]
        public void BeforeScenario()
        {
            _app.Run();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _app.Close();
        }
    }
}
