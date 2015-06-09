using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumDemo
{
    class SearchResult
    {
        private String resultTitle;
        private String linkLocation;
        private String description;
        private String recentHistory;

        public SearchResult(String resultTitle, String linkLocation, String description, String recentHistory)
        {
            this.resultTitle = resultTitle;
            this.linkLocation = linkLocation;
            this.description = description;
            this.recentHistory = recentHistory;
        }

        public SearchResult(String resultTitle, String linkLocation, String description)
        {
            this.resultTitle = resultTitle;
            this.linkLocation = linkLocation;
            this.description = description;
        }

        public String getResultTitle()
        {
            return resultTitle;
        }
    }
}
