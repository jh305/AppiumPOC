using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumPOC.Pages
{
    public class ConfirmAllocationPage : PageBase
    {
        public ConfirmAllocationPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        public void OpenCautiousTab() =>
            WaitForAndReturnElement("allocationtypeCaution").Click();

        public void OpenBalancedTab() =>
            WaitForAndReturnElement("allocationtypeBalanced").Click();

        public void OpenAdventurousTab() =>
            WaitForAndReturnElement("allocationtypeAdventurous").Click();
    }
}