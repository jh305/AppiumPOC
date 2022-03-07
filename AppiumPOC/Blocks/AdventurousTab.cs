using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Collections.Generic;

namespace AppiumPOC.Blocks
{
    public class AdventurousTab : BlockBase
    {
        private List<string> _percentageAllocations;

        public AdventurousTab(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        public List<string> ReturnAllAllocationPercentages()
        {
            // Add all on screen percentages text values to the _percentageAllocations list and return it
            _percentageAllocations = new List<string>()
            {
                GetAllocation1Element().Text,
                GetAllocation2Element().Text,
                GetAllocation3Element().Text,
            };

            return _percentageAllocations;
        }

        private AndroidElement GetAllocation1Element() =>
            WaitForAndReturnElement("");

        private AndroidElement GetAllocation2Element() =>
            WaitForAndReturnElement("");

        private AndroidElement GetAllocation3Element() =>
            WaitForAndReturnElement("");
    }
}