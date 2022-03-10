using NUnit.Framework;

namespace AppiumPOC.Settings
{
    public static class TestSettings_Dev
    {
        // When runing a test in Visual Studio, we can select a solution wide run settings file. Using Nunit's TestContext, we can then pick up and choose these values 
        // to run in our test.
        // This is useful for using parameters such as URL's for different environments and other environment specific data (User names/passwords, clients ID's etc) that 
        // would be unique across different environments.

        public static string APKFileLocation =>
            GetSettingOrDefault("apkFileLocation", "C:\\defaultFileLocation");

        public static string GetSettingOrDefault(string settingName, string defaultValue)
        {
            if (!TestContext.Parameters.Exists(settingName))
            {
                return defaultValue;
            }

            return TestContext.Parameters[settingName];
        }
    }
}