using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation
{
/*
    class Params
    {
        public static string[] Xpathes = 
        {
         "//div[@class='TxtUserName']/input[@class='TxtUserName']",
         "//div[@class='TxtPassword']/input[@class='TxtPassword']",
         "//div[@class='BtnLogin']/a[@class='BtnLogin']",
         "//div[@class='SearchButton']/a[@class='SearchButton']",
         "//div[@class='txtName']/input[1]",
         "//div[@class='optionAgent']/input[1]",
         "//div[@class='save']/a[@class='button']",
         "//div[@class='BtnLogin']/a[@class='BtnLogin']",
         "//div[@class='SearchButton']/a[@class='SearchButton']",
         "//div[@class='rmText']/a[@class='rmLink']"
        };

    }
 */
    public class Params
    {

        public static Dictionary<string, string> s = new Dictionary<string,string>
        {
           
            {"TxtUserName", "//div[@class='TxtUserName']/input[@class='TxtUserName']"}, //Login element, field for input user name
              
            {"TxtPassword", "//div[@class='TxtPassword']/input[@class='TxtPassword']"},  //Login element, field for input password
              
            {"BtnLogin", "//div[@class='BtnLogin']/a[@class='BtnLogin']"},  //Login element, field for press button "Send"
           
            {"FreetextCriteriaTextPanel", "//div[@class='FreetextCriteriaTextPanel']/div[@class='textBox']/input"},   //Search field "Keywords" on front page 

            {"areaCriteriaTextPanel", "//div[@class='areaCriteriaTextPanel']/div[@class='textBox']/input"},   //Search field "Location" on front page 
           
            {"buttonSpan", "//span[@class='buttonSpan']"}, //Button  "Send" on front page 

            {"TextHyperLink", "//div[@class='TextHyperLink']/a"}, //Button  "Send" on front page 

            {"TextBoxUserName", "//div[@class='TextBoxUserName']/input[@class='TextBox UserName']"}, //Login element, field for input user name
              
            {"TextBoxPassword", "//div[@class='TextBoxPassword']/input[@class='TextBox Password']"},  //Login element, field for input password
              
            {"ButtonLogin", "//div[@class='ButtonLogin']/input[@class='Button Login']"},  //Login element, field for press button "Send"
            
            //Nordjyskejob
            {"NordjyskejobTextBoxUserName", "//div[@class='EmailBox']/input[@class='TextBoxEmail']"}, //Login element, field for input user name
              
            {"NordjyskejobTextBoxPassword", "//div[@class='PasswordBox']/input"},  //Login element, field for input password
              
            {"NordjyskejobButtonLogin", "//div[@class='LoginButton']/input[@class='LoginButton']"},  //Login element, field for press button "Send"


            
            {"buttonSpanSend", "//a[@class='SearchButton']"}, //Button  "Send" on front page for all sites
            
            //First job from list of the jobs on search result page
             {"ResultsDisplayControl", "div.ResultsDisplayControl div[class=HeadingContainer]"},
            //{"ResultsDisplayControl", "//div[@class='^ResultListElementEven']"},
            
            //{"ResultsDisplayControl", "//div[@class='ResultsDisplayControl']"},
            // div[@class='^ResultListElementEven']
        };

    }



    [TestFixture]
    public class Driver
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Create a new instance of the Firefox driver
            driver = new FirefoxDriver();
           // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15)); -- 15 02 2014
            //driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
   
 
  
        //28
        [TestCase("http://jobs24.int.matchwork.com/jobs", "test", "test Jobs in - Jobs24.co.uk", "title")]
        [TestCase("http://cambridge-jobsnow.int.matchwork.com/", "test", "test jobs | JobsNow.co.uk", "title")]
        [TestCase("http://hertsessex-jobsnow.int.matchwork.com/", "test", "test jobs | JobsNow.co.uk", "title")]
        [TestCase("http://bedsbucks-jobsnow.int.matchwork.com/", "test", "test jobs | JobsNow.co.uk", "title")]
        [TestCase("http://staffordshire-jobsnow.int.matchwork.com/", "test", "test jobs | JobsNow.co.uk", "title")]
        [TestCase("http://jobunivers.int.matchwork.com", "test", "Ledige stillinger inden for test - Djøf Jobunivers", "title")]
        [TestCase("http://bibliotekarjob.int.matchwork.com", "test", "Bibiliotekarjob - Ledige stillinger inden for bibliotek og information i test", "title")]
        [TestCase("http://magisterjob.int.matchwork.com", "test", "Ledige stillinger inden for test - Magisterjob", "title")]
        [TestCase("http://socialraadgiverjob.int.matchwork.com", "test", "Ledige stillinger inden for test - Socialrådgiverjob", "title")]
        [TestCase("http://profiljob.int.matchwork.com", "test", "Ledige stillinger inden for test - Profiljob", "title")]
        [TestCase("http://hkkommunaljob.int.matchwork.com", "test", "Ledige stillinger inden for test - HK Kommunaljob", "title")]
        [TestCase("http://tandlaegejob.int.matchwork.com", "test", "Ledige stillinger inden for test - Tandlægejob", "title")]
        [TestCase("http://hkstatjob.int.matchwork.com", "test", "Ledige stillinger inden for test - HK/STAT JOB", "title")]
        [TestCase("http://journalistjob.int.matchwork.com", "test", "Ledige stillinger inden for test - Journalistjob", "title")]
        [TestCase("http://gymnasieskolejob.int.matchwork.com", "test", "Ledige stillinger inden for test - Gymnasie skole job", "title")]
        [TestCase("http://it-jobdatabasen.int.matchwork.com", "test", "Ledige stillinger inden for test - it-jobdatabasen", "title")]
        [TestCase("http://jordogvidenjob.int.matchwork.com", "test", "Ledige stillinger inden for test - jordogvidenjob", "title")]
        [TestCase("http://danskekommunerjob.int.matchwork.com", "test", "Ledige stillinger inden for test - danskekommunerjob.dk", "title")]
        [TestCase("http://slp.int.matchwork.com", "test", "test jobs - slp.int.matchwork.com", "title")]
        [TestCase("http://nlh.int.matchwork.com", "test", "test jobs - nlh.int.matchwork.com", "title")]
        [TestCase("http://ya.int.matchwork.com", "test", "test jobs - ya.int.matchwork.com", "title")]
        [TestCase("http://fcn.int.matchwork.com", "test", "test jobs - fcn.int.matchwork.com", "title")]
        [TestCase("http://clickin2jobs.int.matchwork.com", "test", "test jobs - Clickin2jobs.co.uk", "title")]
        [TestCase("http://hiaz.int.matchwork.com", "test", "Hildesheimer Allgemeine Zeitung", "title")]
        [TestCase("http://psjobsearch.int.matchwork.com", "test", "test jobs - psjobsearch.int.matchwork.com", "title")]
        [TestCase("http://job-i-staten.int.matchwork.com", "test", "test - job-i-staten.dk", "title")]
        [TestCase("http://kentjobs.int.matchwork.com", "test", "test jobs - kentjobs.int.matchwork.com", "title")]
        [TestCase("http://scienceomega.int.matchwork.com", "test", "test jobs - scienceomega.int.matchwork.com", "title")]

        //Check title on search result page (using Keywords field on front page links)
        [Test]
        public void TitleOnSearchResultPageUsingKeywords(string url, string searchtext, string checkresult, string title)
        {
            KeywordsSearchFromFrontPage(url, searchtext);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //driver.Url = url;
            IWebElement myDynamicElement = driver.FindElement(By.TagName(title));
            Assert.AreEqual(checkresult, driver.Title);
        }

  
  
        //14
        [TestCase("http://jobs24.int.matchwork.com/jobs", "London", "Jobs in London - Jobs24.co.uk", "title")]
        [TestCase("http://cambridge-jobsnow.int.matchwork.com/", "Ashbourne", "Ashbourne jobs | JobsNow.co.uk", "title")]
        [TestCase("http://hertsessex-jobsnow.int.matchwork.com/", "Ashbourne", "Ashbourne jobs | JobsNow.co.uk", "title")]
        [TestCase("http://bedsbucks-jobsnow.int.matchwork.com/", "Bedford", "Bedford jobs | JobsNow.co.uk", "title")]
        [TestCase("http://staffordshire-jobsnow.int.matchwork.com/", "Ashbourne", "Ashbourne jobs | JobsNow.co.uk", "title")]
        [TestCase("http://slp.int.matchwork.com", "London", "London jobs - slp.int.matchwork.com", "title")]
        [TestCase("http://nlh.int.matchwork.com", "London", "London jobs - nlh.int.matchwork.com", "title")]
        [TestCase("http://ya.int.matchwork.com", "London", "London jobs - ya.int.matchwork.com", "title")]
        [TestCase("http://fcn.int.matchwork.com", "London", "London jobs - fcn.int.matchwork.com", "title")]
        [TestCase("http://clickin2jobs.int.matchwork.com", "Carlisle", "Carlisle jobs - Clickin2jobs.co.uk", "title")]
        [TestCase("http://hiaz.int.matchwork.com", "Berlin", "Hildesheimer Allgemeine Zeitung", "title")]
        [TestCase("http://psjobsearch.int.matchwork.com", "London", "London jobs - psjobsearch.int.matchwork.com", "title")]
        [TestCase("http://kentjobs.int.matchwork.com", "Kent", "Kent jobs - kentjobs.int.matchwork.com", "title")]
        [TestCase("http://scienceomega.int.matchwork.com", "London", "London jobs - scienceomega.int.matchwork.com", "title")]

        //Check title on search result page (using Location field on front page links)
        [Test]
        public void TitleOnSearchResultPageUsingLocation(string url, string searchtext, string checkresult, string title)
        {
            LocationSearchFromFrontPage(url, searchtext);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //driver.Url = url;
            IWebElement myDynamicElement = driver.FindElement(By.TagName(title));
            Assert.AreEqual(checkresult, driver.Title);
        }
 
  
        
        //31
        [TestCase("http://jobs24.int.matchwork.com/SearchResults.aspx", "Jobs24.co.uk RSS feed", "title")]
        [TestCase("http://kentjobs.int.matchwork.com/SearchResults.aspx", "Kentjobs RSS feed", "title")]
        [TestCase("http://cambridge-jobsnow.int.matchwork.com/SearchResults.aspx", "JobsNow RSS feed", "title")]
        [TestCase("http://hertsessex-jobsnow.int.matchwork.com/SearchResults.aspx", "JobsNow RSS feed", "title")]
        [TestCase("http://bedsbucks-jobsnow.int.matchwork.com/SearchResults.aspx", "JobsNow RSS feed", "title")]
        [TestCase("http://staffordshire-jobsnow.int.matchwork.com/SearchResults.aspx", "JobsNow RSS feed", "title")]
        [TestCase("http://jobsthamesvalley.int.matchwork.com/SearchResults.aspx", "Jobsthamesvalley.co.uk RSS feed", "title")]
        [TestCase("http://slp.int.matchwork.com/SearchResults.aspx", "southlondon-jobs.co.uk RSS feed", "title")]
        [TestCase("http://nlh.int.matchwork.com/SearchResults.aspx", "www.northlondon-jobs.co.uk RSS feed", "title")]
        [TestCase("http://ya.int.matchwork.com/SearchResults.aspx", "www.essexjobs-today.co.uk RSS feed", "title")]
        [TestCase("http://fcn.int.matchwork.com/SearchResults.aspx", "www.jobs-surreyandhants.co.uk RSS feed", "title")]
        [TestCase("http://scienceomega.int.matchwork.com/SearchResults.aspx", "scienceomegajobsearch.com RSS feed", "title")]
        [TestCase("http://nordjyskejob.int.matchwork.com/SearchResults.aspx", "Annoncer fra nordjyskejob.dk", "title")]
        [TestCase("http://jobunivers.int.matchwork.com/resultat.aspx", "Jobunivers.dk RSS feed", "title")]
        [TestCase("http://bibliotekarjob.int.matchwork.com/resultat.aspx", "Bibliotekarjob.dk RSS feed", "title")]
        [TestCase("http://magisterjob.int.matchwork.com/resultat.aspx", "Magisterjob.dk RSS feed", "title")]
        [TestCase("http://socialraadgiverjob.int.matchwork.com/resultat.aspx", "Socialrådgiverjob.dk RSS feed", "title")]
        [TestCase("http://profiljob.int.matchwork.com/resultat.aspx", "Profiljob.dk RSS feed", "title")]
        [TestCase("http://hkkommunaljob.int.matchwork.com/resultat.aspx", "hkkommunaljob.dk RSS feed", "title")]
        [TestCase("http://tandlaegejob.int.matchwork.com/resultat.aspx", "Tandlaegejob.dk RSS feed", "title")]
        [TestCase("http://hkstatjob.int.matchwork.com/resultat.aspx", "Hkststjob.dk RSS feed", "title")]
        [TestCase("http://journalistjob.int.matchwork.com/resultat.aspx", "Journalistjob.dk RSS feed", "title")]
        [TestCase("http://gymnasieskolejob.int.matchwork.com/resultat.aspx", "Gymnasieskolejob.dk RSS feed", "title")]
        [TestCase("http://it-jobdatabasen.int.matchwork.com/resultat.aspx", "Itjobdatabasen.dk RSS feed", "title")]
        [TestCase("http://jordogvidenjob.int.matchwork.com/resultat.aspx", "Jordogvidenjob.dk RSS feed", "title")]
        [TestCase("http://danskekommunerjob.int.matchwork.com/resultat.aspx", "Danskekommunerjob.dk RSS feed", "title")]
        [TestCase("http://markedsforingjob.int.matchwork.com/resultat.aspx", "Markedsforingjob.dk RSS feed", "title")]
        [TestCase("http://magnus.int.matchwork.com/SearchResults.aspx", "job.magnus.dk RSS feed", "title")]
        [TestCase("http://clickin2jobs.int.matchwork.com/SearchResults.aspx", "clickin2jobs RSS feed", "title")]
        [TestCase("http://psjobsearch.int.matchwork.com/SearchResults.aspx", "PSjobsearch.co.uk RSS feed", "title")]
        [TestCase("http://job-i-staten.int.matchwork.com/SearchResults.aspx", "Annoncer fra job-i-staten", "title")]
 
        //Check RSS news page
        [Test]
        public void RSSNewsPage(string url, string checkRssnews, string title)
        {
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath(Params.s["TextHyperLink"])).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //driver.Url = url;
            IWebElement myDynamicElement = driver.FindElement(By.TagName(title));
            Assert.AreEqual(checkRssnews, driver.Title);
        }

        //Method that allows advertisers log on.
        private void AdvertiserLogIn(string url, string email, string password)
        {
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath(Params.s["TextBoxUserName"])).SendKeys(email);
            driver.FindElement(By.XPath(Params.s["TextBoxPassword"])).SendKeys(password);
            driver.FindElement(By.XPath(Params.s["ButtonLogin"])).Click();
        }
      
        //Method that allows log on user
        private void LoginOnFrontPageMehod(string url, string email, string password)
        {

            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath(Params.s["TxtUserName"])).SendKeys(email);
            driver.FindElement(By.XPath(Params.s["TxtPassword"])).SendKeys(password);
            driver.FindElement(By.XPath(Params.s["BtnLogin"])).Click();
            
        }

        //Method that make search on front page using keywords
        private void KeywordsSearchFromFrontPage(string url, string searchtext)
        {
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath(Params.s["FreetextCriteriaTextPanel"])).Clear();
            driver.FindElement(By.XPath(Params.s["FreetextCriteriaTextPanel"])).SendKeys(searchtext);
            driver.FindElement(By.XPath(Params.s["buttonSpanSend"])).Click();
        }

        //Method that make search on front page using Location
        private void LocationSearchFromFrontPage(string url, string searchtext)
        {
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath(Params.s["areaCriteriaTextPanel"])).SendKeys(searchtext);
            driver.FindElement(By.XPath(Params.s["buttonSpanSend"])).Click();
        }


    }
/*
    [TestFixture]
    public class Driver2
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Create a new instance of the Firefox driver
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            //driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [TestCase("http://cambridge-jobsnow.int.matchwork.com", "mwap@matchwork.com", "220389", "Logout")]
        [TestCase("http://hertsessex-jobsnow.int.matchwork.com", "mwap@matchwork.com", "220389", "Logout")]
        [TestCase("http://bedsbucks-jobsnow.preview.matchwork.com", "mwap@matchwork.com", "220389", "Logout")]
        [TestCase("http://staffordshire-jobsnow.preview.matchwork.com", "mwap@matchwork.com", "220389", "Logout")]
        [TestCase("http://jobunivers.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://bibliotekarjob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://magisterjob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://socialraadgiverjob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]

        [TestCase("http://profiljob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://hkkommunaljob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://tandlaegejob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://hkstatjob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://journalistjob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://gymnasieskolejob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://it-jobdatabasen.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://jordogvidenjob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Velkommen til din personlige side på Jordogvidenjob")]
        [TestCase("http://danskekommunerjob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://profiljob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://markedsforingjob.int.matchwork.com/min-side/log-ind.aspx", "mwap@matchwork.com", "220389", "Log ud")]
        [TestCase("http://magnus.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "Logout")]
        [TestCase("http://scienceomega.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "You are logged on as")]
        [TestCase("http://fcn.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "You are logged on as")]
        [TestCase("http://ya.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "You are logged on as")]
        [TestCase("http://nlh.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "You are logged on as")]
        [TestCase("http://slp.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "You are logged on as")]
        [TestCase("http://nordjyskejob.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "Log af")]
        [TestCase("http://jobsthamesvalley.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "You are logged on as")]
        [TestCase("http://kentjobs.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "Logout")]

        //[TestCase("http://jobs24.int.matchwork.com/jobs.aspx", "mwap@matchwork.com", "220389", "Log")]

        [TestCase("http://job-i-staten.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "Velkommen til din side på Job-i-Staten")]
        [TestCase("http://psjobsearch.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "You are logged on as")]
        [TestCase("http://hiaz.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "Logout")]
        [TestCase("http://clickin2jobs.int.matchwork.com/MyPage/Login.aspx", "mwap@matchwork.com", "220389", "You are logged on as")]

        //Check that user can login to the front page
        [Test]
        public void LoginFrontPage(string url, string email, string password, string confirmdata)
        {
            LoginOnFrontPageMehod(url, email, password);
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            //driver.Manage().Timeouts().ImplicitlyWait(10, TimeUnit.5);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            Assert.IsTrue(driver.PageSource.Contains(confirmdata));
        }

        private void LoginOnFrontPageMehod(string url, string email, string password)
        {

            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath(Params.s["TxtUserName"])).SendKeys(email);
            driver.FindElement(By.XPath(Params.s["TxtPassword"])).SendKeys(password);
            driver.FindElement(By.XPath(Params.s["BtnLogin"])).Click();
        }

    }
*/
}