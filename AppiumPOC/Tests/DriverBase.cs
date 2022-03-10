using AppiumPOC.Settings;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace AppiumPOC.Tests
{
    public  class DriverBase
    {
        protected AppiumDriver<AndroidElement> _driver;

        private AppiumLocalService _appiumLocalService;

        [SetUp]
        public void Setup()
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            _appiumLocalService.Start();

            AppiumOptions appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android_Accelerated_x86_Oreo");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "8");
            appiumOptions.AddAdditionalCapability("app", TestSettings_Dev.APKFileLocation); // Reference the location of the App APK location in the runsettings file
            
            _driver = new AndroidDriver<AndroidElement>(_appiumLocalService, appiumOptions);

            _driver.LaunchApp();
        }

        // Teardown method after each test to dispose of the Appium driver
        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }

            if(_appiumLocalService != null)
            {
                _appiumLocalService.Dispose();
            }
        }
    }
}