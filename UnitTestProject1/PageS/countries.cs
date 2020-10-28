using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Registration.PageS
{
    public partial class countries
    {
        private ChromeDriver _driver , Driver;
        public void Navigate(string url)
        {
            this.Driver.Url = url;
        }

        public countries(ChromeDriver driver)
        {
            _driver = driver;
        }

        public List<IWebElement> CountriesCheck => Driver.FindElements(By.ClassName("selectedLanguage")).ToList();

        //here I locate the menu selector for the types of languages in which the site is.
    }
}
