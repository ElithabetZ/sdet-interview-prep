using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestProject.pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;
        protected readonly WebDriverWait wait;
        protected readonly int waitDurationSeconds;
        protected BasePage(IWebDriver driver, int waitInSeconds) {
            this.driver = driver;
            this.waitDurationSeconds = waitInSeconds;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitInSeconds));
        }
    }
}
