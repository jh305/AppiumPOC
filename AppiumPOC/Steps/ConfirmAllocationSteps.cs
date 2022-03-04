﻿using AppiumPOC.Blocks;
using AppiumPOC.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void OpenAdventurousTab()
        {

        }

        public void OpenBalancedTab()
        {

        }

        public void OpenCautiousTab()
        {

        }
    }
}