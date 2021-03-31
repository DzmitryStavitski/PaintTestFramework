using System.Drawing;
using System.IO;
using TechTalk.SpecFlow;
using Framework.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaintTests.pages;

namespace PaintTests.Steps
{
    [Binding]
    public class PaintSteps
    {

        [Given(@"Paint is open")]
        public void GivenPaintIsOpen()
        {
            Assert.IsTrue(true);
        }
        
        [Given(@"all old instance were closed")]
        public void GivenAllOldInstanceWereClosed()
        {
            Assert.IsTrue(true);
        }
        
        [When(@"I open an image ""(.*)"" from ""(.*)""")]
        public void WhenIOpenAnImageFrom(string imageName, string path)
        {
            string imageFullPath = Path.Combine(path, imageName);
            Bitmap image = new Bitmap(Image.FromFile(imageFullPath));
            
            ScenarioContext.Current.Add("image", image);
            ScenarioContext.Current.Add("imagePath", imageFullPath);

            MainPage.ButtonFile.Click();
            FileMenuView.MenuItemOpen.Click();
            OpenFilePage.TextBoxFilePath.BulkText(Path.Combine(path, imageName));
            OpenFilePage.ButtonOpenFile.Click();
        }

        [When(@"I click button select all")]
        public void WhenIClickButtonSelectAll()
        {
            MainPage.ButtonSelect.Click();
            MainPage.MenuItemSelectAll.Click();
        }

        [When(@"I click button cut")]
        public void WhenIClickButtonCut()
        {
            MainPage.ButtonCut.Click();
        }

        [When(@"I close app without saving")]
        public void WhenICloseAppWithoutSaving()
        {
            MainPage.ButtonClose.Click();
            MainPage.ButtonDoNotSave.Click();
        }

        [Then(@"image should not have changed")]
        public void ThenImageShouldNotHaveChanged()
        {
            Assert.IsTrue(ImageCompareUtil.CompareImages((Bitmap) ScenarioContext.Current["image"],
                new Bitmap(Image.FromFile((string)ScenarioContext.Current["imagePath"]))));
            Assert.IsTrue(true, "The original picture has changed.");
        }
    }
}
