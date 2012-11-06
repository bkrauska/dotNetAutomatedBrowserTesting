using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumWebDriverTests {
    [TestClass]
    public class GoogleTests {
        [TestMethod]
        public void open_google_in_ie_64bit() {
            var driver = WebDriverFactory.IE_64bit();
            driver.Navigate().GoToUrl("http://google.com/");
            driver.Quit();
        }

        [TestMethod]
        public void open_google_in_ie_32bit() {
            var driver = WebDriverFactory.IE_32bit();
            driver.Navigate().GoToUrl("http://google.com/");
            driver.Quit();
        }

        [TestMethod]
        public void open_google_in_chrome() {
            var driver = WebDriverFactory.Chrome();
            driver.Navigate().GoToUrl("http://google.com/");
            driver.Quit();
        }

        [TestMethod]
        public void open_google_in_firefox() {
            var driver = WebDriverFactory.Firefox();
            driver.Navigate().GoToUrl("http://google.com/");
            driver.Quit();
        }
    }
}
