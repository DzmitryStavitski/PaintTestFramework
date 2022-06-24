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
        [Given(@"I open the Paint")]
        public void GivenPaintIsOpen()
        {
            Assert.IsTrue(MainPage.IsMainWindowOpened());
        }
        
        [When(@"I open an image ""(.*)"" from ""(.*)""")]
        public void WhenIOpenAnImageFrom(string imageName, string path)
        {
            var imageFullPath = Path.Combine(path, imageName);
            var image = new Bitmap(Image.FromFile(imageFullPath));
            
            ScenarioContext.Current.Add("image", image);
            ScenarioContext.Current.Add("imagePath", imageFullPath);

            MainPage.ButtonFile.Click();
            FileMenuPage.OpenMenu.Click();
            OpenFilePage.TextBoxFilePath.BulkText(imageFullPath);
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
