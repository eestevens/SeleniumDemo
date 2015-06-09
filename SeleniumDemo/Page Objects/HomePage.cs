using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumDemo.Page_Objects
{
    class HomePage : WebPage
    {
        private By searchBar = By.Name("q");
        private By enterSearchButton = By.Name("btnG");

        public HomePage(IWebDriver driver) : base(driver)
        {
            waitForElement(searchBar);
        }

        public void setSearchTerms(String searchTerms) {
            enterKeys(searchBar, searchTerms);
        }

        public ResultsPage enterSearch() {
            click(enterSearchButton);
            return new ResultsPage(driver);
        }
    }
}
