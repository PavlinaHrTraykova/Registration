
using NUnit.Framework;
using Registration.PageS;
using OpenQA.Selenium;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;



namespace Registration
{
    class TypeOfBrowsers
    {
        private static ChromeDriver _driver ;
        private static object Browser;

        public static object Browser1 { get => Browser; set => Browser = value; }
        [SetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        }

        [TearDown]
        public void Teadown()
        {
            _driver.Quit();
        }

        [Test]
        public void TypeOfBrowser()
        {
            var BasePages = new basePage(_driver);
            var countries = new countries(_driver);

            countries.Navigate("https://www.1000000bet.com/");


            _driver.Manage().Window.Maximize();          

        }


        public static void InitializeDriver(TestContext t)
            
        {
            IWebDriver WebDriver = null;


            if (WebDriver == null)
            {

                string DRIVER_PATH = @"C:\automation\driversFolder\";

                switch (Browser)
                {
                    case "OP":

                        WebDriver = new OperaDriver(DRIVER_PATH);

                        break;

                    case "FF":

                        WebDriver = new FirefoxDriver();
                        break;

                    case "CR":

                        WebDriver = new ChromeDriver(DRIVER_PATH);
                        break;

                    case "SF":

                        WebDriver = new SafariDriver(DRIVER_PATH);
                        break;

                    default:
                        WebDriver = new FirefoxDriver();
                        break;

                }

            }

        }
      

    }
}
