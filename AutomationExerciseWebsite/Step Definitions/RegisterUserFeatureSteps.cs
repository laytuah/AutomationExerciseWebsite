using System;
using TechTalk.SpecFlow;
using AutomationExerciseWebsite.Hooks;
using AutomationExerciseWebsite.Pages;
using AutomationExerciseWebsite.Models;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace AutomationExerciseWebsite.Step_Definitions
{
    [Binding]
    public class RegisterUserFeatureSteps
    {
        Context context;
        Homepage homepage;
        LoginAndSignUpPage loginAndSignUpPage;
        SignUpFormPage signUpFormPage;

        public RegisterUserFeatureSteps(Context _context, Homepage _homepage, LoginAndSignUpPage _loginAndSignUpPage, SignUpFormPage _signUpFormPage)
        {
            context = _context; homepage = _homepage; loginAndSignUpPage = _loginAndSignUpPage; signUpFormPage = _signUpFormPage;
        }

        [Given(@"that you Launch browser and Navigate to url http://automationexercise\.com")]
        public void GivenThatYouLaunchBrowserAndNavigateToUrlHttpAutomationexercise_Com()
        {
            context.LoadAUT();
        }
        
        [When(@"you Click on Signup / Login button")]
        public void WhenYouClickOnSignupLoginButton()
        {
            homepage.ClickSingUpAndLoginButton();
        }
        
        [When(@"Enter signUp name and email address as:")]
        public void WhenEnterNameAndEmailAddressAs(Table table)
        {
            var signUpTableData = table.CreateInstance<SignUpModel>();
            loginAndSignUpPage.FillInNameTextField(signUpTableData.Name);
            loginAndSignUpPage.FillInSignUpEmailTextField(signUpTableData.SignUpEmailAddress);
        }
        
        [When(@"Click Signup button")]
        public void WhenClickSignupButton()
        {
            loginAndSignUpPage.ClickSignUpContinueButton();
        }
        
        [When(@"select '(.*)' from the title option")]
        public void WhenSelectFromTheTitleOption(string inputtedTitle)
        {
            signUpFormPage.SelectTitle(inputtedTitle);
        }
        
        //[When(@"Fill details as below:")]
        [When(@"fills in the password field with '(.*)'")]
        public void WhenFillsInThePasswordFieldWith(string passwordData)
        {
            signUpFormPage.FillInPasswordTextField(passwordData);
        }

        [When(@"selects from the '(.*)' '(.*)' '(.*)' from the Date Of Birth dropdowns")]
        public void WhenSelectsFromTheFromTheDateOfBirthDropdowns(string dayData, string monthData, string yearData)
        {
            signUpFormPage.SelectDateOfBirth(dayData, monthData,yearData) ;
        }

        [When(@"Select checkbox Sign up for our newsletter!")]
        public void WhenSelectCheckboxSignUpForOurNewsletter()
        {
            signUpFormPage.ClickNewsletterCheckbox();
        }
        
        [When(@"Select checkbox Receive special offers from our partners!")]
        public void WhenSelectCheckboxReceiveSpecialOffersFromOurPartners()
        {
            signUpFormPage.ClickOptInCheckbox();
        }
        
        [When(@"Fill details as below: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number")]
        public void WhenFillDetailsAsBelowFirstNameLastNameCompanyAddressAddressCountryStateCityZipcodeMobileNumber(Table table)
        {
            var signUpFormTable = table.CreateInstance<SignUpModel>();
            signUpFormPage.FillInFirstNameTextField(signUpFormTable.FirstName);
            signUpFormPage.FillInLastNameTextField(signUpFormTable.LastName);
            signUpFormPage.FillInCompanyTextField(signUpFormTable.Company);
            signUpFormPage.FillInAddressTextField(signUpFormTable.Address);
            signUpFormPage.FillInAddress2TextField(signUpFormTable.Address2);
            signUpFormPage.FillInStateTextField(signUpFormTable.State);
            signUpFormPage.FillInCityTextField(signUpFormTable.City);
            signUpFormPage.FillInZipCodeTextField(signUpFormTable.Zipcode);
            signUpFormPage.FillInMobileNumberTextField(signUpFormTable.MobileNumber);
        }

        [When(@"select '(.*)' from the country dropdown")]
        public void WhenSelectFromTheCountryDropdown(string countryData)
        {
            signUpFormPage.SelectCountry(countryData);
        }
        
        [When(@"Click Create Account button")]
        public void WhenClickCreateAccountButton()
        {
            signUpFormPage.ClickCreateAccountButton();
        }
        
        [When(@"Click Continue button")]
        public void WhenClickContinueButton()
        {
            signUpFormPage.ClickContinueSignUpButton();
        }
        
        [When(@"Click Delete Account button")]
        public void WhenClickDeleteAccountButton()
        {
            homepage.DeleteAccount();
        }

        [When(@"Enter login email and password as:")]
        public void WhenEnterLoginEmailAndPasswordAs(Table table)
        {
            var loginTable = table.CreateInstance<LogInModel>();
            loginAndSignUpPage.FillInLoginEmail(loginTable.LoginEmailAddress);
            loginAndSignUpPage.FillInLoginPassword(loginTable.LoginPassword);
        }

        [When(@"Click login button")]
        public void WhenClickLoginButton()
        {
            loginAndSignUpPage.ClickLoginButton();
        }

        [When(@"Click LogOut button")]
        public void WhenClickLogOutButton()
        {
            homepage.ClickLogOutLink();
        }

        [Then(@"Verify that '(.*)' is visible")]
        public void ThenVerifyThatIsVisible(string expectedAccountCreationConfirmation)
        {
            string actualAccountCreationConfirmation = homepage.ConfirmAccountCreation();
            Assert.IsTrue(actualAccountCreationConfirmation.Contains(expectedAccountCreationConfirmation));
        }

        [Then(@"Verify that '(.*)' is visible on the homepage")]
        public void ThenVerifyThatIsVisibleOnTheHomepage(string expectedLoggedInConfirmation)
        {
            string actualLoggedInConfirmation = homepage.ConfirmProfileLoggedIn();
            Assert.IsTrue(actualLoggedInConfirmation.Contains(expectedLoggedInConfirmation));
        }


        [Then(@"Verify that '(.*)' is visible and click Continue button")]
        public void ThenVerifyThatIsVisibleAndClickContinueButton(string expectedAccountDeletionConfirmation)
        {
            string actualAccountDeletionConfirmation = homepage.ConfirmAccountDeletion();
            Assert.IsTrue(actualAccountDeletionConfirmation.Contains(expectedAccountDeletionConfirmation));
        }

        [AfterScenario]
        public void CloseAUT()
        {
            context.CloseAUT();
        }
    }
}
