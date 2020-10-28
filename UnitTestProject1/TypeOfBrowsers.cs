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
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;

namespace Registration
{
    class TypeOfBrowsers
    {
        private static object Browser;

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
