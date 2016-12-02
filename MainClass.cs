using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;


namespace UptakeAutomation
{
    public class MainClass
    {
        private readonly By BlogBtn = By.XPath("//*[@id='menu-item-4166']/a");
        private readonly By UpTakeBtn = By.CssSelector("a[href ^= 'http://www.uptake.com']");
       // private IWebDriver driver = new FirefoxDriver();
        public void UptakeTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://uptake.com/");
            driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Contains("Uptake"), "Incorrect page loaded: found" + driver.Title);
            IWebElement BlogButn = driver.FindElement(BlogBtn);
            BlogButn.Click();
            Assert.IsTrue(driver.Title.Contains("Blog"), "Incorrect page loaded: found" + driver.Title);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            IWebElement UpTakeButn = driver.FindElement(UpTakeBtn);
            UpTakeButn.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Assert.IsTrue(driver.Title.Contains("Uptake"), "Incorrect page loaded: found" + driver.Title);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.Close();
        }

    }
}
