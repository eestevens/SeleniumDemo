using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDemo.Page_Objects
{
    class WebPage
    {
        protected IWebDriver driver;

        public WebPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        protected void waitForElement(By location) {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementExists(location));
        }

        protected void enterKeys(By location, String text)
        {
            driver.FindElement(location).SendKeys(text);
        }

        protected void click(By location)
        {
            driver.FindElement(location).Click();
        }

        protected String getText(By location)
        {
            return driver.FindElement(location).Text;
        }


    }
}
