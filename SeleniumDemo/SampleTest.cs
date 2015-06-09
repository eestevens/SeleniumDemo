using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDemo.Page_Objects;

namespace SeleniumDemo
{
    /// <summary>
    /// Summary description for Sample Test
    /// </summary>
    [TestClass]
    public class SampleTest
    {
        String browser = "chrome";
        protected IWebDriver driver;

  



        #region Additional test attributes
    

   
        //
        // Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize() {
            initializeBrowser(browser);
        
        }
        //
        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup() {
            closeBrowser();
        }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            String expectedTitle = "Corporate Technology Solutions, Inc. - Milwaukee";
            driver.Navigate().GoToUrl("http://www.google.com");
            HomePage homePage = new HomePage(driver);
            homePage.setSearchTerms("Corporate Technology Solutions");
            ResultsPage results = homePage.enterSearch();
            SearchResult result = results.getNthSearchResult(1);
            String pageTitle = result.getResultTitle();
            Assert.IsTrue(result.getResultTitle().Equals(expectedTitle), "Expected title is correct");
        }

        public void initializeBrowser(String browserName)
        {
            if(browserName.Equals("chrome")) {
                initializeChrome();

            }

        }

        public void initializeChrome()
        {
            driver = new ChromeDriver("C:\\Users\\estevens\\Documents\\Visual Studio 2010\\Projects\\SeleniumDemo\\SeleniumItems");


        }

        public void closeBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
