package pages;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.time.Duration;

public class WebFormPage {

    private static final String URL = "https://www.selenium.dev/selenium/web/web-form.html";
    private final WebDriver driver;
    private final WebDriverWait wait;
    private final int waitDuration;

    private final By textInputLocator = By.name("my-text");
    private final By submitButton = By.cssSelector("button[type='submit']");

    public WebFormPage(WebDriver driver, int waitInSeconds){
        this.driver = driver;
        this.waitDuration = waitInSeconds;
        this.wait = new WebDriverWait(driver, Duration.ofSeconds(waitDuration));
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
