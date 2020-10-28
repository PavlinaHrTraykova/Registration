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
    //here I file  selector for the each of languages in which the site is.
    public List<IWebElement> CountriesCheck => Driver.FindElements(By.ClassName(".selectedLanguage")).ToList();


    //Selected Elements Registration as user Male
    public IWebElement RegistrationButtonMale => Driver.FindElement(By.CssSelector(".btn-sm .register-button"));
    public IWebElement SiginUPPageMale => Driver.FindElement(By.CssSelector(".modal-title.d-none"));

    internal static void Navigate(string v)
    {
        throw new NotImplementedException();
    }

    public IWebElement EmailMale => Driver.FindElement(By.Id("#reg_form_email"));

    public IWebElement UsernameMale => Driver.FindElement(By.Id("#reg_form_username"));

    public IWebElement NextButtonMale => Driver.FindElement(By.Id("#next-registration-step"));
    public IWebElement ContactDetailsmaleMale => Driver.FindElement(By.Id("#register-user-modal"));
    public IWebElement maleMale => Driver.FindElement(By.Id("#reg_form_gender_male"));
    public IWebElement FirstNameMale => Driver.FindElement(By.Id("#reg_form_fname"));
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
    public IWebElement FormSubmitButtonMale => Driver.FindElement(By.CssSelector(".btn-primary.form-submit-button"));


    //Selected Elements Registration as user Female
    public IWebElement RegistrationButton2 => Driver.FindElement(By.CssSelector(".btn-sm .register-button"));
    public IWebElement SiginUPPage => Driver.FindElement(By.CssSelector(".modal-title.d-none"));
    public IWebElement Email => Driver.FindElement(By.Id("#reg_form_email"));

    public IWebElement Username => Driver.FindElement(By.Id("#reg_form_username"));

    public IWebElement NextButton => Driver.FindElement(By.Id("#next-registration-step"));
    public IWebElement ContactDetails => Driver.FindElement(By.Id("#register-user-modal"));
    public IWebElement Female => Driver.FindElement(By.Id("#reg_form_gender_female"));
    public IWebElement FirstName => Driver.FindElement(By.Id("#reg_form_fname"));
    public IWebElement LastName => Driver.FindElement(By.Id("#reg_form_lname"));
    public IWebElement ChooseCountry => Driver.FindElement(By.Id("#reg_form_country_id"));
    public IWebElement SliderContryes => Driver.FindElement(By.Id("#reg_form_country_id"));

    public IWebElement ChooseCountryName => Driver.FindElement(By.Name("Bulgaria"));

    public IWebElement Currency => Driver.FindElement(By.Id("#reg_form_currency_id"));
    public IWebElement CurrencyChoose => Driver.FindElement(By.Name("Euro"));
    public IWebElement cell_phone => Driver.FindElement(By.Id("#reg_form_cell_phone"));


    public IWebElement Day => Driver.FindElement(By.Id("#reg_form_birthday_day"));
    public IWebElement Month => Driver.FindElement(By.Id("#reg_form_birthday_month"));
    public IWebElement Year => Driver.FindElement(By.Id("#reg_form_birthday_year"));

    public IWebElement submiRegForm => Driver.FindElement(By.Id("#submit-reg-form"));

    public IWebElement promotionsection => Driver.FindElement(By.CssSelector(".nav-link-label"));
    public IWebElement promotionText => Driver.FindElement(By.CssSelector(".promotion-text"));
    public IWebElement PromotionBox => Driver.FindElement(By.CssSelector(".promotion-box"));
    public IWebElement sectionTitleText => Driver.FindElement(By.CssSelector(".section-title"));
    public IWebElement GetBonusButton => Driver.FindElement(By.CssSelector("..btn-action.text-uppercase.submit-league-filter"));
    public IWebElement DepositTitle => Driver.FindElement(By.CssSelector(".section-title"));
    public IWebElement FieldAmount => Driver.FindElement(By.Id("#amount"));
    public IWebElement FormSubmitButton => Driver.FindElement(By.CssSelector(".btn-primary.form-submit-button"));


    //Move Elements Male

    public void MoveElementsRegMale()
    {
        this.RegistrationButtonMale.Click();
        this.SiginUPPageMale.Equals("SIGIN UP NOW");

        this.EmailMale.Click();
        this.EmailMale.SendKeys("p.pondeva@abv.bg");

        this.UsernameMale.Click();
        this.UsernameMale.SendKeys("PTraykov");

        this.NextButtonMale.Click();
        this.ContactDetails.Equals("Contact Details");
        this.maleMale.Click();

        this.FirstNameMale.Click();
        this.FirstNameMale.SendKeys("Pavel");
        this.LastNameMale.Click();
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


    //Move Elements Female
    public void MoveElementsRegFeale()

    {
        this.RegistrationButton2.Click();
        this.SiginUPPage.Equals("SIGIN UP NOW");

        this.Email.Click();
        this.Email.SendKeys("p.female@abv.bg");

        this.Username.Click();
        this.Username.SendKeys("P_Female");

        this.NextButton.Click();
        this.ContactDetails.Equals("Contact Details");
        this.Female.Click();

        this.FirstName.Click();
        this.FirstName.SendKeys("Petya");
        this.LastName.Click();
        this.LastName.SendKeys("Femaylova");

        this.ChooseCountry.Click();
        this.SliderContryes.Enabled.GetType();
        this.ChooseCountryName.Click();
        this.SliderContryes.Click();
        this.Currency.Click();
        this.CurrencyChoose.Click();

        this.cell_phone.Click();
        this.cell_phone.SendKeys("898991234");
        this.Day.Click();
        this.Day.SendKeys("25");
        this.Day.Submit();
        this.Month.Click();
        this.Month.SendKeys("May");
        this.Month.Submit();
        this.Year.Click();
        this.Year.SendKeys("1989");
        this.Year.Submit();

        this.submiRegForm.Submit();


        this.promotionsection.Click();
        this.promotionText.Equals("Get your 1000000bet casino bonus of 100% up to 500€ and start fresh now!");
        this.PromotionBox.Click();
        this.sectionTitleText.Equals("GET 100% UP TO 500€ WELCOME CASINO BONUS!");
        this.GetBonusButton.Click();

        this.DepositTitle.Equals("Deposit");
        this.FieldAmount.Click();
        this.FieldAmount.SendKeys("25");
        this.FormSubmitButton.Submit();

    }
        
    }
               
    

