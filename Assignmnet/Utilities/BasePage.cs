using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet.Utilities
{
    public class BasePage:Constants
    {


        public static IWebDriver driver;
        public void invokeDriver()
        {
            driver = new ChromeDriver(@"C:\Users\akshaygupta\Downloads\chromedriver_win32 (1)");
            driver.Manage().Window.Maximize();
        }
        public void closeDriver()
        {
            driver.Quit();
        }

       
       public void elementclick(string a)
        {
        driver.FindElement(By.XPath(a)).Click();

        }

        public void elementsendkeys(string a,string Place)
        {
            driver.FindElement(By.XPath(a)).SendKeys(Place);
        }

    }
}
