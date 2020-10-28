
using NUnit.Framework;
using Registration.PageS;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Chrome;


namespace Registration
{
    class RegistrationsMale
    {
        private static ChromeDriver _driver;
        public object BаsеPages { get; private set; }

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
        public void RegistrationMale()
        {
            var BasePages = new basePage(_driver);
            var countries = new countries(_driver);

            countries.Navigate("https://www.1000000bet.com/");
         

             _driver.Manage().Window.Maximize();
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
           
        

            BasePages.MoveElementsRegMale();
         
            Assert.AreEqual("Let's activate your account!", "Let's activate your account!"); 

        }
    }
}
