using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;

namespace AppiumPOC.Blocks
{
    public class BlockBase
    {
        public AppiumDriver<AndroidElement> _driver;
        private WebDriverWait _wait;

        public BlockBase(AppiumDriver<AndroidElement> driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        /// <summary>
        /// Waits for and returns a webelement by searching and polling the page for the element
        /// for a certain amount of time (Currently set to 30 seconds in the constructor.)
        /// </summary>
        /// <param name="identifier">The Identifier.</param>
        public AndroidElement WaitForAndReturnElement(string identifier)
        {
            _wait.Message = $"Failed to wait for ReturnElements(By.CssSelector: {identifier})) to return at least ";
            return _wait.Until(d => ReturnElement(identifier));
        }

        public AndroidElement ReturnElement(string identifier) =>
            _driver.FindElementById(identifier);
    }    
}