using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationExerciseWebsite.Hooks;
using AutomationExerciseWebsite.Models;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomationExerciseWebsite.Pages
{
    public class SignUpFormPage
    {
        Context context;
        public SignUpFormPage(Context _context)
        {
            context = _context;
        }

        public void SelectTitle(string inputtedTitle)
        {
            IList<IWebElement> avalaibleTitles = context.driver.FindElements(titleSelector);
            foreach (IWebElement title in avalaibleTitles)
            {
                if (title.Text.Trim().Equals(inputtedTitle))
                {
                    title.Click();
                    break;
                }
            }
        }

        public void SelectDateOfBirth(string dayData, string monthData, string yearData)
        {
            SelectElement selectDay = new SelectElement(context.driver.FindElement(dayOfBirth)); selectDay.SelectByText(dayData);
            SelectElement selectMonth = new SelectElement(context.driver.FindElement(monthOfBirth)); selectMonth.SelectByText(monthData);
            SelectElement selectYear = new SelectElement(context.driver.FindElement(yearOfBirth)); selectYear.SelectByText(yearData);
        }

        public void SelectCountry(string countryData)
        {
            SelectElement selectCountry = new SelectElement(context.driver.FindElement(countryDropdown)); selectCountry.SelectByText(countryData); Thread.Sleep(1000);
        }

        public void FillInPasswordTextField(string passwordData)
        {
            context.driver.FindElement(passwordTextField).Clear();
            context.driver.FindElement(passwordTextField).SendKeys(passwordData);
        }

        public void ClickNewsletterCheckbox()
        {
            context.driver.FindElement(newsletterCheckbox).Click();
        }

        public void ClickOptInCheckbox()
        {
            context.driver.FindElement(optInCheckbox).Click();
        }

        public void FillInFirstNameTextField(string firstNameData)
        {
            context.driver.FindElement(firstNameTextField).Clear();
            context.driver.FindElement(firstNameTextField).SendKeys(firstNameData);
        }

        public void FillInLastNameTextField(string lastNameData)
        {
            context.driver.FindElement(lastNameTextField).Clear();
            context.driver.FindElement(lastNameTextField).SendKeys(lastNameData);
        }

        public void FillInCompanyTextField(string companyData)
        {
            context.driver.FindElement(companyTextField).Clear();
            context.driver.FindElement(companyTextField).SendKeys(companyData);
        }

        public void FillInAddressTextField(string addressData)
        {
            context.driver.FindElement(addressTextField).Clear();
            context.driver.FindElement(addressTextField).SendKeys(addressData);
        }

        public void FillInAddress2TextField(string address2Data)
        {
            context.driver.FindElement(address2TextField).Clear();
            context.driver.FindElement(address2TextField).SendKeys(address2Data);
        }

        public void FillInStateTextField(string stateData)
        {
            context.driver.FindElement(stateTextField).Clear();
            context.driver.FindElement(stateTextField).SendKeys(stateData);
        }

        public void FillInCityTextField(string cityData)
        {
            context.driver.FindElement(cityTextField).Clear();
            context.driver.FindElement(cityTextField).SendKeys(cityData);
        }

        public void FillInZipCodeTextField(string zipCodeData)
        {
            context.driver.FindElement(zipcodeTextField).Clear();
            context.driver.FindElement(zipcodeTextField).SendKeys(zipCodeData);
        }

        public void FillInMobileNumberTextField(string mobileNumberData)
        {
            context.driver.FindElement(mobileNumberTextField).Clear();
            context.driver.FindElement(mobileNumberTextField).SendKeys(mobileNumberData);
        }

        public void ClickCreateAccountButton()
        {
            context.driver.FindElement(createAccountBtn).Click();
        }

        public void ClickContinueSignUpButton()
        {
            context.driver.FindElement(continueSignUpBtn).Click();
        }

        By passwordTextField = By.Id("password");
        By firstNameTextField = By.Id("first_name");
        By lastNameTextField = By.Id("last_name");
        By companyTextField = By.Id("company");
        By addressTextField = By.Id("address1");
        By address2TextField = By.Id("address2");
        By stateTextField = By.Id("state");
        By cityTextField = By.Id("city");
        By zipcodeTextField = By.Id("zipcode");
        By mobileNumberTextField = By.Id("mobile_number");
        By createAccountBtn = By.XPath("//button[@data-qa='create-account']");
        By titleSelector = By.XPath("//div[@class='radio-inline']");
        By dayOfBirth = By.Id("days");
        By monthOfBirth = By.Id("months");
        By yearOfBirth = By.Id("years");
        By newsletterCheckbox = By.Id("newsletter");
        By optInCheckbox = By.Id("optin");
        By countryDropdown = By.Id("country");
        By continueSignUpBtn = By.XPath("//a[@data-qa='continue-button']");                              
    }
}
