package pages;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.time.Duration;

public class SubmittedPage {

    private final WebDriver driver;
    private final WebDriverWait wait;

    private final By messageText = By.id("message");

    public SubmittedPage(WebDriver driver, int waitInSeconds){
        this.driver = driver;
        this.wait = new WebDriverWait(driver, Duration.ofSeconds(waitInSeconds));
        wait.until(ExpectedConditions.visibilityOfElementLocated(messageText));
    }

    public String getMessage(){
        return driver.findElement(messageText).getText();
    }

}
