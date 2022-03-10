using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            WaitForAndReturnElement("");

        private AndroidElement GetAllocation2Element() =>
            WaitForAndReturnElement("");

        private AndroidElement GetAllocation3Element() =>
            WaitForAndReturnElement("");
    }
}