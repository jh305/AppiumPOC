using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;

namespace AppiumPOC.Blocks
{
    public class BlockBase
    {
        public AppiumDriver<AndroidElement> Driver;
        private WebDriverWait Wait;

        public BlockBase(AppiumDriver<AndroidElement> driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

        /// <summary>
        /// Waits for and returns a webelement by searching and polling the page for the element
        /// for a certain amount of time (Currently set to 30 seconds in the constructor.)
        /// </summary>
        /// <param name="identifier">The Identifier.</param>
        public AndroidElement WaitForAndReturnElement(string identifier)
        {
            Wait.Message = $"Failed to wait for ReturnElements(By.CssSelector: {identifier})) to return at least ";
            return Wait.Until(d => ReturnElement(identifier));
        }

        public AndroidElement ReturnElement(string identifier) =>
            Driver.FindElementById(identifier);
    }    
}