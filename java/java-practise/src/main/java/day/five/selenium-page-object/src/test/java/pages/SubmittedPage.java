package pages;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;

public class SubmittedPage extends BasePage{

    private final By messageText = By.id("message");

    public SubmittedPage(WebDriver driver, int waitInSeconds){
        super(driver, waitInSeconds);
        wait.until(ExpectedConditions.visibilityOfElementLocated(messageText));
    }

    public String getMessage(){
        return driver.findElement(messageText).getText();
    }

}
