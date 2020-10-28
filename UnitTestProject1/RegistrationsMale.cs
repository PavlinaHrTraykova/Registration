using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Registration.PageS;
using OpenQA.Selenium;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Chrome;
using NUnit;
using Registration;

namespace Registration
{
    class RegistrationsMale
    {
        private static ChromeDriver _driver;
        public object BаsеPages { get; private set; }

        [SetUp]
        static void SetUp()
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

            BasePages.MoveElementsRegMale();
            Assert.AreEqual("Let's activate your account!", "Let's activate your account!"); 

        }
    }
}
