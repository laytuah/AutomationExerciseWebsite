using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationExerciseWebsite.Hooks;

namespace AutomationExerciseWebsite.Pages
{
    public class Homepage
    {
        Context context;
        By signupAndloginLink = By.XPath("//a[@href='/login']");
        By deleteAccountLink = By.XPath("//a[@href='/delete_account']");
        By accountCreationConfirmationTxt = By.XPath("//h2[@data-qa]");
        By accountDeletionConfrimationTxt = By.XPath("//h2[@data-qa='account-deleted']");
        By logOutAccountLink = By.XPath("//a[@href='/logout']");
        By profileConfirmationText = By.XPath("//ul[@class='nav navbar-nav']/li[10]"); 
        public Homepage(Context _context )
        {
            context = _context;
        }

        public void ClickSingUpAndLoginButton()
        {
            context.driver.FindElement(signupAndloginLink).Click();
        }

        public void DeleteAccount()
        {
            context.driver.FindElement(deleteAccountLink).Click();
        }

        public string ConfirmAccountCreation()
        {
            return context.driver.FindElement(accountCreationConfirmationTxt).Text;
        }

        public string ConfirmAccountDeletion()
        {
            return context.driver.FindElement(accountDeletionConfrimationTxt).Text;
        }

        public void ClickLogOutLink()
        {
            context.driver.FindElement(logOutAccountLink).Click();
        }

        public string ConfirmProfileLoggedIn()
        {
            return context.driver.FindElement(profileConfirmationText).Text;
        }

    }
}
