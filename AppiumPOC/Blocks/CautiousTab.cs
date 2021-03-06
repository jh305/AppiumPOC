using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Collections.Generic;

namespace AppiumPOC.Blocks
{
    public  class CautiousTab : BlockBase
    {
        public CautiousTab(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        // Get all on screen percentages text values and return them
        public List<string> ReturnAllAllocationPercentages()
        {
            var percentageAllocations = new List<string>()
            {
                GetAllocation1Element().Text,
                GetAllocation2Element().Text,
                GetAllocation3Element().Text,
            };

            return percentageAllocations;
        }

        private AndroidElement GetAllocation1Element() =>
            WaitForAndReturnElement("allocationpercentage4");

        private AndroidElement GetAllocation2Element() =>
            WaitForAndReturnElement("allocationpercentage5");

        private AndroidElement GetAllocation3Element() =>
            WaitForAndReturnElement("allocationpercentage6");
    }
}