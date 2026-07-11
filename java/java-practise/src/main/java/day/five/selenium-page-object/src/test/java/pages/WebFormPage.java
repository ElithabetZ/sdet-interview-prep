package pages;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;

public class WebFormPage extends BasePage {

    private static final String URL = "https://www.selenium.dev/selenium/web/web-form.html";
    private final By textInputLocator = By.name("my-text");
    private final By submitButton = By.cssSelector("button[type='submit']");

    public WebFormPage(WebDriver driver, int waitInSeconds){
        super(driver, waitInSeconds);
    }

    public WebFormPage open(){
        driver.get(URL);
        wait.until(ExpectedConditions.visibilityOfElementLocated(textInputLocator));
        return this;
    }

    public WebFormPage typeText(String text){
        WebElement input = driver.findElement(textInputLocator);
        input.clear();
        input.sendKeys(text);
        return this;
    }

    public SubmittedPage submit(){
        WebElement button = wait.until(ExpectedConditions.visibilityOfElementLocated(submitButton));
        button.click();
        return new SubmittedPage(driver, waitDuration);
    }

}
