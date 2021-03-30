using System;
using PaintTests.Objects;
using TechTalk.SpecFlow;

namespace PaintTests.Steps
{
    [Binding]
    public class PaintSteps
    {
        private PaintObject _paint;

        [Given(@"open the Paint")]
        public void GivenOpenThePaint()
        {
            _paint = new PaintObject();
        }
        
        [Given(@"load image")]
        public void GivenLoadImage()
        {
            _paint.ClickOnLoadMenuItem();
            //_paint.ClickOnOpenMenuItem();
        }
        
        [Given(@"click on Select menu")]
        public void GivenClickOnSelectMenu()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click on Select All")]
        public void GivenClickOnSelectAll()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click Cut")]
        public void GivenClickCut()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"close the Paint")]
        public void GivenCloseThePaint()
        {
            _paint.Close();
        }
        
        [Then(@"refuse to save reslut")]
        public void ThenRefuseToSaveReslut()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
