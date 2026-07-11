using OpenQA.Selenium;

namespace SeleniumTestProject.pages
{
    public class SubmittedPage : BasePage
    {
        private readonly By _messageText = By.Id("message");
        public SubmittedPage(IWebDriver driver, int waitTimeInSeconds): base(driver, waitTimeInSeconds) {
            wait.Until(driver =>
            {
                IWebElement messageText = driver.FindElement(_messageText);
                return messageText.Displayed ? messageText : null;
            });
        }

        public String MessageText()
        {
           return driver.FindElement(_messageText).Text;
        }
    }
}
