using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Collections.Generic;

namespace AppiumPOC.Blocks
{
    public class AdventurousTab : BlockBase
    {
        public AdventurousTab(AppiumDriver<AndroidElement> driver) : base(driver)
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
            WaitForAndReturnElement("");

        private AndroidElement GetAllocation2Element() =>
            WaitForAndReturnElement("");

        private AndroidElement GetAllocation3Element() =>
            WaitForAndReturnElement("");
    }
}