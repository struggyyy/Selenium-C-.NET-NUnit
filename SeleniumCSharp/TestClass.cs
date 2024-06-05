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

namespace SeleniumCSharp
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(0);
            element.SelectByText("mar");
            element.SelectByValue("6");

        }


        [Test,Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");

        }


        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);

        }

    }
}