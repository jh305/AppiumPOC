using AppiumPOC.Settings;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;

namespace AppiumPOC
{
    public  class DriverBase
    {
        AppiumDriver<AndroidElement> Driver;

        [SetUp]
        public void Setup()
        {
            AppiumOptions capabilities = new AppiumOptions();

            capabilities.AddAdditionalCapability("deviceName", "emulator-5554");
            capabilities.AddAdditionalCapability(CapabilityType.Version, "6.0");
            capabilities.AddAdditionalCapability(CapabilityType.BrowserName, "Android");
            capabilities.AddAdditionalCapability(CapabilityType.Platform, "Android");
            capabilities.AddAdditionalCapability("appPackage", "com.healthifyme.basic");
            capabilities.AddAdditionalCapability("appActivity", "com.healthifyme.basic.activities.NewLoginSignupActivity");
            capabilities.AddAdditionalCapability("NEW_COMAND_TIMEOUT", "50000");
            capabilities.AddAdditionalCapability("app", TestSettings_Dev.APKFileLocation);
            
            Driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
        }


        // Teardown method after each test to dispose of the Appium driver
        [TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver = null;
            }                      
        }
    }
}