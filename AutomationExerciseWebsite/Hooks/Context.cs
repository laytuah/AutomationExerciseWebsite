using AutomationExerciseWebsite.Browsers;
using BoDi;
using OpenQA.Selenium;

namespace AutomationExerciseWebsite.Hooks
{
    public class Context
    {
        ChromeBrowserFactory chromeBrowserFactory;
        string baseUrl = "http://automationexercise.com";
        public IWebDriver driver;
        private readonly IObjectContainer objectContainer;

        public Context(ChromeBrowserFactory _chromeBrowserFactory, IObjectContainer objectContainer)
        {
            chromeBrowserFactory = _chromeBrowserFactory;  this.objectContainer = objectContainer;
        }

        public void LoadAUT()
        {
            driver = chromeBrowserFactory.Create(objectContainer);
            driver.Navigate().GoToUrl(baseUrl);
        }
        
        public void CloseAUT()
        {
            driver.Quit();
        }
    }
}
