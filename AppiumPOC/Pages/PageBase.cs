using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumPOC.Pages
{
    public  class PageBase
    {
        public AppiumDriver<AndroidElement> Driver;

        public PageBase(AppiumDriver<AndroidElement> driver)
        {
            Driver = driver;
        }
    }
}
