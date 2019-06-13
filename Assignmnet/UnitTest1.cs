using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Assignmnet
{
       
    
    public class UnitTest1
    {
        public string FlightButton = "//button[@id='tab-flight-tab-hp']";
        public string MultiFlightButton = "//label[@id='flight-type-multi-dest-label-hp-flight']";
        public string FlyingFrom = "//input[@id='flight-origin-hp-flight']";
        public string Destination = "//input[@id='flight-destination-hp-flight']";
        public string DepartDate = "//input[@id='flight-departing-single-hp-flight']";
        public string TravelerNumber = "//li[@class='open']//button[@class='trigger-utility menu-trigger btn-utility btn-secondary dropdown-toggle theme-standard pin-left menu-arrow gcw-component gcw-traveler-amount-select gcw-component-initialized']";
        public string AddTravelers = "//body[@class='wrap cf aoa-enabled']/meso-native-marquee/section[@id='WizardHero']/div[@id='hero-banner']/div[@class='hero-banner-gradient native-marquee']/div[@class='cols-row hero-banner-inner']/section[@id='wizardSection']/div[@class='hero-banner-box siteId-27 cf hideClassicDcol']/div[@id='wizard-tabs']/div[@class='tabs-container col']/section[@id='section-flight-tab-hp']/form[@id='gcw-flights-form-hp-flight']/fieldset[@class='room-data']/div[@class='cols-nested']/div[@class='ab25184-traveler-wrapper-flight available-for-flights gcw-clear-both']/div[@id='traveler-selector-hp-flight']/div[@class='menu-bar gcw-travel-selector-wrapper']/ul[@class='menu-bar-inner']/li[@class='open']/div[@class='menu sticky gcw-menu']/div[@class='menu-main']/div[@class='traveler-selector-sinlge-room-data traveler-selector-room-data']/div[@class='uitk-grid step-input-outside gcw-component gcw-component-step-input gcw-step-input gcw-component-initialized']/div[@class='uitk-col all-col-shrink']/button[@class='uitk-step-input-button uitk-step-input-plus']/span[@class='uitk-icon']/*[1]";
        public string FlyFromSecond = "//input[@id='flight-2-origin-hp-flight']";
        public string DestiSecond= "//input[@id='flight-2-destination-hp-flight']";
        public string DepartDateSecond = "//input[@id='flight-2-departing-hp-flight']";
        public string FlyFromThird = "//input[@id='flight-3-origin-hp-flight']";
        public string DestiThird= "//input[@id='flight-3-destination-hp-flight']";
        public string DepartDateThird = "//input[@id='flight-3-departing-hp-flight']";
        public string AddAnotherFlightButton = "//a[@id='add-flight-leg-hp-flight']";
        public string SearchButton = "//form[@id='gcw-flights-form-hp-flight']//button[@class='btn-primary btn-action gcw-submit']";
        public string Url = "https://www.expedia.co.in/";
        public static IWebDriver driver;

       
         public void LaunchBrowser()
         {
             driver = new ChromeDriver(@"C:\Users\gauravrajpoot\source\repos\RestSharpAndExpedia\Assignmnet\Drivers");
             driver.Manage().Window.Maximize();
             driver.Navigate().GoToUrl("https://www.expedia.co.in/");
         }
        
 
        [TestMethod]

        public void SelectFlightAndMultiCityOption()

        {

            driver.FindElement(By.XPath("//*[@id='tab-flight-tab-hp']")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            driver.FindElement(By.XPath("//*[@id='flight-type-multi-dest-label-hp-flight']")).Click();

        }

        [TestMethod]

        public void zDatailsOfFlight1()

        {

            driver.FindElement(By.XPath("//*[@id='flight-origin-hp-flight']")).Click();

            driver.FindElement(By.XPath("//*[@id='flight-origin-hp-flight']")).SendKeys("Delhi, India");

            driver.FindElement(By.XPath("//*[@id='flight-destination-hp-flight']")).Click();

            driver.FindElement(By.XPath("//*[@id='flight-destination-hp-flight']")).SendKeys("Mumbai, India");

            driver.FindElement(By.XPath("//*[@id='flight-departing-single-hp-flight']")).Click();

            driver.FindElement(By.XPath("//*[@id='flight-departing-single-hp-flight']")).SendKeys("19/06/2019");

            driver.FindElement(By.XPath("/html/body/meso-native-marquee/section/div/div/div[1]/section/div[1]/div[2]/div[2]/section[1]/form/fieldset[2]/div/div[4]/div/div/ul/li/button")).Click();

            for (int i = 1; i <= 3; i++)

            {

                driver.FindElement(By.XPath("//body[contains(@class,'wrap cf aoa-enabled')]/meso-native-marquee/section[@id='WizardHero']/div[@id='hero-banner']/div[contains(@class,'hero-banner-gradient native-marquee')]/div[contains(@class,'cols-row hero-banner-inner')]/section[@id='wizardSection']/div[contains(@class,'hero-banner-box siteId-27 cf hideClassicDcol')]/div[@id='wizard-tabs']/div[contains(@class,'tabs-container col')]/section[@id='section-flight-tab-hp']/form[@id='gcw-flights-form-hp-flight']/fieldset[contains(@class,'room-data')]/div[contains(@class,'cols-nested')]/div[contains(@class,'ab25184-traveler-wrapper-flight available-for-flights gcw-clear-both')]/div[@id='traveler-selector-hp-flight']/div[contains(@class,'menu-bar gcw-travel-selector-wrapper')]/ul[contains(@class,'menu-bar-inner')]/li[contains(@class,'open')]/div[contains(@class,'menu sticky gcw-menu')]/div[contains(@class,'menu-main')]/div[contains(@class,'traveler-selector-sinlge-room-data traveler-selector-room-data')]/div[contains(@class,'uitk-grid step-input-outside gcw-component gcw-component-step-input gcw-step-input gcw-component-initialized')]/div[contains(@class,'uitk-col all-col-shrink')]/button[contains(@class,'uitk-step-input-button uitk-step-input-plus')]/span[contains(@class,'uitk-icon')]/*[1]")).Click();

            }

        }
    }
    
}

