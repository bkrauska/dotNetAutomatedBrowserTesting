using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumWebDriverTests {
    [TestClass]
    public class GoogleTests {
        [TestMethod]
        public void open_google_in_ie_64bit() {
            IWebDriver driver = new OpenQA.Selenium.IE.InternetExplorerDriver(@"..\..\..\web-drivers\IEDriverServer_x64_2.26.0");

            driver.Navigate().GoToUrl("http://google.com/");

            driver.Close();
        }

        [TestMethod]
        public void open_google_in_ie_32bit() {
            IWebDriver driver = new OpenQA.Selenium.IE.InternetExplorerDriver(@"..\..\..\web-drivers\IEDriverServer_Win32_2.26.0");

            driver.Navigate().GoToUrl("http://google.com/");

            driver.Close();
        }

        [TestMethod]
        public void open_google_in_chrome() {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"..\..\..\web-drivers\chromedriver_win_23.0.1240.0");

            driver.Navigate().GoToUrl("http://google.com/");

            driver.Close();
        }

        [TestMethod]
        public void open_google_in_firefox() {
            IWebDriver driver = new OpenQA.Selenium.Firefox.FirefoxDriver();

            driver.Navigate().GoToUrl("http://google.com/");

            driver.Close();
        }
    }
}
