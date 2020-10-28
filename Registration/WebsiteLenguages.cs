﻿//testing comment

namespace RegistrationForm.BasePages
{
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


    public class WebsiteLenguages
    {
        private static ChromeDriver _driver;
        public object BesaPages { get; private set; }        

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
        public void CountriesChek()
        { 
            var BasePages = new basePage(_driver);
            var countries = new countries(_driver);
            
            countries.Navigate("https://www.1000000bet.com/");            
            
              _driver.Manage().Window.Maximize();
            
            var CountryLenguageName = countries.CountriesCheck; 
            List<string> ListOfCountrysName = new List<string>();

            foreach (var element in CountryLenguageName)
            {
                string url = "https://www.1000000bet.com/" + element;
                countries.Navigate(url);          
                                                
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                screenshot.SaveAsFile(Path.GetFullPath(@"../../../ScreenShots")
                    + TestContext.CurrentContext.Test.Name + ".png", ScreenshotImageFormat.Png);
                    
            }
        }       
    }      
       
}
