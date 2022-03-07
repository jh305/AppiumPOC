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
        private List<string> _percentageAllocations;

        public BalancedTab(AppiumDriver<AndroidElement> driver) : base(driver)
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
