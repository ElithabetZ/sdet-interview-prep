using OpenQA.Selenium;

namespace SeleniumTestProject.pages
{
    public class WebFormPage : BasePage 
    {
        private readonly String _url = "https://www.selenium.dev/selenium/web/web-form.html";
        private readonly By _textInput = By.Name("my-text");
        private readonly By _submitButton = By.CssSelector("button[type='submit']");
        public WebFormPage(IWebDriver driver, int waitInSeconds) : base(driver, waitInSeconds) { }

        public WebFormPage Open()
        {
            driver.Navigate().GoToUrl(_url);
            wait.Until(driver =>
            {
                IWebElement textInput = driver.FindElement(_textInput);
                return textInput.Displayed ? textInput : null;
            });
            return this;
        }

        public WebFormPage TypeText(String text) {
            IWebElement textInput = driver.FindElement(_textInput);
            textInput.Clear();
            textInput.SendKeys(text);
            return this;
        }

        public SubmittedPage Submit()
        {
            IWebElement submit = wait.Until(driver =>
            {
                IWebElement submit = driver.FindElement(_submitButton);
                return submit.Displayed ? submit : null;
            });
            submit.Click();
            return new SubmittedPage(driver, waitDurationSeconds);
        }

    }
}
