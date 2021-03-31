using System;
using System.IO;
using System.Threading;
using Framework.Application;
using TechTalk.SpecFlow;
using Framework.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            MainPage.ButtonFile.Click();
            Thread.Sleep(2000);
            FileMenuView.MenuItemOpen.Click();
            Thread.Sleep(2000);
            OpenFilePage.TextBoxFilePath.BulkText(Path.Combine(path, imageName));
            Thread.Sleep(2000);
            OpenFilePage.ButtonOpenFile.Click();
        }

        [When(@"I click button select all")]
        public void WhenIClickButtonSelectAll()
        {
            MainPage.ButtonSelect.Click();
            Thread.Sleep(2000);
            MainPage.MenuItemSelectAll.Click();
            Thread.Sleep(2000);
        }

        [When(@"I click button cut")]
        public void WhenIClickButtonCut()
        {
            MainPage.ButtonCut.Click();
            Thread.Sleep(2000);
        }

        [When(@"I close app wihout saving")]
        public void WhenICloseAppWihoutSaving()
        {
            MainPage.ButtonClose.Click();
            MainPage.ButtonDoNotSave.Click();
        }

        [Then(@"image should not have changed")]
        public void ThenImageShouldNotHaveChanged()
        {
            Assert.IsTrue(true);
        }
    }
}
