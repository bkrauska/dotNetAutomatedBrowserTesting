using OpenQA.Selenium;

namespace SeleniumWebDriverTests {
    public static class WebDriverFactory {
        private const string _webDriverPath = @"..\..\..\web-drivers\";
        private const string IEx64 = "IEDriverServer_x64_2.26.0";
        private const string IEx86 = "IEDriverServer_Win32_2.26.0";
        private const string ChromeWin = "chromedriver_win_23.0.1240.0";

        public static IWebDriver IE_32bit() {
            return new OpenQA.Selenium.IE.InternetExplorerDriver(_webDriverPath + IEx86);
        }

        public static IWebDriver IE_64bit() {
            return new OpenQA.Selenium.IE.InternetExplorerDriver(_webDriverPath + IEx64);
        }

        public static IWebDriver Chrome() {
            return new OpenQA.Selenium.Chrome.ChromeDriver(_webDriverPath + ChromeWin);
        }

        public static IWebDriver Firefox() {
            return new OpenQA.Selenium.Firefox.FirefoxDriver();
        }
    }
}
