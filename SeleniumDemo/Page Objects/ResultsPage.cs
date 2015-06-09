using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumDemo.Page_Objects
{
    class ResultsPage : HomePage
    {
        const String nthSearchResultXpath = "//div[@id='search']//li[*int*][@class='g']";
        String nthSearchResultTitle = nthSearchResultXpath + "//h3";
        const String nthSearchResultMoreInfo = nthSearchResultXpath + "//div[@class='s']";
        String nthSearchResultUrl = nthSearchResultMoreInfo + "//cite";
        String nthSearchResultDescription = nthSearchResultMoreInfo + "//em";
        String nthRecentHistory = nthSearchResultMoreInfo + "//*[@class='_Tib']";

        public ResultsPage(IWebDriver driver)
            : base(driver)
        {
            waitForElement(By.XPath(replaceIndex(nthSearchResultXpath, 1)));
        }

        public SearchResult getNthSearchResult(int index)
        {
            SearchResult result = null;
            String title = getText(By.XPath(replaceIndex(nthSearchResultTitle, index)));
            String linkLocation = getText(By.XPath(replaceIndex(nthSearchResultUrl, index)));
            String description = getText(By.XPath(replaceIndex(nthSearchResultDescription, index)));
           // String recentHistory = getText(By.XPath(replaceIndex(nthRecentHistory, index)));
            result = new SearchResult(title, linkLocation, description);


            return result;

        }

        public String replaceIndex(String xpath, int index)
        {
            return xpath.Replace("*int*", index.ToString());
        }


    }
}
