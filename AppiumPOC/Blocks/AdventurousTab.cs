using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumPOC.Blocks
{
    public class AdventurousTab : BlockBase
    {
        public AdventurousTab(AppiumDriver<AndroidElement> driver) : base(driver)
        {

        }


        private AndroidElement GetAllocation1Element() =>
            WaitForAndReturnElement("");

        private AndroidElement GetAllocation2Element() =>
            WaitForAndReturnElement("");

        private AndroidElement GetAllocation3Element() =>
            WaitForAndReturnElement("");

    }
}