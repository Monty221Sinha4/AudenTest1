using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace AudenTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start Maximed");
            IWebDriver webDriver = new ChromeDriver(options);
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            webDriver.Navigate().GoToUrl("https://www.auden.com/short-term-loan");
            IWebElement textField = webDriver.FindElement(By.Name("loan-amount-value"));
            IWebElement sliderbutton = webDriver.FindElement(By.XPath('//"[@id="root"]/main/div/section/section[1]/div"));
           


        }
    }
}
