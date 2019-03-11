using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace PaintCalculatorAutomation.Utilities
{
    public abstract class DriverHelper
    {
        public static IWebDriver GetDriver()
        {
            ChromeDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Navigate().GoToUrl("http://paint-calc.com/");
            return driver;
        }
    }
}
