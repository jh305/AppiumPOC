using AppiumPOC.Blocks;
using AppiumPOC.Pages;
using AppiumPOC.Steps;
using NUnit.Framework;

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
            _cofirmAllocationSteps.OpenCautiousTab();

            // Assert

        }

        [Test]
        public void TeConfirmAllocationPercentage_Balanaced()
        {
            _cofirmAllocationSteps.OpenBalancedTab();

            // Assert

        }

        [Test]
        public void TeConfirmAllocationPercentage_Adventurous()
        {
            _confirmAllocationPage.OpenAdventurousTab();

            // Assert

        }
    }
}