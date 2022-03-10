using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumPOC.Blocks
{
    public class BalancedTab : BlockBase
    {
        public BalancedTab(AppiumDriver<AndroidElement> driver) : base(driver)
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
            WaitForAndReturnElement("allocationpercentage1");

        private AndroidElement GetAllocation2Element() =>
            WaitForAndReturnElement("allocationpercentage2");

        private AndroidElement GetAllocation3Element() =>
            WaitForAndReturnElement("allocationpercentage3");
    }
}
