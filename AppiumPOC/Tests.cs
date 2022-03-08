using AppiumPOC.Blocks;
using AppiumPOC.Pages;
using AppiumPOC.Steps;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

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

            // As all three tests take place on the same page, we could have steps in the Setup method which would login and navigate
            // to the Confirm Allocation page. This way, the 3 tests are not reliant on each other and can be run independently.
        }

        [Test]
        public void ConfirmAllocationPercentage_Cautious()
        {
            // Open the Cautious tab and get all fund allocations
            List<string> fundPercentages = _cofirmAllocationSteps.GetCautiousFundAllocationPercentages();

            // Assert
            List<string> expectedResults = new List<string>() { "85", "10", "5" };
            fundPercentages.Should().BeEquivalentTo(expectedResults);
        }

        [Test]
        public void ConfirmAllocationPercentage_Balanaced()
        {
            // Open the Balanced tab and get all Balanced fund allocations
            List<string> fundPercentages = _cofirmAllocationSteps.GetBalancedFundAllocationPercentages();

            // Assert
            List<string> expectedResults = new List<string>() { "30", "45", "25"};
            fundPercentages.Should().BeEquivalentTo(expectedResults);
        }

        [Test]
        public void ConfirmAllocationPercentage_Adventurous()
        {
            // Open the Adventurous tab and get all Adventurous fund allocations
            List<string> fundPercentages = _cofirmAllocationSteps.GetAdventurousFundAllocationPercentages();

            // Assert
            List<string> expectedResults = new List<string>() { "5", "60", "35" };
            fundPercentages.Should().BeEquivalentTo(expectedResults);
        }
    }
}