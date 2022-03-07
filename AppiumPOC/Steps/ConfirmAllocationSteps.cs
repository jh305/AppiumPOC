using AppiumPOC.Blocks;
using AppiumPOC.Pages;
using System.Collections.Generic;

namespace AppiumPOC.Steps
{
    public class ConfirmAllocationSteps
    {
        private ConfirmAllocationPage _confirmAllocationPage;

        private AdventurousTab _adventurousTab;
        private BalancedTab _balancedTab;
        private CautiousTab _cautiousTab;
        public ConfirmAllocationSteps(ConfirmAllocationPage confirmAllocationPage, CautiousTab cautiousTab, BalancedTab balancedTab, AdventurousTab adventurousTab)
        {
            _confirmAllocationPage = confirmAllocationPage;
            _cautiousTab = cautiousTab;
            _balancedTab = balancedTab;
            _adventurousTab = adventurousTab;
        }

        // Open the Cautious tab and get all Cautious fund allocations
        public List<string> GetCautiousFundAllocationPercentages()
        {
            _confirmAllocationPage.OpenCautiousTab();
            return _cautiousTab.ReturnAllAllocationPercentages();
        }

        // Open the Balanced tab and get all Balanced fund allocations
        public List<string> GetBalancedFundAllocationPercentages()
        {
            _confirmAllocationPage.OpenCautiousTab();
            return _balancedTab.ReturnAllAllocationPercentages();
        }

        // Open the Adventurous tab and get all Adventurous fund allocations
        public List<string> GetAdventurousFundAllocationPercentages()
        {
            _confirmAllocationPage.OpenAdventurousTab();
            return _adventurousTab.ReturnAllAllocationPercentages();
        }
    }
}