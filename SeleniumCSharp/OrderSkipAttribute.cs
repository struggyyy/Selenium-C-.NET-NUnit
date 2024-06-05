using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumCSharp
{
    [TestFixture]
    public class OrderSkipAttribute
    {

        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://pl-pl.facebook.com/register";
            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            Assert.Ignore("There is no Firefox installed!");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://pl-pl.facebook.com/register";
            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            Assert.Ignore("InternetExplorer no longer exists!!!");
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://pl-pl.facebook.com/register";
            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}