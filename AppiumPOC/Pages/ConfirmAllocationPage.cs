using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumPOC.Pages
{
    public class ConfirmAllocationPage : PageBase
    {
        public ConfirmAllocationPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        // Click the Cautious link
        public void OpenCautiousTab() =>
            WaitForAndReturnElement("allocationtypeCaution").Click();

        // Click the Balanced tab
        public void OpenBalancedTab() =>
            WaitForAndReturnElement("allocationtypeBalanced").Click();

        // Click the Adventurous tab
        public void OpenAdventurousTab() =>
            WaitForAndReturnElement("allocationtypeAdventurous").Click();
    }
}