using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp
{
    [TestFixture]
    public class SeleniumCSharp4
    {
        [Test]
        [Author("Jakub", "jakub.strugala@microsoft.wsei.edu.pl")]
        [Description("Facebook login Verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://pl-pl.facebook.com/register";
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
                // IWebElement emailTextField = driver.FindElement(By.Name("abcd"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\strug\\source\\repos\\Selenium\\SeleniumCSharp\\Screenshots\\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver!=null)
                {
                    driver.Quit();
                }                   
            }           
        }


        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://pl-pl.facebook.com/register");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");

            return list;
        }

        //[Test]
        //[Author("Jakub", "jakub.strugala@microsoft.wsei.edu.pl")]
        //[Description("Facebook login Verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://pl-pl.facebook.com/register";
        //    IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}
    }
}
