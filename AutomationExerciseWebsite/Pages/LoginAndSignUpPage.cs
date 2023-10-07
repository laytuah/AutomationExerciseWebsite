using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationExerciseWebsite.Hooks;

namespace AutomationExerciseWebsite.Pages
{
    public class LoginAndSignUpPage
    {
        Context context;
        By nameTextField = By.XPath("//input[@name='name']");
        By signUpEmailAddressTextField = By.XPath("//input[@data-qa='signup-email']");
        By signUpContinueBtn = By.XPath("//button[@data-qa='signup-button']");
        By loginEmailTextfield = By.XPath("//input[@data-qa='login-email']");
        By loginPasswordTextfield = By.XPath("//input[@data-qa='login-password']"); 
        By loginBtn = By.XPath("//button[@data-qa='login-button']");
        public LoginAndSignUpPage(Context _context)
        {
            context = _context;
        }
        
        public void FillInNameTextField(string name)
        {
            context.driver.FindElement(nameTextField).Clear();
            context.driver.FindElement(nameTextField).SendKeys(name);
        }

        public void FillInSignUpEmailTextField(string singUpEmail)
        {
            context.driver.FindElement(signUpEmailAddressTextField).Clear();
            context.driver.FindElement(signUpEmailAddressTextField).SendKeys(singUpEmail);
        }

        public void ClickSignUpContinueButton()
        {
            context.driver.FindElement(signUpContinueBtn).Click();
        }

        public void FillInLoginEmail(string logInEmail)
        {
            context.driver.FindElement(loginEmailTextfield).Clear();
            context.driver.FindElement(loginEmailTextfield).SendKeys(logInEmail);
        }

        public void FillInLoginPassword(string logInPassword)
        {
            context.driver.FindElement(loginPasswordTextfield).Clear();
            context.driver.FindElement(loginPasswordTextfield).SendKeys(logInPassword);
        }

        public void ClickLoginButton()
        {
            context.driver.FindElement(loginBtn).Click();
        }
    }
}
