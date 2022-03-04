using AppiumPOC.Blocks;
using AppiumPOC.Pages;
using AppiumPOC.Steps;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumPOC
{
    public class Tests : DriverBase
    {
        public ConfirmAllocationSteps _cofirmAllocationSteps;
        public ConfirmAllocationPage _confirmAllocationPage;
        public AdventurousTab _adventurousTab;
        public BalancedTab _balancedTab;
        public CautiousTab _cautiousTab;
        
        [SetUp]
        public void TestSetup()
        {
            _cofirmAllocationSteps = new ConfirmAllocationSteps(_confirmAllocationPage, _cautiousTab, _balancedTab, _adventurousTab);

        }
        

        [Test]
        public void TeConfirmAllocationPercentage_Cautious()
        {

            // Assert

        }

        [Test]
        public void TeConfirmAllocationPercentage_Balanaced()
        {

            // Assert

        }

        [Test]
        public void TeConfirmAllocationPercentage_Adventurous()
        {

            // Assert

        }
    }
}