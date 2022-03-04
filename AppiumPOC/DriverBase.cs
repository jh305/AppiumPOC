using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumPOC
{
    public  class DriverBase
    {
        AppiumDriver<AndroidElement> Driver;

        [SetUp]
        public void Setup()
        {
            AppiumDriver<AndroidElement> driver;
            string app = "C:\\Users\\105798\\testapplications\\HealthifyMe.apk";

            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "emulator-5554");
            capabilities.SetCapability(CapabilityType.Version, "6.0");
            capabilities.SetCapability(CapabilityType.BrowserName, "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Android");
            capabilities.SetCapability("appPackage", "com.healthifyme.basic");
            capabilities.SetCapability("appActivity", "com.healthifyme.basic.activities.NewLoginSignupActivity");

            capabilities.SetCapability("NEW_COMAND_TIMEOUT", "50000");
            capabilities.SetCapability("app", "C:\\Users\\105798\\testapplications\\HealthifyMe.apk");
            Thread.Sleep(2000);
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);



        }
    }
}