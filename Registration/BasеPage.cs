using Registration.PageS;
using OpenQA.Selenium;
using System.Drawing;
using System.Collections.Generic;    
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

    public class basePage
{ 
    public basePage(IWebDriver driver)
    {
        Driver = driver;
    }
    public IWebDriver Driver { get; set; }
    public void NavigateTo(string url)
    {
        this.Driver.Url = url;
    }
    
    public List<IWebElement> CountriesCheck => Driver.FindElements(By.ClassName(".selectedLanguage")).ToList();
              
    internal static void Navigate(string v)
    {
        
    }
    public IWebElement RegistrationButtonMale => Driver.FindElement(By.CssSelector(".header-register-button"));
    public IWebElement SiginUPPageMale => Driver.FindElement(By.CssSelector(".modal-title.d-none"));

    public IWebElement EmailMale => Driver.FindElement(By.Name("reg_form[email]"));

    public IWebElement UsernameMale => Driver.FindElement(By.Name("reg_form[username]"));

    public IWebElement UserpasswordMale => Driver.FindElement(By.Name("reg_form[password]"));




    public IWebElement NextButtonMale => Driver.FindElement(By.XPath("/html/body/div[6]/div/div/div[2]/div[2]/div/form/div/div[2]/button"));

    public IWebElement FirstNameMale => Driver.FindElement(By.XPath("/html/body/div[6]/div/div/div[2]/div[2]/div/form/div/div[3]/div[2]/div/input"));
    
    public IWebElement LastNameMale => Driver.FindElement(By.Id("#reg_form_lname"));
    public IWebElement ChooseCountryMale => Driver.FindElement(By.Id("#reg_form_country_id"));
    public IWebElement SliderContryesMale => Driver.FindElement(By.Id("#reg_form_country_id"));

    public IWebElement ChooseCountryNameMale => Driver.FindElement(By.Name("Bulgaria"));

    public IWebElement CurrencyMale => Driver.FindElement(By.Id("#reg_form_currency_id"));
    public IWebElement CurrencyChooseMale => Driver.FindElement(By.Name("Euro"));
    public IWebElement cell_phoneMale => Driver.FindElement(By.Id("#reg_form_cell_phone"));


    public IWebElement DayMale => Driver.FindElement(By.Id("#reg_form_birthday_day"));
    public IWebElement MonthMale => Driver.FindElement(By.Id("#reg_form_birthday_month"));
    public IWebElement YearMale => Driver.FindElement(By.Id("#reg_form_birthday_year"));

    public IWebElement submiRegFormMale => Driver.FindElement(By.Id("#submit-reg-form"));


    public IWebElement promotionsectionMale => Driver.FindElement(By.CssSelector(".nav-link-label"));
    public IWebElement promotionTextMale => Driver.FindElement(By.CssSelector(".promotion-text"));
    public IWebElement PromotionBoxMale => Driver.FindElement(By.CssSelector(".promotion-box"));
    public IWebElement sectionTitleTextMale => Driver.FindElement(By.CssSelector(".section-title"));
    public IWebElement GetBonusButtonMale => Driver.FindElement(By.CssSelector("..btn-action.text-uppercase.submit-league-filter"));
    public IWebElement DepositTitleMale => Driver.FindElement(By.CssSelector(".section-title"));
    public IWebElement FieldAmountMale => Driver.FindElement(By.Id("#amount"));
    public IWebElement FormSubmitButtonMale => Driver.FindElement(By.ClassName(".btn-primary.form-submit-button"));

    public IWebElement SwitchTab => Driver.FindElement(By.Id("c102m"));

    //Move Elements Male

    public void MoveElementsRegMale()
    {
        this.RegistrationButtonMale.Click();
        this.SiginUPPageMale.Equals("SIGIN UP NOW");

        this.EmailMale.Click();
        this.EmailMale.SendKeys("traykova44@gmail.com");

        this.UsernameMale.Click();
        this.UsernameMale.SendKeys("PTraykov");

        this.UserpasswordMale.Click();
        this.UserpasswordMale.SendKeys("123123");

        this.NextButtonMale.Submit();
        

        this.FirstNameMale.Click();
        this.FirstNameMale.SendKeys("Pavel");

       this.LastNameMale.Submit();
        this.LastNameMale.SendKeys("Traykov");

        this.ChooseCountryMale.Click();
        this.SliderContryesMale.Enabled.GetType();
        this.ChooseCountryNameMale.Click();
        this.SliderContryesMale.Click();
        this.CurrencyMale.Click();
        this.CurrencyChooseMale.Click();

        this.cell_phoneMale.Click();
        this.cell_phoneMale.SendKeys("878718778");
        this.DayMale.Click();
        this.DayMale.SendKeys("31");
        this.DayMale.Submit();
        this.MonthMale.Click();
        this.MonthMale.SendKeys("May");
        this.MonthMale.Submit();
        this.YearMale.Click();
        this.YearMale.SendKeys("1988");
        this.YearMale.Submit();

        this.submiRegFormMale.Submit();

        this.promotionsectionMale.Click();
        this.promotionTextMale.Equals("Get your 1000000bet casino bonus of 100% up to 500€ and start fresh now!");
        this.PromotionBoxMale.Click();
        this.sectionTitleTextMale.Equals("GET 100% UP TO 500€ WELCOME CASINO BONUS!");
        this.GetBonusButtonMale.Click();

        this.DepositTitleMale.Equals("Deposit");
        this.FieldAmountMale.Click();
        this.FieldAmountMale.SendKeys("50");
        this.FormSubmitButtonMale.Submit();
    }

}
        
   
               
    

